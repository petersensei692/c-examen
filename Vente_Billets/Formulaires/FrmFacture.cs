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
    public partial class FrmFacture : Form
    {
        public FrmFacture()
        {
            InitializeComponent();
        }

        private void FrmFacture_Load(object sender, EventArgs e)
        {
            if (ClsDict.Instance.OpenConnection())
            {
                ClsFacture.ChargementFacture(dgvFacture, txtIdfacture, id);
                ClsDict.Instance.loadCombo("tCategorie", "designation", cmbPlace);
                ClsDict.Instance.loadCombo("tClients", "noms", cmbClient);
                ClsDict.Instance.loadCombo("tAgents", "noms", cmbAgent);
            }
        }

        ClsFacture fact = new ClsFacture();

        private void InsertUpdateFacture(int a)
        {
            fact.RefAgent = int.Parse(ClsDict.Instance.getcode_Combo("tAgents", "id", "noms", cmbAgent.Text));
            fact.RefClient = int.Parse(ClsDict.Instance.getcode_Combo("tClients", "id", "noms", cmbClient.Text));
            // refPlace fait référence à tPlace, donc on récupère l'ID de la place depuis son numéro
            // La vue affiche le numéro de place dans la colonne "Place"
            // Note: Si cmbPlace contient le numéro de place, utiliser directement
            // Sinon, si c'est une catégorie, il faudrait un autre combobox pour les places
            // Pour l'instant, on garde la logique originale qui utilise la catégorie
            // mais cela devrait être amélioré pour utiliser directement une place
            string catId = ClsDict.Instance.getcode_Combo("tCategorie", "id", "designation", cmbPlace.Text);
            if (!string.IsNullOrEmpty(catId))
            {
                // Récupérer la première place de cette catégorie (logique temporaire)
                fact.RefPlace = int.Parse(ClsDict.Instance.getcode_Combo("tPlace", "id", "refCategorie", catId));
            }

            if (a == 1)
            {
                fact.Id = 0;
                ClsDict.Instance.SaveUpdatefacture(fact);
                ClsFacture.ChargementFacture(dgvFacture, txtIdfacture, id);
            }

            else if (a == 2)
            {
                fact.Id = int.Parse(txtIdfacture.Text);
                ClsDict.Instance.SaveUpdatefacture(fact);
                ClsFacture.ChargementFacture(dgvFacture, txtIdfacture, id);
            }

            else if (a == 3)
            {
                ClsDict.Instance.Deletedata("Facture", "id", int.Parse(txtIdfacture.Text));
                ClsFacture.ChargementFacture(dgvFacture, txtIdfacture, id);
            }
        }

        private void BtnAjouterAgent_Click(object sender, EventArgs e)
        {
            InsertUpdateFacture(1);
        }

        private void btnUpdateAgent_Click(object sender, EventArgs e)
        {
            InsertUpdateFacture(2);
        }

        private void BtnDeleteAgent_Click(object sender, EventArgs e)
        {
            InsertUpdateFacture(3);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdfacture.Text))
            {
                MessageBox.Show("Veuillez sélectionner une facture", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int factureId;
            if (!int.TryParse(txtIdfacture.Text, out factureId))
            {
                MessageBox.Show("ID de facture invalide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Facture facture = new Facture(factureId);
            facture.PrintPreview();
        }

        private void dgvFacture_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dgvFacture_CellClick_1(sender, e);
            }
        }

        private void dgvFacture_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void id_Click(object sender, EventArgs e)
        {

        }

        private void cmbAgent_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbPlace_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtIdfacture_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbClient_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dgvFacture_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvFacture.Rows.Count)
            {
                try
                {
                    DataGridViewRow row = dgvFacture.Rows[e.RowIndex];

                    // Gérer la vue Affichez_Facture_Complete qui affiche les noms
                    if (dgvFacture.Columns.Contains("id") && row.Cells["id"].Value != null && row.Cells["id"].Value != DBNull.Value)
                        txtIdfacture.Text = row.Cells["id"].Value.ToString();
                    
                    // Utiliser les noms de colonnes de la vue Affichez_Facture_Complete
                    if (dgvFacture.Columns.Contains("Categorie") && row.Cells["Categorie"].Value != null && row.Cells["Categorie"].Value != DBNull.Value)
                        cmbPlace.Text = row.Cells["Categorie"].Value.ToString();
                    
                    if (dgvFacture.Columns.Contains("Agent") && row.Cells["Agent"].Value != null && row.Cells["Agent"].Value != DBNull.Value)
                        cmbAgent.Text = row.Cells["Agent"].Value.ToString();
                    
                    if (dgvFacture.Columns.Contains("Client") && row.Cells["Client"].Value != null && row.Cells["Client"].Value != DBNull.Value)
                        cmbClient.Text = row.Cells["Client"].Value.ToString();

                    txtIdfacture.Visible = true;
                    id.Visible = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors du chargement des données : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtRecherche_TextChanged(object sender, EventArgs e)
        {
            dgvFacture.DataSource = ClsDict.Instance.Rechercher(txtRecherche.Text.Trim(), "Affichez_Facture", "Client");
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            InsertUpdateFacture(1);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            InsertUpdateFacture(2);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            InsertUpdateFacture(3);
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdfacture.Text))
            {
                MessageBox.Show("Veuillez sélectionner une facture", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int factureId;
            if (!int.TryParse(txtIdfacture.Text, out factureId))
            {
                MessageBox.Show("ID de facture invalide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Facture facture = new Facture(factureId);
            facture.PrintPreview();
        }
    }
}
