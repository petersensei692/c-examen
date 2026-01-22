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
    public partial class FrmAgent : Form
    {
        public FrmAgent()
        {
            InitializeComponent();

           
        }

        
        private void dgvAgents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

      
        

       

        public DataGridView GetGrid() => dgvAgents;

        private void FrmAgent_Load(object sender, EventArgs e)
        {
            if (ClsDict.Instance.OpenConnection())
            {
                ClsAgents.ChargementAgent(dgvAgents, txtIdAgents, id, cmbSalleAgent);
            }
        }

        ClsAgents ag = new ClsAgents();

        private void CleanTextAgent()
        {
            txtContactAgent.Text = "";
            cmbRoleAgent.Text = "";
            cmbSalleAgent.Text = "";
            txtNomAgent.Text = "";
            txtUserNameAgent.Text = "";
            txtPasswordAgents.Text = "";
            txtIdAgents.Visible = false;
            id.Visible = false;
        }


        private void InsertUpdateAgent(int a)
        {
            ag.Noms = txtNomAgent.Text;
            ag.Contact = txtContactAgent.Text;
            ag.Role = cmbRoleAgent.Text; // Utiliser le ComboBox pour le role
            ag.Username = txtUserNameAgent.Text;
            ag.Password = txtPasswordAgents.Text;
            ag.RefSalle = ClsDict.Instance.getcode_Combo("tSalle", "id", "nomSalle", cmbSalleAgent.Text);

            if (a == 1)
            {
                ag.Id = 0;
                ClsDict.Instance.SaveUpdateAgents(ag);
                ClsAgents.ChargementAgent(dgvAgents, txtIdAgents, id, cmbSalleAgent);
            }
            else if (a == 2)
            {
                ag.Id = int.Parse(txtIdAgents.Text);
                ClsDict.Instance.SaveUpdateAgents(ag);
                ClsAgents.ChargementAgent(dgvAgents, txtIdAgents, id, cmbSalleAgent);
            }
            else if (a == 3)
            {
                ClsDict.Instance.Deletedata("tAgents", "id", int.Parse(txtIdAgents.Text));
                ClsAgents.ChargementAgent(dgvAgents, txtIdAgents, id, cmbSalleAgent);
            }
        }

        private void BtnAjouterAgent_Click(object sender, EventArgs e)
        {
            InsertUpdateAgent(1);
            CleanTextAgent();
        }

        private void btnUpdateAgent_Click(object sender, EventArgs e)
        {
            InsertUpdateAgent(2);
            CleanTextAgent();
        }

        private void BtnDeleteAgent_Click(object sender, EventArgs e)
        {
            InsertUpdateAgent(3);
            CleanTextAgent();
        }

        private void dgvAgents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dgvAgents_CellClick_1(sender, e);
            }
        }

        private void dgvAgents_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvAgents_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvAgents.Rows.Count)
            {
                try
                {
                    DataGridViewRow row = dgvAgents.Rows[e.RowIndex];

                    // Vérifier que les colonnes existent avant d'y accéder
                    if (row.Cells["numero"] != null && row.Cells["numero"].Value != null)
                        txtIdAgents.Text = row.Cells["numero"].Value.ToString();
                    
                    if (row.Cells["Noms"] != null && row.Cells["Noms"].Value != null)
                        txtNomAgent.Text = row.Cells["Noms"].Value.ToString();
                    
                    if (row.Cells["Telephone"] != null && row.Cells["Telephone"].Value != null)
                        txtContactAgent.Text = row.Cells["Telephone"].Value.ToString();
                    
                    if (row.Cells["Role"] != null && row.Cells["Role"].Value != null)
                        cmbRoleAgent.Text = row.Cells["Role"].Value.ToString();
                    
                    if (row.Cells["Username"] != null && row.Cells["Username"].Value != null)
                        txtUserNameAgent.Text = row.Cells["Username"].Value.ToString();
                    
                    if (row.Cells["Mot de Passe"] != null && row.Cells["Mot de Passe"].Value != null)
                        txtPasswordAgents.Text = row.Cells["Mot de Passe"].Value.ToString();
                    
                    if (row.Cells["Salle"] != null && row.Cells["Salle"].Value != null)
                        cmbSalleAgent.Text = row.Cells["Salle"].Value.ToString();

                    txtIdAgents.Visible = true;
                    id.Visible = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors du chargement des données : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtRecherche_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtRecherche_TextChanged(object sender, EventArgs e)
        {
            dgvAgents.DataSource = ClsDict.Instance.Rechercher(txtRecherche.Text.Trim(), "Affichez_Agent", "Noms");
        }

    }
}
