namespace MySisRapor
{
    partial class RprSonKonum
    {
        #region Component Designer generated code
        /// <summary>
        /// Required method for telerik Reporting designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Telerik.Reporting.ReportParameter reportParameter1 = new Telerik.Reporting.ReportParameter();
            Telerik.Reporting.ReportParameter reportParameter2 = new Telerik.Reporting.ReportParameter();
            Telerik.Reporting.ReportParameter reportParameter3 = new Telerik.Reporting.ReportParameter();
            this.pageHeaderSection1 = new Telerik.Reporting.PageHeaderSection();
            this.detail = new Telerik.Reporting.DetailSection();
            this.pageFooterSection1 = new Telerik.Reporting.PageFooterSection();
            this.dsSonKonum = new Telerik.Reporting.SqlDataSource();
            this.dsPlakaList = new Telerik.Reporting.SqlDataSource();
            this.dsTMesafe = new Telerik.Reporting.SqlDataSource();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // pageHeaderSection1
            // 
            this.pageHeaderSection1.Height = new Telerik.Reporting.Drawing.Unit(3D, Telerik.Reporting.Drawing.UnitType.Cm);
            this.pageHeaderSection1.Name = "pageHeaderSection1";
            // 
            // detail
            // 
            this.detail.Height = new Telerik.Reporting.Drawing.Unit(3D, Telerik.Reporting.Drawing.UnitType.Cm);
            this.detail.Name = "detail";
            // 
            // pageFooterSection1
            // 
            this.pageFooterSection1.Height = new Telerik.Reporting.Drawing.Unit(3D, Telerik.Reporting.Drawing.UnitType.Cm);
            this.pageFooterSection1.Name = "pageFooterSection1";
            // 
            // dsSonKonum
            // 
            this.dsSonKonum.ConnectionString = "MySisRapor.Properties.Settings.ElektrometreServer17817";
            this.dsSonKonum.Name = "dsSonKonum";
            this.dsSonKonum.Parameters.AddRange(new Telerik.Reporting.SqlDataSourceParameter[] {
            new Telerik.Reporting.SqlDataSourceParameter("@arcSer1No", System.Data.DbType.Int32, "=Parameters.arcSer1No.Value")});
            this.dsSonKonum.SelectCommand = "SELECT        TOP (1) DT_ADRES\r\nFROM            ATS_DATA\r\nWHERE        (ARC_SER1N" +
                "O = @arcSer1No) AND (DT_ADRES <> \'-\')\r\nORDER BY DT_TAR1H DESC";
            // 
            // dsPlakaList
            // 
            this.dsPlakaList.ConnectionString = "MySisRapor.Properties.Settings.ElektrometreServer17817";
            this.dsPlakaList.Name = "dsAracList";
            this.dsPlakaList.Parameters.AddRange(new Telerik.Reporting.SqlDataSourceParameter[] {
            new Telerik.Reporting.SqlDataSourceParameter("@kulAd", System.Data.DbType.String, "=Parameters.kulAd.Value")});
            this.dsPlakaList.SelectCommand = "SELECT ARC_SER1NO, ARC_PLAKA FROM bayifirma INNER JOIN ATS_ARACLAR ON bayifirma.s" +
                "erino = CONVERT(VARCHAR, ATS_ARACLAR.ARC_SER1NO) where  bayifirma.bayia=@kulAd o" +
                "rder by bayifirma.firma";
            // 
            // dsTMesafe
            // 
            this.dsTMesafe.ConnectionString = "MySisRapor.Properties.Settings.ElektrometreServer17817";
            this.dsTMesafe.Name = "dsTMesafe";
            this.dsTMesafe.Parameters.AddRange(new Telerik.Reporting.SqlDataSourceParameter[] {
            new Telerik.Reporting.SqlDataSourceParameter("@basTar", System.Data.DbType.DateTime, "=Parameters.basTar.Value.Date")});
            this.dsTMesafe.SelectCommand = "SELECT        SUM(DT_MESAFE) AS DT_TMESAFE\r\nFROM            ATS_DATA\r\nWHERE      " +
                "  (DT_TAR1H BETWEEN @basTar AND @basTar + 1)";
            // 
            // RprSonKonum
            // 
            this.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.pageHeaderSection1,
            this.detail,
            this.pageFooterSection1});
            this.PageSettings.Landscape = false;
            this.PageSettings.Margins.Bottom = new Telerik.Reporting.Drawing.Unit(25.399999618530273D, Telerik.Reporting.Drawing.UnitType.Mm);
            this.PageSettings.Margins.Left = new Telerik.Reporting.Drawing.Unit(25.399999618530273D, Telerik.Reporting.Drawing.UnitType.Mm);
            this.PageSettings.Margins.Right = new Telerik.Reporting.Drawing.Unit(25.399999618530273D, Telerik.Reporting.Drawing.UnitType.Mm);
            this.PageSettings.Margins.Top = new Telerik.Reporting.Drawing.Unit(25.399999618530273D, Telerik.Reporting.Drawing.UnitType.Mm);
            this.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4;
            reportParameter1.AllowBlank = false;
            reportParameter1.Name = "kulAd";
            reportParameter1.Text = "kulAd";
            reportParameter2.AvailableValues.DataSource = this.dsPlakaList;
            reportParameter2.AvailableValues.DisplayMember = "= Fields.ARC_PLAKA";
            reportParameter2.AvailableValues.ValueMember = "= Fields.ARC_SER1NO";
            reportParameter2.Name = "arcSer1No";
            reportParameter2.Text = "Plaka";
            reportParameter2.Type = Telerik.Reporting.ReportParameterType.Integer;
            reportParameter2.Value = "= Fields.ARC_SER1NO";
            reportParameter2.Visible = true;
            reportParameter3.Name = "basTar";
            reportParameter3.Text = "Tarih";
            reportParameter3.Type = Telerik.Reporting.ReportParameterType.DateTime;
            reportParameter3.Value = "=Now()";
            reportParameter3.Visible = true;
            this.ReportParameters.Add(reportParameter1);
            this.ReportParameters.Add(reportParameter2);
            this.ReportParameters.Add(reportParameter3);
            this.Style.BackgroundColor = System.Drawing.Color.White;
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion

        private Telerik.Reporting.PageHeaderSection pageHeaderSection1;
        private Telerik.Reporting.DetailSection detail;
        private Telerik.Reporting.PageFooterSection pageFooterSection1;
        private Telerik.Reporting.SqlDataSource dsSonKonum;
        private Telerik.Reporting.SqlDataSource dsPlakaList;
        private Telerik.Reporting.SqlDataSource dsTMesafe;
    }
}