using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vente_Billets.Formulaires
{
    public partial class FrmDashboard : Form
    {
        public FrmDashboard()
        {
            InitializeComponent();
        }

        private string texteComplet = "Bienvenue dans notre application de gestion de la vente des billets d'entree.";
        private int indexLettre = 0;

        //private void ChargerFormulaire(Form form)
        //{
        //    panelAffichage.Controls.Clear();
        //    form.TopLevel = false;
        //    form.FormBorderStyle = FormBorderStyle.None;
        //    form.Dock = DockStyle.Fill;
        //    panelAffichage.Controls.Add(form);

        //    form.Show();

        //}

        private Form formulaireActif;


        private void ChargerFormulaire(Form form)
        {
            panelAffichage.Controls.Clear();

            formulaireActif = form; // <<<<< On mémorise le form actif

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            panelAffichage.Controls.Add(form);
            form.StartPosition = FormStartPosition.Manual;
            form.Location = new Point(
                (panelAffichage.Width - form.Width) / 2,
                (panelAffichage.Height - form.Height) / 2
            );

            form.Show();
        }


        private void timerBienvenue_Tick(object sender, EventArgs e)
        {
            if(indexLettre < texteComplet.Length)
            {
                lblBienvenue.Text += texteComplet[indexLettre];
                indexLettre++;
            }
            else
            {
                timerBienvenue.Stop();
            }
        }

        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            lblBienvenue.Text = "";
            indexLettre = 0;

            lblBienvenue.Font = new Font("Segoe UI", 26, FontStyle.Italic);
            lblBienvenue.ForeColor = Color.FromArgb(91, 148, 255);
            lblBienvenue.TextAlignment = ContentAlignment.MiddleCenter;
            //lblBienvenue.Left = (this.ClientSize.Width = lblBienvenue.Width) / 2;
            lblBienvenue.Top = (this.ClientSize.Height - lblBienvenue.Height) / 2;
            timerBienvenue.Interval = 100;
            timerBienvenue.Start();

            panelAffichage.Visible = false;

            this.WindowState = FormWindowState.Maximized;
        }

        private void FrmDashboard_Shown(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            panelAffichage.Visible = true;
            ChargerFormulaire(new FrmSpectacle());
        }

        

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            panelAffichage.Visible = true;
            ChargerFormulaire(new FrmSalle());
        }
        

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            panelAffichage.Visible = true;
            ChargerFormulaire(new FrmAgent());
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            panelAffichage.Visible = true;
            ChargerFormulaire(new FrmClient());
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            panelAffichage.Visible = true;
            ChargerFormulaire(new FrmPlace());
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            panelAffichage.Visible = true;
            ChargerFormulaire(new FrmBillet());
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            panelAffichage.Visible = true;
            ChargerFormulaire(new FrmPaiement());
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            panelAffichage.Visible = true;
            ChargerFormulaire(new FrmFacture());
        }

        private void panelHaut_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {

        }

        private void panelAffichage_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtRecherche_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void guna2ControlBox2_Click(object sender, EventArgs e)
        {
           
        }

        private void panelGauche_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
