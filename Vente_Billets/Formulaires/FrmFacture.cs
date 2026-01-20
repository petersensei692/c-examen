using DevExpress.XtraReports.UI;
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
            fact.RefPlace = int.Parse(ClsDict.Instance.getcode_Combo("tCategorie", "id", "designation", cmbPlace.Text));

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
            Facture facture = new Facture(int.Parse(txtIdfacture.Text));
            ReportPrintTool tool = new ReportPrintTool(facture);
            tool.ShowPreviewDialog();

        }

        private void dgvFacture_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
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
            DataGridViewRow row = dgvFacture.Rows[e.RowIndex];

            txtIdfacture.Text = row.Cells["id"].Value.ToString();
            cmbPlace.Text = row.Cells["refPlace"].Value.ToString();
            cmbAgent.Text = row.Cells["refAgent"].Value.ToString();
            cmbClient.Text = row.Cells["refClient"].Value.ToString();


            txtIdfacture.Visible = true;
            id.Visible = true;
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
            Facture facture = new Facture(int.Parse(txtIdfacture.Text));
            ReportPrintTool tool = new ReportPrintTool(facture);
            tool.ShowPreviewDialog();
        }
    }
}
