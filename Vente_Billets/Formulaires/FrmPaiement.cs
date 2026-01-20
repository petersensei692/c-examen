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
    public partial class FrmPaiement : Form
    {
        public FrmPaiement()
        {
            InitializeComponent();
        }

        private void FrmPaiement_Load(object sender, EventArgs e)
        {
            if (ClsDict.Instance.OpenConnection())
            {
                ClsPaiement.ChargementPaiement(dgvPaiement, txtIdPaiement, id, cmbModePaie);
                
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
                
                ClsDict.Instance.loadComboBillets(cmbClient); // Utiliser cmbClient pour stocker le Billet
            }
        }

        ClsPaiement paie = new ClsPaiement();

        private void InsertUpdatePaiement(int a)
        {
            paie.ModePaiement = cmbModePaie.Text;
            paie.Montant = double.Parse(txtMontant.Text);
            paie.DatePaiement = DateTime.Parse(DatePaie.Text);
            paie.RefAgent = FrmDashboard.LoggedInAgentId; // Utiliser l'agent connecté
            
            // Récupérer l'ID du billet depuis le texte affiché
            int billetId = ClsDict.Instance.GetBilletIdFromDisplayText(cmbClient.Text);
            if (billetId == 0)
            {
                MessageBox.Show("Veuillez sélectionner un billet valide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            // Récupérer automatiquement le client depuis le billet sélectionné
            int refClient = 0;
            int refPlace = 0;
            
            // Récupérer le client et la place depuis le billet
            DataTable billetData = ClsDict.Instance.loadData("Affichez_Billet");
            DataRow billetRow = billetData.AsEnumerable().FirstOrDefault(r => r.Field<int>("id") == billetId);
            if (billetRow != null && billetRow.Table.Columns.Contains("Client"))
            {
                object clientObj = billetRow["Client"];
                if (clientObj != null && clientObj != DBNull.Value)
                {
                    string clientName = clientObj.ToString();
                    if (!string.IsNullOrEmpty(clientName))
                    {
                        refClient = int.Parse(ClsDict.Instance.getcode_Combo("tClients", "id", "noms", clientName));
                    }
                }
            }
            
            // Si pas de client dans le billet, afficher une erreur
            if (refClient == 0)
            {
                MessageBox.Show("Le billet sélectionné n'a pas de client associé. Veuillez d'abord créer le billet avec un client.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            // Récupérer refPlace depuis le billet
            refPlace = ClsDict.Instance.GetPlaceIdFromBillet(billetId);
            
            paie.RefBillet = billetId;
            paie.RefClient = refClient;

            if (a == 1) // Ajouter - Créer la facture et lier au billet
            {
                paie.Id = 0;
                
                // Créer la facture (refPlace déjà récupéré plus haut)
                int factureId = ClsDict.Instance.CreateFacture(refClient, paie.RefAgent, refPlace);
                
                // Lier le billet à la facture
                ClsDict.Instance.UpdateBilletFacture(billetId, factureId);
                
                // Créer le paiement
                ClsDict.Instance.SaveUpdatePaiement(paie);
                
                MessageBox.Show($"Paiement enregistré avec succès!\nFacture ID: {factureId}", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Rafraîchir le DataGridView
                dgvPaiement.DataSource = null;
                dgvPaiement.Refresh();
                ClsPaiement.ChargementPaiement(dgvPaiement, txtIdPaiement, id, cmbModePaie);
            }
            else if (a == 2)
            {
                paie.Id = int.Parse(txtIdPaiement.Text);
                ClsDict.Instance.SaveUpdatePaiement(paie);
                // Rafraîchir le DataGridView
                dgvPaiement.DataSource = null;
                dgvPaiement.Refresh();
                ClsPaiement.ChargementPaiement(dgvPaiement, txtIdPaiement, id, cmbModePaie);
            }
            else if (a == 3)
            {
                ClsDict.Instance.Deletedata("tPaiement", "id", int.Parse(txtIdPaiement.Text));
                // Rafraîchir le DataGridView
                dgvPaiement.DataSource = null;
                dgvPaiement.Refresh();
                ClsPaiement.ChargementPaiement(dgvPaiement, txtIdPaiement, id, cmbModePaie);
            }
        }

        private void BtnAjouterAgent_Click(object sender, EventArgs e)
        {
            
        }

        private void btnUpdateAgent_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnDeleteAgent_Click(object sender, EventArgs e)
        {
           
        }

        private void dgvPaiement_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dgvPaiement_CellClick_1(sender, e);
            }
        }

        private void txtIdPaiement_TextChanged(object sender, EventArgs e)
        {

        }

        private void id_Click(object sender, EventArgs e)
        {

        }

        private void txtRecherche_TextChanged(object sender, EventArgs e)
        {
            dgvPaiement.DataSource = ClsDict.Instance.Rechercher(txtRecherche.Text.Trim(), "Affichez_Paiement", "Client");
        }

        private void dgvPaiement_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvPaiement.Rows.Count)
            {
                try
                {
                    DataGridViewRow row = dgvPaiement.Rows[e.RowIndex];

                    if (row.Cells["Numero Paiement"] != null && row.Cells["Numero Paiement"].Value != null)
                        txtIdPaiement.Text = row.Cells["Numero Paiement"].Value.ToString();
                    
                    if (row.Cells["Date de Paiement"] != null && row.Cells["Date de Paiement"].Value != null)
                        DatePaie.Text = row.Cells["Date de Paiement"].Value.ToString();
                    
                    if (row.Cells["Mode de Paiement"] != null && row.Cells["Mode de Paiement"].Value != null)
                        cmbModePaie.Text = row.Cells["Mode de Paiement"].Value.ToString();
                    
                    if (row.Cells["Montant a Payer"] != null && row.Cells["Montant a Payer"].Value != null)
                        txtMontant.Text = row.Cells["Montant a Payer"].Value.ToString();
                    
                    if (row.Cells["Agent"] != null && row.Cells["Agent"].Value != null)
                    {
                        string agentName = row.Cells["Agent"].Value.ToString();
                        ClsDict.Instance.loadCombo("tAgents", "noms", cmbAgent);
                        cmbAgent.Text = agentName;
                        cmbAgent.Enabled = false; // Désactiver pour empêcher la modification
                    }
                    
                    // Récupérer le billet depuis la vue
                    if (row.Cells["Numero Billet"] != null && row.Cells["Numero Billet"].Value != null && row.Cells["Numero Billet"].Value != DBNull.Value)
                    {
                        int billetId = int.Parse(row.Cells["Numero Billet"].Value.ToString());
                        // Recharger le combobox pour trouver le bon texte
                        ClsDict.Instance.loadComboBillets(cmbClient);
                        // Trouver l'élément correspondant
                        for (int i = 0; i < cmbClient.Items.Count; i++)
                        {
                            string itemText = cmbClient.Items[i].ToString();
                            if (ClsDict.Instance.GetBilletIdFromDisplayText(itemText) == billetId)
                            {
                                cmbClient.SelectedIndex = i;
                                break;
                            }
                        }
                    }

                    txtIdPaiement.Visible = true;
                    id.Visible = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors du chargement des données : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdPaiement.Text))
            {
                MessageBox.Show("Veuillez sélectionner un paiement pour imprimer le reçu", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int paiementId;
            if (!int.TryParse(txtIdPaiement.Text, out paiementId))
            {
                MessageBox.Show("ID de paiement invalide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Recu recu = new Recu(paiementId);
            recu.PrintPreview();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            InsertUpdatePaiement(1);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            InsertUpdatePaiement(2);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            InsertUpdatePaiement(3);
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdPaiement.Text))
            {
                MessageBox.Show("Veuillez sélectionner un paiement pour imprimer le reçu", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int paiementId;
            if (!int.TryParse(txtIdPaiement.Text, out paiementId))
            {
                MessageBox.Show("ID de paiement invalide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Recu recu = new Recu(paiementId);
            recu.PrintPreview();
        }
    }
}
