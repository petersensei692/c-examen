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
    public partial class FrmClient : Form
    {
        public FrmClient()
        {
            InitializeComponent();
        }

        private void FrmClient_Load(object sender, EventArgs e)
        {
            if (ClsDict.Instance.OpenConnection())
            {
                ClsClients.ChargementClient(dgvClient, txtId, lblId, cmbGenre);
            }
        }

        ClsClients cl = new ClsClients();

        private void InsertUpdateClient(int a)
        {
            cl.Noms = txtNom.Text;
            cl.Adresse = txtAdress.Text;
            cl.Contact = txtContact.Text;
            cl.Age = (int)NudAge.Value;
            cl.Genre = cmbGenre.Text;

            if (a == 1)
            {
                cl.Id = 0;
                ClsDict.Instance.SaveUpdateClients(cl);
                dgvClient.DataSource = ClsDict.Instance.loadData("tClients");
            }
            else if (a == 2)
            {
                cl.Id = int.Parse(txtId.Text);
                ClsDict.Instance.SaveUpdateClients(cl);
                dgvClient.DataSource = ClsDict.Instance.loadData("tClients");
            }
            else if (a == 3)
            {
                ClsDict.Instance.Deletedata("tClients", "id", int.Parse(txtId.Text));
                dgvClient.DataSource = ClsDict.Instance.loadData("tClients");
            }
        }

        private void BtnAjoutClient_Click(object sender, EventArgs e)
        {
            InsertUpdateClient(1);
            CleanTextClient();
        }

        private void BtnUpdateClient_Click(object sender, EventArgs e)
        {
            InsertUpdateClient(2);
            CleanTextClient();
        }

        private void BtnDeleteClient_Click(object sender, EventArgs e)
        {
            InsertUpdateClient(3);
            CleanTextClient();
        }

        private void dgvClient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void CleanTextClient()
        {
            txtAdress.Text = "";
            txtContact.Text = "";
            cmbGenre.Text = "";
            txtNom.Text = "";
            NudAge.Value = 0;
            txtId.Visible = false;
            lblId.Visible = false;
        }

        private void dgvClient_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvClient.Rows[e.RowIndex];

            txtId.Text = row.Cells["id"].Value.ToString(); // ID
            txtNom.Text = row.Cells["noms"].Value.ToString();
            txtAdress.Text = row.Cells["adresse"].Value.ToString();
            txtContact.Text = row.Cells["contact"].Value.ToString();
            NudAge.Text = row.Cells["age"].Value.ToString();
            cmbGenre.Text = row.Cells["genre"].Value.ToString();

            txtId.Visible = true;
            lblId.Visible = true;
        }

        private void txtRecherche_TextChanged(object sender, EventArgs e)
        {
            
            dgvClient.DataSource = ClsDict.Instance.Rechercher(txtRecherche.Text.Trim(), "tClients", "noms");
        }
    }
}
