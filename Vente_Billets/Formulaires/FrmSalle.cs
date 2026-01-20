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
            DataGridViewRow row = dgvSalle.Rows[e.RowIndex];

            txtIdSalle.Text = row.Cells["id"].Value.ToString(); // ID
            txtNomSalle.Text = row.Cells["nomSalle"].Value.ToString();
            txtAdresse.Text = row.Cells["adresse"].Value.ToString();
            txtNbrePlaces.Text = row.Cells["nombrePlace"].Value.ToString();

            txtIdSalle.Visible = true;
            lblId.Visible = true;
        }

        private void txtRecherche_TextChanged(object sender, EventArgs e)
        {
            dgvSalle.DataSource = ClsDict.Instance.Rechercher(txtRecherche.Text.Trim(), "tSalle", "nomSalle");
        }
    }
}
