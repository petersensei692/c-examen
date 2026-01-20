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
                    if (ClsDict.Instance.GetRole(login, pwd) == "Gerant")
                    {
                        FrmDashboard frm = new FrmDashboard();
                        frm.Show();
                        
                    }

                    else if (ClsDict.Instance.GetRole(login, pwd) == "Vendeur")
                    {
                        FrmDashboard frm = new FrmDashboard();
                        frm.Show();
                        frm.guna2Button1.Enabled = false;
                        frm.guna2Button3.Enabled = false;
                        frm.guna2Button4.Enabled = false;
                        frm.guna2Button5.Enabled = false;
                        frm.guna2Button6.Enabled = false;
                        frm.guna2Button9.Enabled = false;
                        
                    }
                    else if (ClsDict.Instance.GetRole(login, pwd) == "Compable")
                    {
                        FrmDashboard frm = new FrmDashboard();
                        frm.Show();
                        frm.guna2Button1.Enabled = false;
                        frm.guna2Button2.Enabled = false;
                        frm.guna2Button3.Enabled = false;
                        frm.guna2Button4.Enabled = false;
                        frm.guna2Button5.Enabled = false;
                        frm.guna2Button8.Enabled = false;
                        frm.guna2Button9.Enabled = false;
                        frm.guna2Button7.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Nom d'utilisateur ou mot de passe incorrect", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Les champs sont vides", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
