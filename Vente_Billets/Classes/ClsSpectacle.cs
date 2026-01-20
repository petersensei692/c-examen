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
    class ClsSpectacle
    {
        int id;
        string titre;
        DateTime dateSpectacle;
        int nombreBillet;
        string duree;
        string descSpect;
        int refSalle;

        public int Id { get => id; set => id = value; }
        public DateTime DateSpectacle { get => dateSpectacle; set => dateSpectacle = value; }
        public int NombreBillet { get => nombreBillet; set => nombreBillet = value; }
        public string Duree { get => duree; set => duree = value; }
        public string DescSpect { get => descSpect; set => descSpect = value; }
        public int RefSalle { get => refSalle; set => refSalle = value; }
        public string Titre { get => titre; set => titre = value; }

        public static void ChargementSpectacle(DataGridView dgv, Guna2TextBox txtId, Label lblId, ComboBox cmb)
        {
            dgv.ColumnHeadersVisible = true;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgv.GridColor = Color.Gray;
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(100, 88, 255); // ou une autre couleur
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgv.DataSource = ClsDict.Instance.loadData("Affichez_Spectacle");
            txtId.Visible = false;
            lblId.Visible = false;
            ClsDict.Instance.loadCombo("tSalle", "nomSalle", cmb);
        }
    }
}
