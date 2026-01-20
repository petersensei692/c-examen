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
                ClsDict.Instance.loadCombo("tAgents","noms",cmbAgent);
                ClsDict.Instance.loadCombo("tClients", "noms", cmbClient);
            }
        }

        ClsPaiement paie = new ClsPaiement();

        private void InsertUpdatePaiement(int a)
        {
            paie.ModePaiement = cmbModePaie.Text;
            paie.Montant = double.Parse(txtMontant.Text);
            paie.DatePaiement = DateTime.Parse(DatePaie.Text);
            paie.RefAgent = int.Parse(ClsDict.Instance.getcode_Combo("tAgents", "id", "noms", cmbAgent.Text));
            paie.RefClient = int.Parse(ClsDict.Instance.getcode_Combo("tClients", "id", "noms", cmbClient.Text));

            if (a == 1)
            {
                paie.Id = 0;
                ClsDict.Instance.SaveUpdatePaiement(paie);
                ClsPaiement.ChargementPaiement(dgvPaiement, txtIdPaiement, id, cmbModePaie);
            }
            else if (a == 2)
            {
                paie.Id = int.Parse(txtIdPaiement.Text);
                ClsDict.Instance.SaveUpdatePaiement(paie);
                ClsPaiement.ChargementPaiement(dgvPaiement, txtIdPaiement, id, cmbModePaie);
            }
            else if (a == 3)
            {
                ClsDict.Instance.Deletedata("tPaiement", "id", int.Parse(txtIdPaiement.Text));
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
                        cmbAgent.Text = row.Cells["Agent"].Value.ToString();
                    
                    if (row.Cells["Client"] != null && row.Cells["Client"].Value != null)
                        cmbClient.Text = row.Cells["Client"].Value.ToString();

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
            Recu recu = new Recu(cmbClient.Text);
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
            Recu recu = new Recu(cmbClient.Text);
            recu.PrintPreview();
        }
    }
}
