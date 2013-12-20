namespace MySisRapor
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;
    using Telerik.Reporting;
    using Telerik.Reporting.Drawing;

    /// <summary>
    /// Summary description for RprDurmaSuresi.
    /// </summary>
    public partial class RprDurmaSuresi : Telerik.Reporting.Report
    {
        public RprDurmaSuresi()
        {
            //
            // Required for telerik Reporting designer support
            //
            InitializeComponent();
            this.ReportParameters[1].Value = DateTime.Now.Date;
            this.ReportParameters[2].Value = DateTime.Now.Date;
            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }
    }
}