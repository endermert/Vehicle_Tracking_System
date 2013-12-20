namespace MySisRapor
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;
    using Telerik.Reporting;
    using Telerik.Reporting.Drawing;
using System.Collections.Generic;

    /// <summary>
    /// Summary description for RprMaxHiz.
    /// </summary>
    public partial class RprMaxHiz : Telerik.Reporting.Report
    {
        public RprMaxHiz()
        {
            //
            // Required for telerik Reporting designer support
            //
            InitializeComponent();
            this.ReportParameters[1].Value = DateTime.Now.Date;
            this.ReportParameters[2].Value = DateTime.Now.Date;

        }
    }
}