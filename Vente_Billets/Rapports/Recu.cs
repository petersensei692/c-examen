using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using Vente_Billets.Classes;

namespace Vente_Billets.Rapports
{
    public partial class Recu : DevExpress.XtraReports.UI.XtraReport
    {
        public Recu(string nom)
        {
            InitializeComponent();

            this.DataSource = ClsDict.Instance.Imprimez_Recu(nom);
        }

    }
}
