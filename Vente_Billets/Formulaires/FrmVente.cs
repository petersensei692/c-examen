using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vente_Billets.Classes;
using Vente_Billets.Rapports;

namespace Vente_Billets.Formulaires
{
    public partial class FrmVente : Form
    {
        private int factureId = 0; // Stocker l'ID de la facture créée

        public FrmVente()
        {
            InitializeComponent();
        }

        private void FrmVente_Load(object sender, EventArgs e)
        {
            if (ClsDict.Instance.OpenConnection())
            {
                ClsBillets.ChargementBillets(dgvBillet, txtIdBillet, id);
                ClsDict.Instance.loadCombo("tSpectacle", "titre", cmbSpectacle);
                // Ne pas charger les places au départ - elles seront chargées quand un spectacle est sélectionné
                cmbPlace.Items.Clear();
                cmbPlace.Enabled = false;
                ClsDict.Instance.loadCombo("tClients", "noms", cmbClient);
                
                // Auto-remplir l'agent connecté
                if (FrmDashboard.LoggedInAgentId > 0)
                {
                    string agentName = ClsDict.Instance.GetNomDepuisId("tAgents", "id", "noms", FrmDashboard.LoggedInAgentId.ToString());
                    if (!string.IsNullOrEmpty(agentName))
                    {
                        ClsDict.Instance.loadCombo("tAgents", "noms", cmbAgent);
                        cmbAgent.Text = agentName;
                        cmbAgent.Enabled = false; // Désactiver pour empêcher la modification
                    }
                }
                
                // Définir la date minimum à aujourd'hui
                DateAchat.MinDate = DateTime.Now.Date;
                
                // Ajouter un handler pour mettre à jour la date du spectacle quand un spectacle est sélectionné
                cmbSpectacle.SelectedIndexChanged += CmbSpectacle_SelectedIndexChanged;
            }
        }

        private void CmbSpectacle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSpectacle.SelectedItem != null && !string.IsNullOrEmpty(cmbSpectacle.Text))
            {
                int spectacleId = int.Parse(ClsDict.Instance.getcode_Combo("tSpectacle", "id", "titre", cmbSpectacle.Text));
                
                // Ne pas modifier la date d'achat automatiquement - elle doit rester la date actuelle
                // La date du spectacle sera récupérée depuis la base de données lors de l'impression
                
                // Charger les places de la salle du spectacle sélectionné
                int? salleId = ClsDict.Instance.GetSalleIdFromSpectacle(spectacleId);
                if (salleId.HasValue)
                {
                    // Si on modifie un billet existant, inclure sa place dans la liste
                    int? billetId = null;
                    if (!string.IsNullOrWhiteSpace(txtIdBillet.Text) && int.TryParse(txtIdBillet.Text, out int id))
                    {
                        billetId = id;
                    }
                    ClsDict.Instance.loadComboPlacesBySalle(salleId.Value, cmbPlace, billetId);
                    cmbPlace.Enabled = true;
                    // Ne pas réinitialiser la sélection si on modifie un billet existant
                    if (!billetId.HasValue)
                    {
                        cmbPlace.Text = "";
                    }
                }
                else
                {
                    cmbPlace.Items.Clear();
                    cmbPlace.Enabled = false;
                }
            }
            else
            {
                cmbPlace.Items.Clear();
                cmbPlace.Enabled = false;
            }
        }

        ClsBillets bi = new ClsBillets();

        private void InsertUpdateVente(int a)
        {
            // Validation des champs requis
            if (string.IsNullOrWhiteSpace(txtPrix.Text))
            {
                MessageBox.Show("Veuillez entrer un prix", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(cmbSpectacle.Text))
            {
                MessageBox.Show("Veuillez sélectionner un spectacle", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(cmbPlace.Text))
            {
                MessageBox.Show("Veuillez sélectionner une place", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(cmbClient.Text))
            {
                MessageBox.Show("Veuillez sélectionner un client", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validation de la date d'achat (ne peut pas être dans le passé)
            DateTime dateAchat = DateAchat.Value;
            if (dateAchat.Date < DateTime.Now.Date)
            {
                MessageBox.Show("La date d'achat ne peut pas être antérieure à aujourd'hui.", "Erreur de validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Utiliser la date actuelle pour la date d'achat (pas la date du spectacle)
            bi.Prix = double.Parse(txtPrix.Text);
            bi.DateAchat = DateTime.Now; // Utiliser la date actuelle pour la date d'achat
            bi.RefAgent1 = FrmDashboard.LoggedInAgentId; // Utiliser l'agent connecté
            
            // Récupérer le client depuis le combobox
            bi.RefClient1 = int.Parse(ClsDict.Instance.getcode_Combo("tClients", "id", "noms", cmbClient.Text));
            
            bi.RefPlace1 = int.Parse(ClsDict.Instance.getcode_Combo("tPlace", "id", "numPlace", cmbPlace.Text));
            bi.RefSpectacle1 = int.Parse(ClsDict.Instance.getcode_Combo("tSpectacle", "id", "titre", cmbSpectacle.Text));
            bi.RefCat1 = 0; // Pas de catégorie (déjà dans place)
            bi.RefFacture = 0; // Pas de facture lors de la création du billet
            bi.Statut = false; // Billet non vendu par défaut

            if (a == 1) // Ajouter - Créer seulement le Billet (pas de facture)
            {
                bi.Id = 0;
                ClsDict.Instance.SaveUpdateBillet(bi);
                MessageBox.Show($"Billet créé avec succès!", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CleanTextBillet();
                // Rafraîchir le DataGridView
                dgvBillet.DataSource = null;
                dgvBillet.Refresh();
                ClsBillets.ChargementBillets(dgvBillet, txtIdBillet, id);
            }
            else if (a == 2) // Modifier
            {
                bi.Id = int.Parse(txtIdBillet.Text);
                ClsDict.Instance.SaveUpdateBillet(bi);
                // Rafraîchir le DataGridView
                dgvBillet.DataSource = null;
                dgvBillet.Refresh();
                ClsBillets.ChargementBillets(dgvBillet, txtIdBillet, id);
            }
            else if (a == 3) // Supprimer
            {
                ClsDict.Instance.Deletedata("tBillets", "id", int.Parse(txtIdBillet.Text));
                // Rafraîchir le DataGridView
                dgvBillet.DataSource = null;
                dgvBillet.Refresh();
                ClsBillets.ChargementBillets(dgvBillet, txtIdBillet, id);
            }
        }

        private void BtnAjouterAgent_Click(object sender, EventArgs e)
        {
            InsertUpdateVente(1);
            CleanTextBillet();
        }

        private void btnUpdateAgent_Click(object sender, EventArgs e)
        {
            InsertUpdateVente(2);
            CleanTextBillet();
        }

        private void BtnDeleteAgent_Click(object sender, EventArgs e)
        {
            InsertUpdateVente(3);
            CleanTextBillet();
        }

        private void dgvBillet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dgvBillet_CellClick_1(sender, e);
            }
        }

        private void txtIdBillet_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void DateAchat_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cmbPlace_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void cmbAgent_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void id_Click(object sender, EventArgs e)
        {

        }

        private void txtRecherche_TextChanged(object sender, EventArgs e)
        {
            dgvBillet.DataSource = ClsDict.Instance.Rechercher(txtRecherche.Text.Trim(), "Affichez_Billet", "Client");
        }

        private void dgvBillet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvBillet_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvBillet.Rows.Count)
            {
                try
                {
                    DataGridViewRow row = dgvBillet.Rows[e.RowIndex];

                    if (row.Cells["id"] != null && row.Cells["id"].Value != null)
                        txtIdBillet.Text = row.Cells["id"].Value.ToString();
                    
                    if (row.Cells["dateAchat"] != null && row.Cells["dateAchat"].Value != null)
                        DateAchat.Text = row.Cells["dateAchat"].Value.ToString();
                    
                    if (row.Cells["prix"] != null && row.Cells["prix"].Value != null)
                        txtPrix.Text = row.Cells["prix"].Value.ToString();
                    
                    if (row.Cells["Spectacle"] != null && row.Cells["Spectacle"].Value != null)
                    {
                        cmbSpectacle.Text = row.Cells["Spectacle"].Value.ToString();
                        // Charger les places de la salle du spectacle (inclure la place du billet en cours de modification)
                        int spectacleId = int.Parse(ClsDict.Instance.getcode_Combo("tSpectacle", "id", "titre", cmbSpectacle.Text));
                        int? salleId = ClsDict.Instance.GetSalleIdFromSpectacle(spectacleId);
                        if (salleId.HasValue)
                        {
                            int? billetId = null;
                            if (!string.IsNullOrWhiteSpace(txtIdBillet.Text) && int.TryParse(txtIdBillet.Text, out int id))
                            {
                                billetId = id;
                            }
                            ClsDict.Instance.loadComboPlacesBySalle(salleId.Value, cmbPlace, billetId);
                            cmbPlace.Enabled = true;
                        }
                    }
                    
                    if (row.Cells["Numero_Place"] != null && row.Cells["Numero_Place"].Value != null)
                        cmbPlace.Text = row.Cells["Numero_Place"].Value.ToString();
                    
                    if (row.Cells["Agent"] != null && row.Cells["Agent"].Value != null)
                    {
                        string agentName = row.Cells["Agent"].Value.ToString();
                        ClsDict.Instance.loadCombo("tAgents", "noms", cmbAgent);
                        cmbAgent.Text = agentName;
                        cmbAgent.Enabled = false; // Désactiver pour empêcher la modification
                    }
                    
                    if (row.Cells["Client"] != null && row.Cells["Client"].Value != null && row.Cells["Client"].Value != DBNull.Value)
                    {
                        ClsDict.Instance.loadCombo("tClients", "noms", cmbClient);
                        cmbClient.Text = row.Cells["Client"].Value.ToString();
                    }
                    else
                    {
                        ClsDict.Instance.loadCombo("tClients", "noms", cmbClient);
                        cmbClient.Text = "";
                    }

                    // Ne pas modifier la date d'achat avec la date du spectacle
                    // La date d'achat doit rester celle du billet (dateAchat)
                    // La date du spectacle sera affichée séparément dans le billet imprimé

                    txtIdBillet.Visible = true;
                    id.Visible = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors du chargement des données : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CleanTextBillet()
        {
            txtPrix.Text = "";
            txtRecherche.Text = "";
            cmbClient.Text = "";
            cmbSpectacle.Text = "";
            cmbPlace.Text = "";
            txtIdBillet.Visible = false;
            id.Visible = false;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            

            
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            InsertUpdateVente(1);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            InsertUpdateVente(2);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            InsertUpdateVente(3);
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdBillet.Text))
            {
                MessageBox.Show("Veuillez sélectionner un billet", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int billetId;
            if (!int.TryParse(txtIdBillet.Text, out billetId))
            {
                MessageBox.Show("ID de billet invalide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Vérifier si le billet existe et peut être imprimé
            DataTable billetData = ClsDict.Instance.Imprimez_Billet(billetId);
            if (billetData == null || billetData.Rows.Count == 0)
            {
                MessageBox.Show("Aucune donnée trouvée pour ce billet. Veuillez vérifier que le billet existe dans la base de données.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ClsDict.Instance.GetStatut(billetId))
            {
                ClsDict.Instance.SetStatut(billetId);
                // Rafraîchir le DataGridView
                dgvBillet.DataSource = null;
                dgvBillet.Refresh();
                ClsBillets.ChargementBillets(dgvBillet, txtIdBillet, id);
            }
            else
            {
                MessageBox.Show("Billet Vendu", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Billet billet = new Billet(billetId);
            billet.PrintPreview();
        }

        // Le bouton "Imprimer Facture" a été retiré car la facture est créée lors du paiement

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
