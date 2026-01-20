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
        public string UserRole { get; set; } = "";
        public static int LoggedInAgentId { get; set; } = 0; // ID de l'agent connecté

        public FrmDashboard()
        {
            InitializeComponent();
        }

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
            form.Show();
        }



        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            panelAffichage.Visible = true;

            // Charger automatiquement le premier formulaire autorisé selon le rôle
            ChargerPremierFormulaireAutorise();
        }

        private void ChargerPremierFormulaireAutorise()
        {
            // Déterminer le premier formulaire autorisé selon le rôle
            if (UserRole == "Gerant")
            {
                // Gerant : tous les boutons sont activés, commencer par Agents
                ChargerFormulaire(new FrmAgent());
            }
            else if (UserRole == "Vendeur")
            {
                // Vendeur : Clients, Paiement, Billet - commencer par Clients
                ChargerFormulaire(new FrmClient());
            }
            else
            {
                // Par défaut, charger Clients
                ChargerFormulaire(new FrmClient());
            }
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
            ChargerFormulaire(new FrmVente());
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            panelAffichage.Visible = true;
            ChargerFormulaire(new FrmPaiement());
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            // Ce bouton est maintenant masqué, rediriger vers Vente
            panelAffichage.Visible = true;
            ChargerFormulaire(new FrmVente());
        }

        private void panelHaut_Paint(object sender, PaintEventArgs e)
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
