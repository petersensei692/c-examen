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
    class ClsPaiement
    {
        int id;
        DateTime datePaiement;
        string modePaiement;
        double montant;
        int refClient;
        int refAgent;

        public int Id { get => id; set => id = value; }
        public DateTime DatePaiement { get => datePaiement; set => datePaiement = value; }
        public string ModePaiement { get => modePaiement; set => modePaiement = value; }
        public double Montant { get => montant; set => montant = value; }
        public int RefClient { get => refClient; set => refClient = value; }
        public int RefAgent { get => refAgent; set => refAgent = value; }

        public static void ChargementPaiement(DataGridView dgv, Guna2TextBox txtId, Label lblId,ComboBox cmb)
        {
            dgv.ColumnHeadersVisible = true;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgv.GridColor = Color.Gray;
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(100, 88, 255); // ou une autre couleur
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgv.DataSource = ClsDict.Instance.loadData("Affichez_Paiement");
            string[] modePaiement = { "Cash", "Check", "Mobile Money" };
            cmb.Items.AddRange(modePaiement);
            txtId.Visible = false;
            lblId.Visible = false;
        }
    }
}
