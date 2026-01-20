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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            if (ClsDict.Instance.OpenConnection())
            {
                string login = txtUsername.Text.Trim();
                string pwd = txtPassword.Text.Trim();

                ClsAgents agent = ClsDict.Instance.SeConnecter(login, pwd);

                if (agent != null)
                {
                    string role = ClsDict.Instance.GetRole(login, pwd);
                    FrmDashboard frm = new FrmDashboard();
                    frm.UserRole = role;
                    
                    if (role == "Gerant")
                    {
                        // Tous les boutons sont activés par défaut
                        frm.Show();
                        this.Hide();
                    }
                    else if (role == "Vendeur")
                    {
                        // Désactiver les boutons non autorisés
                        frm.guna2Button1.Enabled = false; // Agents
                        frm.guna2Button3.Enabled = false; // Salles
                        frm.guna2Button4.Enabled = false; // Spectacles
                        frm.guna2Button5.Enabled = false; // Places
                        frm.guna2Button6.Enabled = false; // Paiement
                        frm.Show();
                        this.Hide();
                    }
                    else if (role == "Compable")
                    {
                        // Désactiver les boutons non autorisés
                        frm.guna2Button1.Enabled = false; // Agents
                        frm.guna2Button2.Enabled = false; // Clients
                        frm.guna2Button3.Enabled = false; // Salles
                        frm.guna2Button4.Enabled = false; // Spectacles
                        frm.guna2Button5.Enabled = false; // Places
                        frm.guna2Button7.Enabled = false; // Facture
                        frm.guna2Button8.Enabled = false; // Billets
                        frm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Nom d'utilisateur ou mot de passe incorrect", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Nom d'utilisateur ou mot de passe incorrect", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
