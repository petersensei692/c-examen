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
using Vente_Billets.Rapports;

namespace Vente_Billets.Formulaires
{
    public partial class FrmBillet : Form
    {
        public FrmBillet()
        {
            InitializeComponent();
        }

        private void FrmBillet_Load(object sender, EventArgs e)
        {
            if (ClsDict.Instance.OpenConnection())
            {
                ClsBillets.ChargementBillets(dgvBillet, txtIdBillet, id);
                ClsDict.Instance.loadCombo("tSpectacle", "titre", cmbSpectacle);
                ClsDict.Instance.loadCombo("tPlace", "numero", cmbPlace);
                ClsDict.Instance.loadCombo("tClients", "noms", cmbClient);
                ClsDict.Instance.loadCombo("tAgents", "noms", cmbAgent);
                ClsDict.Instance.loadCombo("Facture", "id", cmbFacture);
                ClsDict.Instance.loadCombo("CategoriePlace", "designation", cmbCatPlace);
            }
        }

        ClsBillets bi = new ClsBillets();

        private void InsertUpdateBillet (int a)
        {
            bi.Prix = double.Parse(txtPrix.Text);
            bi.DateAchat = DateTime.Parse(DateAchat.Text);
            bi.RefAgent1 = int.Parse(ClsDict.Instance.getcode_Combo("tAgents", "id", "noms", cmbAgent.Text));
            bi.RefClient1 = int.Parse(ClsDict.Instance.getcode_Combo("tClients", "id", "noms", cmbClient.Text));
            bi.RefPlace1 = int.Parse(ClsDict.Instance.getcode_Combo("tPlace", "id", "numero", cmbPlace.Text));
            bi.RefSpectacle1 = int.Parse(ClsDict.Instance.getcode_Combo("tSpectacle", "id", "titre", cmbSpectacle.Text));
            bi.RefFacture = int.Parse(ClsDict.Instance.getcode_Combo("Facture", "id", "id", cmbFacture.Text));
            bi.RefCat1 = int.Parse(ClsDict.Instance.getcode_Combo("CategoriePlace", "id", "designation", cmbCatPlace.Text));

            if (a == 1)
            {
                bi.Id = 0;
                ClsDict.Instance.SaveUpdateBillet(bi);
                ClsBillets.ChargementBillets(dgvBillet, txtIdBillet, id);
            }

            else if (a == 2)
            {
                bi.Id = int.Parse(txtIdBillet.Text);
                ClsDict.Instance.SaveUpdateBillet(bi);
                ClsBillets.ChargementBillets(dgvBillet, txtIdBillet, id);
            }

            else if (a == 3)
            {
                ClsDict.Instance.Deletedata("tBillet", "id", int.Parse(txtIdBillet.Text));
                ClsBillets.ChargementBillets(dgvBillet, txtIdBillet, id);
            }
        }

        private void BtnAjouterAgent_Click(object sender, EventArgs e)
        {
            InsertUpdateBillet(1);
            CleanTextBillet();
        }

        private void btnUpdateAgent_Click(object sender, EventArgs e)
        {
            InsertUpdateBillet(2);
            CleanTextBillet();
        }

        private void BtnDeleteAgent_Click(object sender, EventArgs e)
        {
            InsertUpdateBillet(3);
            CleanTextBillet();

        }

        private void dgvBillet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
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

        private void cmbFacture_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
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
            DataGridViewRow row = dgvBillet.Rows[e.RowIndex];

            txtIdBillet.Text = row.Cells["id"].Value.ToString(); // ID
            DateAchat.Text = row.Cells["dateAchat"].Value.ToString();
            txtPrix.Text = row.Cells["prix"].Value.ToString();
            cmbSpectacle.Text = row.Cells["Spectacle"].Value.ToString();
            cmbPlace.Text = row.Cells["Numero_Place"].Value.ToString();
            cmbAgent.Text = row.Cells["Agent"].Value.ToString();
            cmbClient.Text = row.Cells["Client"].Value.ToString();
            cmbFacture.Text = row.Cells["Numero Facture"].Value.ToString();
            cmbCatPlace.Text = row.Cells["Categorie_Place"].Value.ToString();

            txtIdBillet.Visible = true;
            id.Visible = true;
        }

        private void CleanTextBillet()
        {
            txtPrix.Text = "";
            txtRecherche.Text = "";
            txtIdBillet.Visible = false;
            id.Visible = false;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            

            
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            InsertUpdateBillet(1);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            InsertUpdateBillet(2);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            InsertUpdateBillet(3);
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            if (!ClsDict.Instance.GetStatut(int.Parse(txtIdBillet.Text)))
            {
                ClsDict.Instance.SetStatut(int.Parse(txtIdBillet.Text));
                ClsBillets.ChargementBillets(dgvBillet, txtIdBillet, id);
            }
            else
            {
                MessageBox.Show("Billet Vendu");
                return;
            }

            Billet billet = new Billet(int.Parse(txtIdBillet.Text));
            ReportPrintTool tool = new ReportPrintTool(billet);
            tool.ShowPreviewDialog();
        }
    }
}
