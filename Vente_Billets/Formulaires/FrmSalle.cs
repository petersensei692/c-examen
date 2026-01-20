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
    public partial class FrmSalle : Form
    {
        public FrmSalle()
        {
            InitializeComponent();
        }

        private void FrmSalle_Load(object sender, EventArgs e)
        {
            if (ClsDict.Instance.OpenConnection())
            {
                ClsSalle.ChargementSalle(dgvSalle, txtIdSalle, lblId);
            }
        }

        ClsSalle sa = new ClsSalle();
        private void InsertUpdateSalle(int a)
        {
            sa.NomSalle = txtNomSalle.Text;
            sa.Adesse = txtAdresse.Text;
            sa.NombrePlace = txtNbrePlaces.Text;

            if (a == 1)
            {
                sa.Id = 0;
                ClsDict.Instance.SaveUpdateSalle(sa);
                ClsSalle.ChargementSalle(dgvSalle, txtIdSalle, lblId);

            }
            else if (a == 2)
            {
                sa.Id = int.Parse(txtIdSalle.Text);
                ClsDict.Instance.SaveUpdateSalle(sa);
                ClsSalle.ChargementSalle(dgvSalle, txtIdSalle, lblId);
            }
            else if (a == 3)
            {
                ClsDict.Instance.Deletedata("tSalle", "id", int.Parse(txtIdSalle.Text));
                ClsSalle.ChargementSalle(dgvSalle, txtIdSalle, lblId);
            }
        }

        private void BtnAjouterAgent_Click(object sender, EventArgs e)
        {
            InsertUpdateSalle(1);
        }

        private void btnUpdateAgent_Click(object sender, EventArgs e)
        {
            InsertUpdateSalle(2);
        }

        private void BtnDeleteAgent_Click(object sender, EventArgs e)
        {
            InsertUpdateSalle(3);
        }

        private void dgvSalle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvSalle_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvSalle.Rows.Count)
            {
                try
                {
                    DataGridViewRow row = dgvSalle.Rows[e.RowIndex];

                    if (dgvSalle.Columns.Contains("id") && row.Cells["id"].Value != null && row.Cells["id"].Value != DBNull.Value)
                        txtIdSalle.Text = row.Cells["id"].Value.ToString();
                    
                    if (dgvSalle.Columns.Contains("nomSalle") && row.Cells["nomSalle"].Value != null && row.Cells["nomSalle"].Value != DBNull.Value)
                        txtNomSalle.Text = row.Cells["nomSalle"].Value.ToString();
                    
                    if (dgvSalle.Columns.Contains("adresse") && row.Cells["adresse"].Value != null && row.Cells["adresse"].Value != DBNull.Value)
                        txtAdresse.Text = row.Cells["adresse"].Value.ToString();
                    
                    if (dgvSalle.Columns.Contains("nombrePlace") && row.Cells["nombrePlace"].Value != null && row.Cells["nombrePlace"].Value != DBNull.Value)
                        txtNbrePlaces.Text = row.Cells["nombrePlace"].Value.ToString();

                    txtIdSalle.Visible = true;
                    lblId.Visible = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors du chargement des données : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtRecherche_TextChanged(object sender, EventArgs e)
        {
            dgvSalle.DataSource = ClsDict.Instance.Rechercher(txtRecherche.Text.Trim(), "tSalle", "nomSalle");
        }
    }
}
