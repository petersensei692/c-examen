using System;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using Vente_Billets.Classes;

namespace Vente_Billets.Rapports
{
    public class Recu
    {
        private DataTable data;
        private PrintDocument printDoc;
        private Font titleFont;
        private Font normalFont;
        private Font boldFont;
        private float yPos = 0;
        private float leftMargin = 50;
        private float topMargin = 50;
        private float lineHeight = 30;

        public Recu(string nom)
        {
            data = ClsDict.Instance.Imprimez_Recu(nom);
            InitializePrintDocument();
        }

        private void InitializePrintDocument()
        {
            printDoc = new PrintDocument();
            printDoc.PrintPage += PrintDoc_PrintPage;
            titleFont = new Font("Arial", 20, FontStyle.Bold);
            normalFont = new Font("Arial", 14);
            boldFont = new Font("Arial", 14, FontStyle.Bold);
        }

        public void Print()
        {
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDoc;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                yPos = 0;
                printDoc.Print();
            }
        }

        public void PrintPreview()
        {
            PrintPreviewDialog previewDialog = new PrintPreviewDialog();
            previewDialog.Document = printDoc;
            previewDialog.WindowState = FormWindowState.Maximized;
            yPos = 0;
            previewDialog.ShowDialog();
        }

        private void PrintDoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            yPos = topMargin;

            if (data != null && data.Rows.Count > 0)
            {
                DataRow row = data.Rows[0];

                // Titre
                g.DrawString("RECU DE PAIEMENT", titleFont, Brushes.Black, leftMargin, yPos);
                yPos += lineHeight * 2;

                // Informations du reçu
                foreach (DataColumn column in data.Columns)
                {
                    if (row[column.ColumnName] != DBNull.Value)
                    {
                        string label = column.ColumnName.Replace("_", " ");
                        string value = row[column.ColumnName].ToString();
                        
                        g.DrawString(label + ":", boldFont, Brushes.Black, leftMargin, yPos);
                        g.DrawString(value, normalFont, Brushes.Black, leftMargin + 200, yPos);
                        yPos += lineHeight;
                    }
                }

                // Ligne de séparation
                yPos += lineHeight;
                g.DrawLine(new Pen(Color.Black, 2), leftMargin, yPos, e.MarginBounds.Right - leftMargin, yPos);
            }
            else
            {
                g.DrawString("Aucune donnée disponible", normalFont, Brushes.Black, leftMargin, yPos);
            }

            e.HasMorePages = false;
        }
    }
}
