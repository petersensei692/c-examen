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
    class ClsFacture
    {
        int id;
        int refClient;
        int refAgent;
        int refPlace;

        public int Id { get => id; set => id = value; }
        public int RefClient { get => refClient; set => refClient = value; }
        public int RefAgent { get => refAgent; set => refAgent = value; }
        public int RefPlace { get => refPlace; set => refPlace = value; }

        public static void ChargementFacture(DataGridView dgv, Guna2TextBox txtId, Label lblId)
        {
            dgv.ColumnHeadersVisible = true;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgv.GridColor = Color.Gray;
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(100, 88, 255); // ou une autre couleur
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgv.DataSource = ClsDict.Instance.loadData("Facture");
            txtId.Visible = false;
            lblId.Visible = false;

        }
    }
}

