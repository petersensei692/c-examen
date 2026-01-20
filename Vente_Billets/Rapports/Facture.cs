using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using Vente_Billets.Classes;
using Vente_Billets.Formulaires;

namespace Vente_Billets
{
    public partial class Facture : DevExpress.XtraReports.UI.XtraReport
    {

        
        public Facture(int id)
        {
            InitializeComponent();

            
            this.DataSource = ClsDict.Instance.Affichez_Facture(id);
        }

        

    }
}
