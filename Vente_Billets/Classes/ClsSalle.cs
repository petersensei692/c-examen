using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vente_Billets.Classes
{
    class ClsSalle
    {
        int id;
        string nomSalle;
        string adesse;
        string nombrePlace;

        public int Id { get => id; set => id = value; }
        public string NomSalle { get => nomSalle; set => nomSalle = value; }
        public string Adesse { get => adesse; set => adesse = value; }
        public string NombrePlace { get => nombrePlace; set => nombrePlace = value; }

        public static void ChargementSalle(DataGridView dgv, Guna2TextBox txtId, Label lblId)
        {
            dgv.ColumnHeadersVisible = true;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgv.GridColor = Color.Gray;
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(100, 88, 255); // ou une autre couleur
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgv.DataSource = ClsDict.Instance.loadData("tSalle");
            txtId.Visible = false;
            lblId.Visible = false;
            
        }
    }
}
