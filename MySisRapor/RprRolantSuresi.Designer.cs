namespace MySisRapor
{
    partial class RprRolantSuresi
    {
        #region Component Designer generated code
        /// <summary>
        /// Required method for telerik Reporting designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RprRolantSuresi));
            Telerik.Reporting.NavigateToReportAction navigateToReportAction1 = new Telerik.Reporting.NavigateToReportAction();
            Telerik.Reporting.ReportParameter reportParameter1 = new Telerik.Reporting.ReportParameter();
            Telerik.Reporting.ReportParameter reportParameter2 = new Telerik.Reporting.ReportParameter();
            Telerik.Reporting.ReportParameter reportParameter3 = new Telerik.Reporting.ReportParameter();
            Telerik.Reporting.ReportParameter reportParameter4 = new Telerik.Reporting.ReportParameter();
            Telerik.Reporting.Drawing.StyleRule styleRule1 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule2 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule3 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule4 = new Telerik.Reporting.Drawing.StyleRule();
            this.dsPlakaList = new Telerik.Reporting.SqlDataSource();
            this.dsDuraklama = new Telerik.Reporting.SqlDataSource();
            this.aRC_PLAKAGroupHeader = new Telerik.Reporting.GroupHeaderSection();
            this.aRC_PLAKACaptionTextBox = new Telerik.Reporting.TextBox();
            this.aRC_PLAKADataTextBox = new Telerik.Reporting.TextBox();
            this.aRC_PLAKAGroupFooter = new Telerik.Reporting.GroupFooterSection();
            this.aRC_PLAKAGroup = new Telerik.Reporting.Group();
            this.labelsGroupHeader = new Telerik.Reporting.GroupHeaderSection();
            this.dT_DURBASTARCaptionTextBox = new Telerik.Reporting.TextBox();
            this.dT_DURBITTARCaptionTextBox = new Telerik.Reporting.TextBox();
            this.dT_DURSURESICaptionTextBox = new Telerik.Reporting.TextBox();
            this.dT_ADRESCaptionTextBox = new Telerik.Reporting.TextBox();
            this.textBox2 = new Telerik.Reporting.TextBox();
            this.labelsGroupFooter = new Telerik.Reporting.GroupFooterSection();
            this.labelsGroup = new Telerik.Reporting.Group();
            this.pageHeader = new Telerik.Reporting.PageHeaderSection();
            this.reportNameTextBox = new Telerik.Reporting.TextBox();
            this.pageFooter = new Telerik.Reporting.PageFooterSection();
            this.currentTimeTextBox = new Telerik.Reporting.TextBox();
            this.pageInfoTextBox = new Telerik.Reporting.TextBox();
            this.reportHeader = new Telerik.Reporting.ReportHeaderSection();
            this.titleTextBox = new Telerik.Reporting.TextBox();
            this.panel8 = new Telerik.Reporting.Panel();
            this.pictureBox7 = new Telerik.Reporting.PictureBox();
            this.textBox21 = new Telerik.Reporting.TextBox();
            this.reportFooter = new Telerik.Reporting.ReportFooterSection();
            this.detail = new Telerik.Reporting.DetailSection();
            this.dT_DURBASTARDataTextBox = new Telerik.Reporting.TextBox();
            this.dT_DURBITTARDataTextBox = new Telerik.Reporting.TextBox();
            this.dT_DURSURESIDataTextBox = new Telerik.Reporting.TextBox();
            this.dT_ADRESDataTextBox = new Telerik.Reporting.TextBox();
            this.textBox1 = new Telerik.Reporting.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
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
            // dsDuraklama
            // 
            this.dsDuraklama.ConnectionString = "MySisRapor.Properties.Settings.ElektrometreServer17817";
            this.dsDuraklama.Name = "dsDuraklama";
            this.dsDuraklama.Parameters.AddRange(new Telerik.Reporting.SqlDataSourceParameter[] {
            new Telerik.Reporting.SqlDataSourceParameter("@arcSer1No", System.Data.DbType.String, "=Parameters.Plaka.Value"),
            new Telerik.Reporting.SqlDataSourceParameter("@basTar", System.Data.DbType.DateTime, "=Parameters.basTar.Value"),
            new Telerik.Reporting.SqlDataSourceParameter("@bitTar", System.Data.DbType.DateTime, "=Parameters.bitTar.Value")});
            this.dsDuraklama.SelectCommand = resources.GetString("dsDuraklama.SelectCommand");
            // 
            // aRC_PLAKAGroupHeader
            // 
            this.aRC_PLAKAGroupHeader.Height = new Telerik.Reporting.Drawing.Unit(0.71437495946884155D, Telerik.Reporting.Drawing.UnitType.Cm);
            this.aRC_PLAKAGroupHeader.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.aRC_PLAKACaptionTextBox,
            this.aRC_PLAKADataTextBox});
            this.aRC_PLAKAGroupHeader.Name = "aRC_PLAKAGroupHeader";
            // 
            // aRC_PLAKACaptionTextBox
            // 
            this.aRC_PLAKACaptionTextBox.CanGrow = true;
            this.aRC_PLAKACaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(new Telerik.Reporting.Drawing.Unit(0.052916664630174637D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.052916664630174637D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.aRC_PLAKACaptionTextBox.Name = "aRC_PLAKACaptionTextBox";
            this.aRC_PLAKACaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(new Telerik.Reporting.Drawing.Unit(2D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.60000002384185791D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.aRC_PLAKACaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
            this.aRC_PLAKACaptionTextBox.StyleName = "Caption";
            resources.ApplyResources(this.aRC_PLAKACaptionTextBox, "aRC_PLAKACaptionTextBox");
            // 
            // aRC_PLAKADataTextBox
            // 
            this.aRC_PLAKADataTextBox.CanGrow = true;
            this.aRC_PLAKADataTextBox.Location = new Telerik.Reporting.Drawing.PointU(new Telerik.Reporting.Drawing.Unit(2.1058332920074463D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.052916664630174637D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.aRC_PLAKADataTextBox.Name = "aRC_PLAKADataTextBox";
            this.aRC_PLAKADataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(new Telerik.Reporting.Drawing.Unit(13.602499961853027D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.60000002384185791D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.aRC_PLAKADataTextBox.StyleName = "Data";
            resources.ApplyResources(this.aRC_PLAKADataTextBox, "aRC_PLAKADataTextBox");
            // 
            // aRC_PLAKAGroupFooter
            // 
            this.aRC_PLAKAGroupFooter.Height = new Telerik.Reporting.Drawing.Unit(0.71437495946884155D, Telerik.Reporting.Drawing.UnitType.Cm);
            this.aRC_PLAKAGroupFooter.Name = "aRC_PLAKAGroupFooter";
            // 
            // aRC_PLAKAGroup
            // 
            this.aRC_PLAKAGroup.GroupFooter = this.aRC_PLAKAGroupFooter;
            this.aRC_PLAKAGroup.GroupHeader = this.aRC_PLAKAGroupHeader;
            this.aRC_PLAKAGroup.Groupings.AddRange(new Telerik.Reporting.Data.Grouping[] {
            new Telerik.Reporting.Data.Grouping("=Fields.ARC_PLAKA")});
            this.aRC_PLAKAGroup.Name = "aRC_PLAKAGroup";
            // 
            // labelsGroupHeader
            // 
            this.labelsGroupHeader.Height = new Telerik.Reporting.Drawing.Unit(0.71833336353302D, Telerik.Reporting.Drawing.UnitType.Cm);
            this.labelsGroupHeader.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.dT_DURBASTARCaptionTextBox,
            this.dT_DURBITTARCaptionTextBox,
            this.dT_DURSURESICaptionTextBox,
            this.dT_ADRESCaptionTextBox,
            this.textBox2});
            this.labelsGroupHeader.Name = "labelsGroupHeader";
            this.labelsGroupHeader.PrintOnEveryPage = true;
            // 
            // dT_DURBASTARCaptionTextBox
            // 
            this.dT_DURBASTARCaptionTextBox.CanGrow = true;
            this.dT_DURBASTARCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(new Telerik.Reporting.Drawing.Unit(0.052916664630174637D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.052916664630174637D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.dT_DURBASTARCaptionTextBox.Name = "dT_DURBASTARCaptionTextBox";
            this.dT_DURBASTARCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(new Telerik.Reporting.Drawing.Unit(3.8873958587646484D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.60000002384185791D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.dT_DURBASTARCaptionTextBox.StyleName = "Caption";
            resources.ApplyResources(this.dT_DURBASTARCaptionTextBox, "dT_DURBASTARCaptionTextBox");
            // 
            // dT_DURBITTARCaptionTextBox
            // 
            this.dT_DURBITTARCaptionTextBox.CanGrow = true;
            this.dT_DURBITTARCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(new Telerik.Reporting.Drawing.Unit(3.9932291507720947D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.052916664630174637D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.dT_DURBITTARCaptionTextBox.Name = "dT_DURBITTARCaptionTextBox";
            this.dT_DURBITTARCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(new Telerik.Reporting.Drawing.Unit(3.8873958587646484D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.60000002384185791D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.dT_DURBITTARCaptionTextBox.StyleName = "Caption";
            resources.ApplyResources(this.dT_DURBITTARCaptionTextBox, "dT_DURBITTARCaptionTextBox");
            // 
            // dT_DURSURESICaptionTextBox
            // 
            this.dT_DURSURESICaptionTextBox.CanGrow = true;
            this.dT_DURSURESICaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(new Telerik.Reporting.Drawing.Unit(9.6825017929077148D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.052916664630174637D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.dT_DURSURESICaptionTextBox.Name = "dT_DURSURESICaptionTextBox";
            this.dT_DURSURESICaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(new Telerik.Reporting.Drawing.Unit(2.0664582252502441D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.60000002384185791D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.dT_DURSURESICaptionTextBox.StyleName = "Caption";
            resources.ApplyResources(this.dT_DURSURESICaptionTextBox, "dT_DURSURESICaptionTextBox");
            // 
            // dT_ADRESCaptionTextBox
            // 
            this.dT_ADRESCaptionTextBox.CanGrow = true;
            this.dT_ADRESCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(new Telerik.Reporting.Drawing.Unit(11.799999237060547D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.052916664630174637D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.dT_ADRESCaptionTextBox.Name = "dT_ADRESCaptionTextBox";
            this.dT_ADRESCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(new Telerik.Reporting.Drawing.Unit(12.100000381469727D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.60000002384185791D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.dT_ADRESCaptionTextBox.StyleName = "Caption";
            resources.ApplyResources(this.dT_ADRESCaptionTextBox, "dT_ADRESCaptionTextBox");
            // 
            // textBox2
            // 
            this.textBox2.CanGrow = true;
            this.textBox2.Location = new Telerik.Reporting.Drawing.PointU(new Telerik.Reporting.Drawing.Unit(7.9316635131835938D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.052916664630174637D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new Telerik.Reporting.Drawing.SizeU(new Telerik.Reporting.Drawing.Unit(1.6998002529144287D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.60000002384185791D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.textBox2.StyleName = "Caption";
            resources.ApplyResources(this.textBox2, "textBox2");
            // 
            // labelsGroupFooter
            // 
            this.labelsGroupFooter.Height = new Telerik.Reporting.Drawing.Unit(0.71437495946884155D, Telerik.Reporting.Drawing.UnitType.Cm);
            this.labelsGroupFooter.Name = "labelsGroupFooter";
            this.labelsGroupFooter.Style.Visible = false;
            // 
            // labelsGroup
            // 
            this.labelsGroup.GroupFooter = this.labelsGroupFooter;
            this.labelsGroup.GroupHeader = this.labelsGroupHeader;
            this.labelsGroup.Name = "labelsGroup";
            // 
            // pageHeader
            // 
            this.pageHeader.Height = new Telerik.Reporting.Drawing.Unit(0.71437495946884155D, Telerik.Reporting.Drawing.UnitType.Cm);
            this.pageHeader.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.reportNameTextBox});
            this.pageHeader.Name = "pageHeader";
            // 
            // reportNameTextBox
            // 
            this.reportNameTextBox.Location = new Telerik.Reporting.Drawing.PointU(new Telerik.Reporting.Drawing.Unit(0.052916664630174637D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.052916664630174637D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.reportNameTextBox.Name = "reportNameTextBox";
            this.reportNameTextBox.Size = new Telerik.Reporting.Drawing.SizeU(new Telerik.Reporting.Drawing.Unit(15.708333015441895D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.60000002384185791D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.reportNameTextBox.StyleName = "PageInfo";
            resources.ApplyResources(this.reportNameTextBox, "reportNameTextBox");
            // 
            // pageFooter
            // 
            this.pageFooter.Height = new Telerik.Reporting.Drawing.Unit(0.71437495946884155D, Telerik.Reporting.Drawing.UnitType.Cm);
            this.pageFooter.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.currentTimeTextBox,
            this.pageInfoTextBox});
            this.pageFooter.Name = "pageFooter";
            // 
            // currentTimeTextBox
            // 
            this.currentTimeTextBox.Location = new Telerik.Reporting.Drawing.PointU(new Telerik.Reporting.Drawing.Unit(0.052916664630174637D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.052916664630174637D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.currentTimeTextBox.Name = "currentTimeTextBox";
            this.currentTimeTextBox.Size = new Telerik.Reporting.Drawing.SizeU(new Telerik.Reporting.Drawing.Unit(7.8277082443237305D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.60000002384185791D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.currentTimeTextBox.StyleName = "PageInfo";
            resources.ApplyResources(this.currentTimeTextBox, "currentTimeTextBox");
            // 
            // pageInfoTextBox
            // 
            this.pageInfoTextBox.Location = new Telerik.Reporting.Drawing.PointU(new Telerik.Reporting.Drawing.Unit(16D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.052916664630174637D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.pageInfoTextBox.Name = "pageInfoTextBox";
            this.pageInfoTextBox.Size = new Telerik.Reporting.Drawing.SizeU(new Telerik.Reporting.Drawing.Unit(7.8277082443237305D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.60000002384185791D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.pageInfoTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
            this.pageInfoTextBox.StyleName = "PageInfo";
            resources.ApplyResources(this.pageInfoTextBox, "pageInfoTextBox");
            // 
            // reportHeader
            // 
            this.reportHeader.Height = new Telerik.Reporting.Drawing.Unit(2.0529167652130127D, Telerik.Reporting.Drawing.UnitType.Cm);
            this.reportHeader.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.titleTextBox,
            this.panel8});
            this.reportHeader.Name = "reportHeader";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new Telerik.Reporting.Drawing.PointU(new Telerik.Reporting.Drawing.Unit(0D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new Telerik.Reporting.Drawing.SizeU(new Telerik.Reporting.Drawing.Unit(15.30000114440918D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(2D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.titleTextBox.StyleName = "Title";
            resources.ApplyResources(this.titleTextBox, "titleTextBox");
            // 
            // panel8
            // 
            navigateToReportAction1.Parameters.Add(new Telerik.Reporting.Parameter("kulAd", "=Parameters.kulAd.Value"));
            navigateToReportAction1.ReportDocumentType = "MySisRapor.Report1, MySisRapor, Version=1.0.0.0, Culture=neutral, PublicKeyToken=" +
                "null";
            this.panel8.Action = navigateToReportAction1;
            this.panel8.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.pictureBox7,
            this.textBox21});
            this.panel8.Location = new Telerik.Reporting.Drawing.PointU(new Telerik.Reporting.Drawing.Unit(21.600000381469727D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(9.9921220680698752E-05D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.panel8.Name = "panel8";
            this.panel8.Size = new Telerik.Reporting.Drawing.SizeU(new Telerik.Reporting.Drawing.Unit(2.2612524032592773D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(1.5000002384185791D, Telerik.Reporting.Drawing.UnitType.Cm));
            // 
            // pictureBox7
            // 
            this.pictureBox7.Location = new Telerik.Reporting.Drawing.PointU(new Telerik.Reporting.Drawing.Unit(0.63874489068984985D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.pictureBox7.MimeType = "image/png";
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new Telerik.Reporting.Drawing.SizeU(new Telerik.Reporting.Drawing.Unit(0.89999997615814209D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.89999997615814209D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.pictureBox7.Value = ((object)(resources.GetObject("pictureBox7.Value")));
            // 
            // textBox21
            // 
            this.textBox21.Location = new Telerik.Reporting.Drawing.PointU(new Telerik.Reporting.Drawing.Unit(0.00010012308484874666D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.9001997709274292D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.textBox21.Name = "textBox21";
            this.textBox21.Size = new Telerik.Reporting.Drawing.SizeU(new Telerik.Reporting.Drawing.Unit(2.2610504627227783D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.60000008344650269D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.textBox21.Style.Color = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(58)))), ((int)(((byte)(112)))));
            this.textBox21.Style.Font.Bold = true;
            resources.ApplyResources(this.textBox21, "textBox21");
            // 
            // reportFooter
            // 
            this.reportFooter.Height = new Telerik.Reporting.Drawing.Unit(0.71437495946884155D, Telerik.Reporting.Drawing.UnitType.Cm);
            this.reportFooter.Name = "reportFooter";
            // 
            // detail
            // 
            this.detail.Height = new Telerik.Reporting.Drawing.Unit(0.71437495946884155D, Telerik.Reporting.Drawing.UnitType.Cm);
            this.detail.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.dT_DURBASTARDataTextBox,
            this.dT_DURBITTARDataTextBox,
            this.dT_DURSURESIDataTextBox,
            this.dT_ADRESDataTextBox,
            this.textBox1});
            this.detail.Name = "detail";
            // 
            // dT_DURBASTARDataTextBox
            // 
            this.dT_DURBASTARDataTextBox.CanGrow = true;
            this.dT_DURBASTARDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(new Telerik.Reporting.Drawing.Unit(0.052916664630174637D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.052916664630174637D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.dT_DURBASTARDataTextBox.Name = "dT_DURBASTARDataTextBox";
            this.dT_DURBASTARDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(new Telerik.Reporting.Drawing.Unit(3.8873958587646484D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.60000002384185791D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.dT_DURBASTARDataTextBox.StyleName = "Data";
            resources.ApplyResources(this.dT_DURBASTARDataTextBox, "dT_DURBASTARDataTextBox");
            // 
            // dT_DURBITTARDataTextBox
            // 
            this.dT_DURBITTARDataTextBox.CanGrow = true;
            this.dT_DURBITTARDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(new Telerik.Reporting.Drawing.Unit(3.9932291507720947D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.052916664630174637D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.dT_DURBITTARDataTextBox.Name = "dT_DURBITTARDataTextBox";
            this.dT_DURBITTARDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(new Telerik.Reporting.Drawing.Unit(3.8873958587646484D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.60000002384185791D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.dT_DURBITTARDataTextBox.StyleName = "Data";
            resources.ApplyResources(this.dT_DURBITTARDataTextBox, "dT_DURBITTARDataTextBox");
            // 
            // dT_DURSURESIDataTextBox
            // 
            this.dT_DURSURESIDataTextBox.CanGrow = true;
            this.dT_DURSURESIDataTextBox.Format = "{0:T}";
            this.dT_DURSURESIDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(new Telerik.Reporting.Drawing.Unit(9.6880216598510742D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.052916664630174637D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.dT_DURSURESIDataTextBox.Name = "dT_DURSURESIDataTextBox";
            this.dT_DURSURESIDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(new Telerik.Reporting.Drawing.Unit(2.0664582252502441D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.60000002384185791D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.dT_DURSURESIDataTextBox.StyleName = "Data";
            resources.ApplyResources(this.dT_DURSURESIDataTextBox, "dT_DURSURESIDataTextBox");
            // 
            // dT_ADRESDataTextBox
            // 
            this.dT_ADRESDataTextBox.CanGrow = true;
            this.dT_ADRESDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(new Telerik.Reporting.Drawing.Unit(11.799999237060547D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.052916664630174637D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.dT_ADRESDataTextBox.Name = "dT_ADRESDataTextBox";
            this.dT_ADRESDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(new Telerik.Reporting.Drawing.Unit(12.099900245666504D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.60000002384185791D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.dT_ADRESDataTextBox.StyleName = "Data";
            resources.ApplyResources(this.dT_ADRESDataTextBox, "dT_ADRESDataTextBox");
            // 
            // textBox1
            // 
            this.textBox1.CanGrow = true;
            this.textBox1.Format = "{0}";
            this.textBox1.Location = new Telerik.Reporting.Drawing.PointU(new Telerik.Reporting.Drawing.Unit(7.9261436462402344D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.052916664630174637D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new Telerik.Reporting.Drawing.SizeU(new Telerik.Reporting.Drawing.Unit(1.7163593769073486D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.60000002384185791D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.textBox1.StyleName = "Data";
            resources.ApplyResources(this.textBox1, "textBox1");
            // 
            // RprRolantSuresi
            // 
            this.DataSource = this.dsDuraklama;
            this.Groups.AddRange(new Telerik.Reporting.Group[] {
            this.aRC_PLAKAGroup,
            this.labelsGroup});
            this.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.aRC_PLAKAGroupHeader,
            this.aRC_PLAKAGroupFooter,
            this.labelsGroupHeader,
            this.labelsGroupFooter,
            this.pageHeader,
            this.pageFooter,
            this.reportHeader,
            this.reportFooter,
            this.detail});
            this.PageSettings.Landscape = true;
            this.PageSettings.Margins.Bottom = new Telerik.Reporting.Drawing.Unit(10D, Telerik.Reporting.Drawing.UnitType.Mm);
            this.PageSettings.Margins.Left = new Telerik.Reporting.Drawing.Unit(10D, Telerik.Reporting.Drawing.UnitType.Mm);
            this.PageSettings.Margins.Right = new Telerik.Reporting.Drawing.Unit(10D, Telerik.Reporting.Drawing.UnitType.Mm);
            this.PageSettings.Margins.Top = new Telerik.Reporting.Drawing.Unit(10D, Telerik.Reporting.Drawing.UnitType.Mm);
            this.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4;
            reportParameter1.Name = "kulAd";
            resources.ApplyResources(reportParameter1, "reportParameter1");
            reportParameter2.Name = "basTar";
            resources.ApplyResources(reportParameter2, "reportParameter2");
            reportParameter2.Type = Telerik.Reporting.ReportParameterType.DateTime;
            reportParameter2.Value = "=Now()";
            reportParameter2.Visible = true;
            reportParameter3.Name = "bitTar";
            resources.ApplyResources(reportParameter3, "reportParameter3");
            reportParameter3.Type = Telerik.Reporting.ReportParameterType.DateTime;
            reportParameter3.Value = "=Now()";
            reportParameter3.Visible = true;
            reportParameter4.AvailableValues.DataSource = this.dsPlakaList;
            reportParameter4.AvailableValues.DisplayMember = "= Fields.ARC_PLAKA";
            reportParameter4.AvailableValues.ValueMember = "= Fields.ARC_SER1NO";
            reportParameter4.Name = "Plaka";
            resources.ApplyResources(reportParameter4, "reportParameter4");
            reportParameter4.Type = Telerik.Reporting.ReportParameterType.Integer;
            reportParameter4.Value = "= Fields.ARC_SER1NO";
            reportParameter4.Visible = true;
            this.ReportParameters.Add(reportParameter1);
            this.ReportParameters.Add(reportParameter2);
            this.ReportParameters.Add(reportParameter3);
            this.ReportParameters.Add(reportParameter4);
            this.Style.BackgroundColor = System.Drawing.Color.White;
            styleRule1.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.StyleSelector("Title")});
            styleRule1.Style.BackgroundColor = System.Drawing.Color.Empty;
            styleRule1.Style.Color = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(58)))), ((int)(((byte)(112)))));
            styleRule1.Style.Font.Name = "Tahoma";
            styleRule1.Style.Font.Size = new Telerik.Reporting.Drawing.Unit(18D, Telerik.Reporting.Drawing.UnitType.Point);
            styleRule2.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.StyleSelector("Caption")});
            styleRule2.Style.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(58)))), ((int)(((byte)(112)))));
            styleRule2.Style.Color = System.Drawing.Color.White;
            styleRule2.Style.Font.Bold = true;
            styleRule2.Style.Font.Italic = false;
            styleRule2.Style.Font.Name = "Tahoma";
            styleRule2.Style.Font.Size = new Telerik.Reporting.Drawing.Unit(11D, Telerik.Reporting.Drawing.UnitType.Point);
            styleRule2.Style.Font.Strikeout = false;
            styleRule2.Style.Font.Underline = false;
            styleRule2.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            styleRule3.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.StyleSelector("Data")});
            styleRule3.Style.Color = System.Drawing.Color.Black;
            styleRule3.Style.Font.Name = "Tahoma";
            styleRule3.Style.Font.Size = new Telerik.Reporting.Drawing.Unit(10D, Telerik.Reporting.Drawing.UnitType.Point);
            styleRule3.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            styleRule4.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.StyleSelector("PageInfo")});
            styleRule4.Style.Color = System.Drawing.Color.Black;
            styleRule4.Style.Font.Name = "Tahoma";
            styleRule4.Style.Font.Size = new Telerik.Reporting.Drawing.Unit(8D, Telerik.Reporting.Drawing.UnitType.Point);
            styleRule4.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.StyleSheet.AddRange(new Telerik.Reporting.Drawing.StyleRule[] {
            styleRule1,
            styleRule2,
            styleRule3,
            styleRule4});
            this.Width = new Telerik.Reporting.Drawing.Unit(23.899999618530273D, Telerik.Reporting.Drawing.UnitType.Cm);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion

        private Telerik.Reporting.SqlDataSource dsDuraklama;
        private Telerik.Reporting.SqlDataSource dsPlakaList;
        private Telerik.Reporting.GroupHeaderSection aRC_PLAKAGroupHeader;
        private Telerik.Reporting.TextBox aRC_PLAKACaptionTextBox;
        private Telerik.Reporting.TextBox aRC_PLAKADataTextBox;
        private Telerik.Reporting.GroupFooterSection aRC_PLAKAGroupFooter;
        private Telerik.Reporting.Group aRC_PLAKAGroup;
        private Telerik.Reporting.GroupHeaderSection labelsGroupHeader;
        private Telerik.Reporting.TextBox dT_DURBASTARCaptionTextBox;
        private Telerik.Reporting.TextBox dT_DURBITTARCaptionTextBox;
        private Telerik.Reporting.TextBox dT_DURSURESICaptionTextBox;
        private Telerik.Reporting.TextBox dT_ADRESCaptionTextBox;
        private Telerik.Reporting.GroupFooterSection labelsGroupFooter;
        private Telerik.Reporting.Group labelsGroup;
        private Telerik.Reporting.PageHeaderSection pageHeader;
        private Telerik.Reporting.TextBox reportNameTextBox;
        private Telerik.Reporting.PageFooterSection pageFooter;
        private Telerik.Reporting.TextBox currentTimeTextBox;
        private Telerik.Reporting.TextBox pageInfoTextBox;
        private Telerik.Reporting.ReportHeaderSection reportHeader;
        private Telerik.Reporting.TextBox titleTextBox;
        private Telerik.Reporting.ReportFooterSection reportFooter;
        private Telerik.Reporting.DetailSection detail;
        private Telerik.Reporting.TextBox dT_DURBASTARDataTextBox;
        private Telerik.Reporting.TextBox dT_DURBITTARDataTextBox;
        private Telerik.Reporting.TextBox dT_DURSURESIDataTextBox;
        private Telerik.Reporting.TextBox dT_ADRESDataTextBox;
        private Telerik.Reporting.Panel panel8;
        private Telerik.Reporting.PictureBox pictureBox7;
        private Telerik.Reporting.TextBox textBox21;
        private Telerik.Reporting.TextBox textBox2;
        private Telerik.Reporting.TextBox textBox1;
    }
}