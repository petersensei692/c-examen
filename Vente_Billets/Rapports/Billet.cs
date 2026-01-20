using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using Vente_Billets.Classes;

namespace Vente_Billets.Rapports
{
    public partial class Billet : DevExpress.XtraReports.UI.XtraReport
    {
        public Billet(int id)
        {
            InitializeComponent();

            this.DataSource = ClsDict.Instance.Imprimez_Billet(id);
        }

    }
}
