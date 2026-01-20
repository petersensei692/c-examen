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
    class ClsPlace
    {
        int id;
        int refCategorie;
        string numPlace;
        int refSalle;

        public int Id { get => id; set => id = value; }
        
        public string NumPlace { get => numPlace; set => numPlace = value; }
        public int RefSalle { get => refSalle; set => refSalle = value; }
        public int RefCategorie { get => refCategorie; set => refCategorie = value; }

        public static void ChargementPlace(DataGridView dgv, Guna2TextBox txtId, Label lblId, ComboBox cmb)
        {
            dgv.ColumnHeadersVisible = true;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgv.GridColor = Color.Gray;
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(100, 88, 255); // ou une autre couleur
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgv.DataSource = ClsDict.Instance.loadData("tPlace");
            txtId.Visible = true;
            lblId.Visible = true;
            ClsDict.Instance.loadCombo("tSalle", "nomSalle", cmb);
        }
    }
}
