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
    class ClsClients
    {
        int id;
        string noms;
        string adresse;
        string contact;
        string genre;
        int age;

        public int Id { get => id; set => id = value; }
        public string Noms { get => noms; set => noms = value; }
        public string Adresse { get => adresse; set => adresse = value; }
        public string Contact { get => contact; set => contact = value; }
        public string Genre { get => genre; set => genre = value; }
        public int Age { get => age; set => age = value; }

        public static void ChargementClient(DataGridView dgv, Guna2TextBox txtId, Label lblId, ComboBox cmb)
        {
            dgv.ColumnHeadersVisible = true;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgv.GridColor = Color.Gray;
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(100, 88, 255); // ou une autre couleur
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgv.DataSource = ClsDict.Instance.loadData("tClients");
            txtId.Visible = true;
            lblId.Visible = true;
            string[] genre = { "Feminin", "Masculin" };
            cmb.Items.AddRange(genre);
        }

        
    }
}
