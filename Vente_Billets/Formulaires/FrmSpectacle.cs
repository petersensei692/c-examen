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
    public partial class FrmSpectacle : Form
    {
        public FrmSpectacle()
        {
            InitializeComponent();
        }

        private void FrmSpectacle_Load(object sender, EventArgs e)
        {
            if (ClsDict.Instance.OpenConnection())
            {
                ClsSpectacle.ChargementSpectacle(dgvSpectacle, txtIdSpectacle, lblId, cmbSpectacle);
            }
            
            // Définir la date minimum à demain
            DateSpectacle.MinDate = DateTime.Now.Date.AddDays(1);
        }

        ClsSpectacle spect = new ClsSpectacle();

        private void InsertUpdateSpectacle(int a)
        {
            // Validation de la date du spectacle (minimum demain)
            DateTime dateSpectacle = DateTime.Parse(DateSpectacle.Text);
            DateTime dateMinimum = DateTime.Now.Date.AddDays(1); // Demain à minuit
            
            if (dateSpectacle.Date < dateMinimum)
            {
                MessageBox.Show($"La date du spectacle ne peut pas être antérieure à demain ({dateMinimum:dd/MM/yyyy}).", "Erreur de validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            spect.Titre = txtTitre.Text;
            spect.DateSpectacle = dateSpectacle;
            spect.NombreBillet = int.Parse(txtNbrBillet.Text);
            spect.Duree = txtDuree.Text;
            spect.DescSpect = txtDescSpect.Text;
            spect.RefSalle = int.Parse(ClsDict.Instance.getcode_Combo("tSalle", "id", "nomSalle", cmbSpectacle.Text));
            if (a == 1)
            {
                spect.Id = 0;
                ClsDict.Instance.SaveUpdateSpectacle(spect);
                ClsSpectacle.ChargementSpectacle(dgvSpectacle, txtIdSpectacle, lblId, cmbSpectacle);
            }
            else if (a == 2)
            {
                spect.Id = int.Parse(txtIdSpectacle.Text);
                ClsDict.Instance.SaveUpdateSpectacle(spect);
                ClsSpectacle.ChargementSpectacle(dgvSpectacle, txtIdSpectacle, lblId, cmbSpectacle);
            }
            else if (a == 3)
            {
                ClsDict.Instance.Deletedata("tSpectacle", "id", int.Parse(txtIdSpectacle.Text));
                ClsSpectacle.ChargementSpectacle(dgvSpectacle, txtIdSpectacle, lblId, cmbSpectacle);
            }
        }

        private void BtnAjouterAgent_Click(object sender, EventArgs e)
        {
            InsertUpdateSpectacle(1);
        }

        private void btnUpdateAgent_Click(object sender, EventArgs e)
        {
            InsertUpdateSpectacle(2);
        }

        private void BtnDeleteAgent_Click(object sender, EventArgs e)
        {
            InsertUpdateSpectacle(3);
        }

        private void dgvSpectacle_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dgvSpectacle_CellClick_1(sender, e);
            }
        }

        private void dgvAgents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtRecherche_TextChanged(object sender, EventArgs e)
        {
            dgvSpectacle.DataSource = ClsDict.Instance.Rechercher(txtRecherche.Text.Trim(), "Affichez_Spectacle", "titre");
        }

        private void dgvSpectacle_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvSpectacle.Rows.Count)
            {
                try
                {
                    DataGridViewRow row = dgvSpectacle.Rows[e.RowIndex];

                    // Récupérer l'ID depuis la colonne "id"
                    if (dgvSpectacle.Columns.Contains("id") && row.Cells["id"].Value != null && row.Cells["id"].Value != DBNull.Value)
                        txtIdSpectacle.Text = row.Cells["id"].Value.ToString();
                    
                    if (dgvSpectacle.Columns.Contains("dateSpectacle") && row.Cells["dateSpectacle"].Value != null && row.Cells["dateSpectacle"].Value != DBNull.Value)
                        DateSpectacle.Text = row.Cells["dateSpectacle"].Value.ToString();
                    else if (dgvSpectacle.Columns.Contains("Date du Spectacle") && row.Cells["Date du Spectacle"].Value != null && row.Cells["Date du Spectacle"].Value != DBNull.Value)
                        DateSpectacle.Text = row.Cells["Date du Spectacle"].Value.ToString();
                    
                    if (dgvSpectacle.Columns.Contains("nombreBillet") && row.Cells["nombreBillet"].Value != null && row.Cells["nombreBillet"].Value != DBNull.Value)
                        txtNbrBillet.Text = row.Cells["nombreBillet"].Value.ToString();
                    else if (dgvSpectacle.Columns.Contains("Nombre Total Billet") && row.Cells["Nombre Total Billet"].Value != null && row.Cells["Nombre Total Billet"].Value != DBNull.Value)
                        txtNbrBillet.Text = row.Cells["Nombre Total Billet"].Value.ToString();
                    
                    if (dgvSpectacle.Columns.Contains("duree") && row.Cells["duree"].Value != null && row.Cells["duree"].Value != DBNull.Value)
                        txtDuree.Text = row.Cells["duree"].Value.ToString();
                    else if (dgvSpectacle.Columns.Contains("Duree du Spectacle en h") && row.Cells["Duree du Spectacle en h"].Value != null && row.Cells["Duree du Spectacle en h"].Value != DBNull.Value)
                        txtDuree.Text = row.Cells["Duree du Spectacle en h"].Value.ToString();
                    
                    if (dgvSpectacle.Columns.Contains("descSpect") && row.Cells["descSpect"].Value != null && row.Cells["descSpect"].Value != DBNull.Value)
                        txtDescSpect.Text = row.Cells["descSpect"].Value.ToString();
                    else if (dgvSpectacle.Columns.Contains("Description") && row.Cells["Description"].Value != null && row.Cells["Description"].Value != DBNull.Value)
                        txtDescSpect.Text = row.Cells["Description"].Value.ToString();
                    
                    if (dgvSpectacle.Columns.Contains("refSalle") && row.Cells["refSalle"].Value != null && row.Cells["refSalle"].Value != DBNull.Value)
                    {
                        // Si c'est un ID, récupérer le nom de la salle
                        string salleId = row.Cells["refSalle"].Value.ToString();
                        cmbSpectacle.Text = ClsDict.Instance.GetNomDepuisId("tSalle", "id", "nomSalle", salleId);
                    }
                    else if (dgvSpectacle.Columns.Contains("Salle") && row.Cells["Salle"].Value != null && row.Cells["Salle"].Value != DBNull.Value)
                        cmbSpectacle.Text = row.Cells["Salle"].Value.ToString();
                    
                    if (dgvSpectacle.Columns.Contains("titre") && row.Cells["titre"].Value != null && row.Cells["titre"].Value != DBNull.Value)
                        txtTitre.Text = row.Cells["titre"].Value.ToString();

                    txtIdSpectacle.Visible = true;
                    lblId.Visible = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors du chargement des données : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void DateSpectacle_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void txtDuree_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbSpectacle_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void txtTitre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void txtDescSpect_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNbrBillet_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
