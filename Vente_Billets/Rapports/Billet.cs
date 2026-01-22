using System;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using Vente_Billets.Classes;

namespace Vente_Billets.Rapports
{
    public class Billet
    {
        private DataTable data;
        private PrintDocument printDoc;
        private int currentRow = 0;
        private Font titleFont;
        private Font normalFont;
        private Font boldFont;
        private float yPos = 0;
        private float leftMargin = 50;
        private float topMargin = 50;
            private float lineHeight = 40;

        public Billet(int id)
        {
            data = ClsDict.Instance.Imprimez_Billet(id);
            InitializePrintDocument();
        }

        private void InitializePrintDocument()
        {
            printDoc = new PrintDocument();
            printDoc.PrintPage += PrintDoc_PrintPage;
            titleFont = new Font("Arial", 24, FontStyle.Bold);
            normalFont = new Font("Arial", 18);
            boldFont = new Font("Arial", 18, FontStyle.Bold);
        }

        public void Print()
        {
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDoc;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                currentRow = 0;
                yPos = 0;
                printDoc.Print();
            }
        }

        public void PrintPreview()
        {
            PrintPreviewDialog previewDialog = new PrintPreviewDialog();
            previewDialog.Document = printDoc;
            previewDialog.WindowState = FormWindowState.Maximized;
            currentRow = 0;
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
                g.DrawString("BILLET", titleFont, Brushes.Black, leftMargin, yPos);
                yPos += lineHeight * 2;

                // Afficher les informations du billet dans un ordre spécifique
                // Ignorer le champ "statut" et les colonnes qui commencent par "ref"
                
                // ID
                if (row["id"] != DBNull.Value)
                {
                    g.DrawString("id:", boldFont, Brushes.Black, leftMargin, yPos);
                    g.DrawString(row["id"].ToString(), normalFont, Brushes.Black, leftMargin + 200, yPos);
                    yPos += lineHeight;
                }
                
                // Prix
                if (row["prix"] != DBNull.Value)
                {
                    g.DrawString("prix:", boldFont, Brushes.Black, leftMargin, yPos);
                    g.DrawString(row["prix"].ToString(), normalFont, Brushes.Black, leftMargin + 200, yPos);
                    yPos += lineHeight;
                }
                
                // Date d'achat (date actuelle de l'achat)
                if (row["dateAchat"] != DBNull.Value)
                {
                    DateTime dateAchat = Convert.ToDateTime(row["dateAchat"]);
                    g.DrawString("dateAchat:", boldFont, Brushes.Black, leftMargin, yPos);
                    g.DrawString(dateAchat.ToString("dd/MM/yyyy HH:mm"), normalFont, Brushes.Black, leftMargin + 200, yPos);
                    yPos += lineHeight;
                }
                
                // Spectacle
                if (row["Spectacle"] != DBNull.Value)
                {
                    g.DrawString("Spectacle:", boldFont, Brushes.Black, leftMargin, yPos);
                    g.DrawString(row["Spectacle"].ToString(), normalFont, Brushes.Black, leftMargin + 200, yPos);
                    yPos += lineHeight;
                }
                
                // Date du Spectacle (date réelle du spectacle)
                if (row["Date du Spectacle"] != DBNull.Value)
                {
                    DateTime dateSpectacle = Convert.ToDateTime(row["Date du Spectacle"]);
                    g.DrawString("Date du Spectacle:", boldFont, Brushes.Black, leftMargin, yPos);
                    g.DrawString(dateSpectacle.ToString("dd/MM/yyyy HH:mm"), normalFont, Brushes.Black, leftMargin + 200, yPos);
                    yPos += lineHeight;
                }
                
                // Client
                if (row["Client"] != DBNull.Value)
                {
                    g.DrawString("Client:", boldFont, Brushes.Black, leftMargin, yPos);
                    g.DrawString(row["Client"].ToString(), normalFont, Brushes.Black, leftMargin + 200, yPos);
                    yPos += lineHeight;
                }
                
                // Agent
                if (row["Agent"] != DBNull.Value)
                {
                    g.DrawString("Agent:", boldFont, Brushes.Black, leftMargin, yPos);
                    g.DrawString(row["Agent"].ToString(), normalFont, Brushes.Black, leftMargin + 200, yPos);
                    yPos += lineHeight;
                }
                
                // Numero Place
                if (row["Numero Place"] != DBNull.Value)
                {
                    g.DrawString("Numero Place:", boldFont, Brushes.Black, leftMargin, yPos);
                    g.DrawString(row["Numero Place"].ToString(), normalFont, Brushes.Black, leftMargin + 200, yPos);
                    yPos += lineHeight;
                }
                
                // Salle
                if (row["Salle"] != DBNull.Value)
                {
                    g.DrawString("Salle:", boldFont, Brushes.Black, leftMargin, yPos);
                    g.DrawString(row["Salle"].ToString(), normalFont, Brushes.Black, leftMargin + 200, yPos);
                    yPos += lineHeight;
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
