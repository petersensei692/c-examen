using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vente_Billets.Classes
{
    class ClsAgents
    {
        int id;
        string noms;
        string contact;
        string fonction;
        string role;
        string username;
        string password;
        string refSalle;

        public int Id { get => id; set => id = value; }
        public string Noms { get => noms; set => noms = value; }
        public string Contact { get => contact; set => contact = value; }
        public string Fonction { get => fonction; set => fonction = value; }
        public string Role { get => role; set => role = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string RefSalle { get => refSalle; set => refSalle = value; }

        public static void ChargementAgent(DataGridView dgv, Guna2TextBox txtId, Label lblId, ComboBox cmb)
        {
            dgv.ColumnHeadersVisible = true;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgv.GridColor = Color.Gray;
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(100, 88, 255); // ou une autre couleur
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            // Utiliser la vue Affichez_Agent pour être cohérent avec le code de CellClick
            dgv.DataSource = ClsDict.Instance.loadData("Affichez_Agent");
            txtId.Visible = true;
            lblId.Visible = true;
            ClsDict.Instance.loadCombo("tSalle", "nomSalle", cmb);
        }

    }
}
