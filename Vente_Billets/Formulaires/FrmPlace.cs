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

namespace Vente_Billets.Formulaires
{
    public partial class FrmPlace : Form
    {
        public FrmPlace()
        {
            InitializeComponent();
        }

        private void FrmPlace_Load(object sender, EventArgs e)
        {
            if (ClsDict.Instance.OpenConnection())
            {
                ClsPlace.ChargementPlace(dgvPlace, txtIdPlace, id, cmbSallePlace);
                ClsDict.Instance.loadCombo("tCategorie", "designation", cmbCatPlace);
            }
            
        }

        ClsPlace pl = new ClsPlace();
        private void InsertUpdatePlace(int a)
        {
            pl.RefCategorie = int.Parse(ClsDict.Instance.getcode_Combo("tCategorie", "id", "designation", cmbCatPlace.Text));
            pl.NumPlace = txtNumPlace.Text;
            pl.RefSalle = int.Parse(ClsDict.Instance.getcode_Combo("tSalle", "id", "nomSalle", cmbSallePlace.Text));

            if (a == 1)
            {
                pl.Id = 0;
                ClsDict.Instance.SaveUpdatePlace(pl);
                ClsPlace.ChargementPlace(dgvPlace, txtIdPlace, id, cmbSallePlace);
            }
            else if (a == 2)
            {
                pl.Id = int.Parse(txtIdPlace.Text);
                ClsDict.Instance.SaveUpdatePlace(pl);
                ClsPlace.ChargementPlace(dgvPlace, txtIdPlace, id, cmbSallePlace);
            }
            else if (a == 3)
            {
                ClsDict.Instance.Deletedata("tPlace", "id", int.Parse(txtIdPlace.Text));
                ClsPlace.ChargementPlace(dgvPlace, txtIdPlace, id, cmbSallePlace);
            }
        }

        private void BtnAjouterAgent_Click(object sender, EventArgs e)
        {
            InsertUpdatePlace(1);
        }

        private void btnUpdateAgent_Click(object sender, EventArgs e)
        {
            InsertUpdatePlace(2);
        }

        private void BtnDeleteAgent_Click(object sender, EventArgs e)
        {
            InsertUpdatePlace(3);
        }

        private void dgvPlace_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dgvPlace_CellClick(sender, e);
            }
        }

        private void txtRecherche_TextChanged(object sender, EventArgs e)
        {
            dgvPlace.DataSource = ClsDict.Instance.Rechercher(txtRecherche.Text.Trim(), "Affichez_Place", "Numero_place");
        }

        private void dgvPlace_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvPlace.Rows.Count)
            {
                try
                {
                    DataGridViewRow row = dgvPlace.Rows[e.RowIndex];

                    // Récupérer l'ID depuis la colonne "id"
                    if (dgvPlace.Columns.Contains("id") && row.Cells["id"].Value != null && row.Cells["id"].Value != DBNull.Value)
                        txtIdPlace.Text = row.Cells["id"].Value.ToString();
                    
                    if (dgvPlace.Columns.Contains("refCategorie") && row.Cells["refCategorie"].Value != null && row.Cells["refCategorie"].Value != DBNull.Value)
                    {
                        string catId = row.Cells["refCategorie"].Value.ToString();
                        cmbCatPlace.Text = ClsDict.Instance.GetNomDepuisId("tCategorie", "id", "designation", catId);
                    }
                    else if (dgvPlace.Columns.Contains("Categorie") && row.Cells["Categorie"].Value != null && row.Cells["Categorie"].Value != DBNull.Value)
                        cmbCatPlace.Text = row.Cells["Categorie"].Value.ToString();
                    
                    if (dgvPlace.Columns.Contains("numPlace") && row.Cells["numPlace"].Value != null && row.Cells["numPlace"].Value != DBNull.Value)
                        txtNumPlace.Text = row.Cells["numPlace"].Value.ToString();
                    else if (dgvPlace.Columns.Contains("Numero_place") && row.Cells["Numero_place"].Value != null && row.Cells["Numero_place"].Value != DBNull.Value)
                        txtNumPlace.Text = row.Cells["Numero_place"].Value.ToString();
                    
                    if (dgvPlace.Columns.Contains("refSalle") && row.Cells["refSalle"].Value != null && row.Cells["refSalle"].Value != DBNull.Value)
                    {
                        string salleId = row.Cells["refSalle"].Value.ToString();
                        cmbSallePlace.Text = ClsDict.Instance.GetNomDepuisId("tSalle", "id", "nomSalle", salleId);
                    }
                    else if (dgvPlace.Columns.Contains("Salle") && row.Cells["Salle"].Value != null && row.Cells["Salle"].Value != DBNull.Value)
                        cmbSallePlace.Text = row.Cells["Salle"].Value.ToString();

                    txtIdPlace.Visible = true;
                    id.Visible = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors du chargement des données : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void cmbCatPlace_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
