namespace MySisRapor
{
    partial class RprAracList
    {
        #region Component Designer generated code
        /// <summary>
        /// Required method for telerik Reporting designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RprAracList));
            Telerik.Reporting.NavigateToReportAction navigateToReportAction1 = new Telerik.Reporting.NavigateToReportAction();
            Telerik.Reporting.ReportParameter reportParameter1 = new Telerik.Reporting.ReportParameter();
            Telerik.Reporting.Drawing.StyleRule styleRule1 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule2 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule3 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule4 = new Telerik.Reporting.Drawing.StyleRule();
            this.dsPlakaList = new Telerik.Reporting.SqlDataSource();
            this.dsAracList = new Telerik.Reporting.SqlDataSource();
            this.labelsGroupHeader = new Telerik.Reporting.GroupHeaderSection();
            this.aRC_SER1NOCaptionTextBox = new Telerik.Reporting.TextBox();
            this.aRC_PLAKACaptionTextBox = new Telerik.Reporting.TextBox();
            this.aRC_SAH1B1CaptionTextBox = new Telerik.Reporting.TextBox();
            this.aRC_MARKACaptionTextBox = new Telerik.Reporting.TextBox();
            this.aRC_MODELCaptionTextBox = new Telerik.Reporting.TextBox();
            this.aRC_RENKCaptionTextBox = new Telerik.Reporting.TextBox();
            this.aRC_C1NSCaptionTextBox = new Telerik.Reporting.TextBox();
            this.aRC_SAS1NOCaptionTextBox = new Telerik.Reporting.TextBox();
            this.aRC_TELCaptionTextBox = new Telerik.Reporting.TextBox();
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
            this.aRC_SER1NODataTextBox = new Telerik.Reporting.TextBox();
            this.aRC_PLAKADataTextBox = new Telerik.Reporting.TextBox();
            this.aRC_SAH1B1DataTextBox = new Telerik.Reporting.TextBox();
            this.aRC_MARKADataTextBox = new Telerik.Reporting.TextBox();
            this.aRC_MODELDataTextBox = new Telerik.Reporting.TextBox();
            this.aRC_RENKDataTextBox = new Telerik.Reporting.TextBox();
            this.aRC_C1NSDataTextBox = new Telerik.Reporting.TextBox();
            this.aRC_SAS1NODataTextBox = new Telerik.Reporting.TextBox();
            this.aRC_TELDataTextBox = new Telerik.Reporting.TextBox();
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
            // dsAracList
            // 
            this.dsAracList.ConnectionString = "MySisRapor.Properties.Settings.ElektrometreServer17817";
            this.dsAracList.Name = "dsAracList";
            this.dsAracList.Parameters.AddRange(new Telerik.Reporting.SqlDataSourceParameter[] {
            new Telerik.Reporting.SqlDataSourceParameter("@kulAd", System.Data.DbType.String, "=Parameters.kulAd.Value")});
            this.dsAracList.SelectCommand = resources.GetString("dsAracList.SelectCommand");
            // 
            // labelsGroupHeader
            // 
            this.labelsGroupHeader.Height = new Telerik.Reporting.Drawing.Unit(0.71437495946884155D, Telerik.Reporting.Drawing.UnitType.Cm);
            this.labelsGroupHeader.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.aRC_SER1NOCaptionTextBox,
            this.aRC_PLAKACaptionTextBox,
            this.aRC_SAH1B1CaptionTextBox,
            this.aRC_MARKACaptionTextBox,
            this.aRC_MODELCaptionTextBox,
            this.aRC_RENKCaptionTextBox,
            this.aRC_C1NSCaptionTextBox,
            this.aRC_SAS1NOCaptionTextBox,
            this.aRC_TELCaptionTextBox});
            this.labelsGroupHeader.Name = "labelsGroupHeader";
            this.labelsGroupHeader.PrintOnEveryPage = true;
            // 
            // aRC_SER1NOCaptionTextBox
            // 
            this.aRC_SER1NOCaptionTextBox.CanGrow = true;
            this.aRC_SER1NOCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(new Telerik.Reporting.Drawing.Unit(0.052916664630174637D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.052916664630174637D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.aRC_SER1NOCaptionTextBox.Name = "aRC_SER1NOCaptionTextBox";
            this.aRC_SER1NOCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(new Telerik.Reporting.Drawing.Unit(2.6650002002716064D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.60000002384185791D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.aRC_SER1NOCaptionTextBox.StyleName = "Caption";
            this.aRC_SER1NOCaptionTextBox.Value = "Seri No";
            // 
            // aRC_PLAKACaptionTextBox
            // 
            this.aRC_PLAKACaptionTextBox.CanGrow = true;
            this.aRC_PLAKACaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(new Telerik.Reporting.Drawing.Unit(2.7708334922790527D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.052916664630174637D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.aRC_PLAKACaptionTextBox.Name = "aRC_PLAKACaptionTextBox";
            this.aRC_PLAKACaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(new Telerik.Reporting.Drawing.Unit(2.6650002002716064D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.60000002384185791D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.aRC_PLAKACaptionTextBox.StyleName = "Caption";
            this.aRC_PLAKACaptionTextBox.Value = "Plaka";
            // 
            // aRC_SAH1B1CaptionTextBox
            // 
            this.aRC_SAH1B1CaptionTextBox.CanGrow = true;
            this.aRC_SAH1B1CaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(new Telerik.Reporting.Drawing.Unit(5.4887504577636719D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.052916664630174637D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.aRC_SAH1B1CaptionTextBox.Name = "aRC_SAH1B1CaptionTextBox";
            this.aRC_SAH1B1CaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(new Telerik.Reporting.Drawing.Unit(2.6650002002716064D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.60000002384185791D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.aRC_SAH1B1CaptionTextBox.StyleName = "Caption";
            this.aRC_SAH1B1CaptionTextBox.Value = "Sahibi";
            // 
            // aRC_MARKACaptionTextBox
            // 
            this.aRC_MARKACaptionTextBox.CanGrow = true;
            this.aRC_MARKACaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(new Telerik.Reporting.Drawing.Unit(8.2066669464111328D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.052916664630174637D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.aRC_MARKACaptionTextBox.Name = "aRC_MARKACaptionTextBox";
            this.aRC_MARKACaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(new Telerik.Reporting.Drawing.Unit(2.6650002002716064D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.60000002384185791D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.aRC_MARKACaptionTextBox.StyleName = "Caption";
            this.aRC_MARKACaptionTextBox.Value = "Marka";
            // 
            // aRC_MODELCaptionTextBox
            // 
            this.aRC_MODELCaptionTextBox.CanGrow = true;
            this.aRC_MODELCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(new Telerik.Reporting.Drawing.Unit(10.924583435058594D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.052916664630174637D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.aRC_MODELCaptionTextBox.Name = "aRC_MODELCaptionTextBox";
            this.aRC_MODELCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(new Telerik.Reporting.Drawing.Unit(2.6650002002716064D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.60000002384185791D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.aRC_MODELCaptionTextBox.StyleName = "Caption";
            this.aRC_MODELCaptionTextBox.Value = "Model";
            // 
            // aRC_RENKCaptionTextBox
            // 
            this.aRC_RENKCaptionTextBox.CanGrow = true;
            this.aRC_RENKCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(new Telerik.Reporting.Drawing.Unit(13.642500877380371D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.052916664630174637D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.aRC_RENKCaptionTextBox.Name = "aRC_RENKCaptionTextBox";
            this.aRC_RENKCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(new Telerik.Reporting.Drawing.Unit(2.6650002002716064D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.60000002384185791D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.aRC_RENKCaptionTextBox.StyleName = "Caption";
            this.aRC_RENKCaptionTextBox.Value = "Renk";
            // 
            // aRC_C1NSCaptionTextBox
            // 
            this.aRC_C1NSCaptionTextBox.CanGrow = true;
            this.aRC_C1NSCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(new Telerik.Reporting.Drawing.Unit(16.360416412353516D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.052916664630174637D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.aRC_C1NSCaptionTextBox.Name = "aRC_C1NSCaptionTextBox";
            this.aRC_C1NSCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(new Telerik.Reporting.Drawing.Unit(2.6650002002716064D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.60000002384185791D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.aRC_C1NSCaptionTextBox.StyleName = "Caption";
            this.aRC_C1NSCaptionTextBox.Value = "Cins";
            // 
            // aRC_SAS1NOCaptionTextBox
            // 
            this.aRC_SAS1NOCaptionTextBox.CanGrow = true;
            this.aRC_SAS1NOCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(new Telerik.Reporting.Drawing.Unit(19.078334808349609D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.052916664630174637D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.aRC_SAS1NOCaptionTextBox.Name = "aRC_SAS1NOCaptionTextBox";
            this.aRC_SAS1NOCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(new Telerik.Reporting.Drawing.Unit(2.6650002002716064D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.60000002384185791D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.aRC_SAS1NOCaptionTextBox.StyleName = "Caption";
            this.aRC_SAS1NOCaptionTextBox.Value = "Þasi No";
            // 
            // aRC_TELCaptionTextBox
            // 
            this.aRC_TELCaptionTextBox.CanGrow = true;
            this.aRC_TELCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(new Telerik.Reporting.Drawing.Unit(21.79625129699707D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.052916664630174637D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.aRC_TELCaptionTextBox.Name = "aRC_TELCaptionTextBox";
            this.aRC_TELCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(new Telerik.Reporting.Drawing.Unit(2.6650002002716064D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.60000002384185791D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.aRC_TELCaptionTextBox.StyleName = "Caption";
            this.aRC_TELCaptionTextBox.Value = "Telefon";
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
            this.reportNameTextBox.Size = new Telerik.Reporting.Drawing.SizeU(new Telerik.Reporting.Drawing.Unit(24.408334732055664D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.60000002384185791D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.reportNameTextBox.StyleName = "PageInfo";
            this.reportNameTextBox.Value = "Araç Listesi Raporu";
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
            this.currentTimeTextBox.Size = new Telerik.Reporting.Drawing.SizeU(new Telerik.Reporting.Drawing.Unit(12.177709579467773D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.60000002384185791D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.currentTimeTextBox.StyleName = "PageInfo";
            this.currentTimeTextBox.Value = "=NOW()";
            // 
            // pageInfoTextBox
            // 
            this.pageInfoTextBox.Location = new Telerik.Reporting.Drawing.PointU(new Telerik.Reporting.Drawing.Unit(12.283542633056641D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.052916664630174637D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.pageInfoTextBox.Name = "pageInfoTextBox";
            this.pageInfoTextBox.Size = new Telerik.Reporting.Drawing.SizeU(new Telerik.Reporting.Drawing.Unit(12.177709579467773D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.60000002384185791D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.pageInfoTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
            this.pageInfoTextBox.StyleName = "PageInfo";
            this.pageInfoTextBox.Value = "=PageNumber";
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
            this.titleTextBox.Size = new Telerik.Reporting.Drawing.SizeU(new Telerik.Reporting.Drawing.Unit(21.74333381652832D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(2D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.titleTextBox.StyleName = "Title";
            this.titleTextBox.Value = "Araç Listesi";
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
            this.panel8.Location = new Telerik.Reporting.Drawing.PointU(new Telerik.Reporting.Drawing.Unit(22.19999885559082D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(9.9921220680698752E-05D, Telerik.Reporting.Drawing.UnitType.Cm));
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
            this.textBox21.Value = "RAPORLAR";
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
            this.aRC_SER1NODataTextBox,
            this.aRC_PLAKADataTextBox,
            this.aRC_SAH1B1DataTextBox,
            this.aRC_MARKADataTextBox,
            this.aRC_MODELDataTextBox,
            this.aRC_RENKDataTextBox,
            this.aRC_C1NSDataTextBox,
            this.aRC_SAS1NODataTextBox,
            this.aRC_TELDataTextBox});
            this.detail.Name = "detail";
            // 
            // aRC_SER1NODataTextBox
            // 
            this.aRC_SER1NODataTextBox.CanGrow = true;
            this.aRC_SER1NODataTextBox.Location = new Telerik.Reporting.Drawing.PointU(new Telerik.Reporting.Drawing.Unit(0.052916664630174637D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.052916664630174637D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.aRC_SER1NODataTextBox.Name = "aRC_SER1NODataTextBox";
            this.aRC_SER1NODataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(new Telerik.Reporting.Drawing.Unit(2.6650002002716064D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.60000002384185791D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.aRC_SER1NODataTextBox.StyleName = "Data";
            this.aRC_SER1NODataTextBox.Value = "=Fields.ARC_SER1NO";
            // 
            // aRC_PLAKADataTextBox
            // 
            this.aRC_PLAKADataTextBox.CanGrow = true;
            this.aRC_PLAKADataTextBox.Location = new Telerik.Reporting.Drawing.PointU(new Telerik.Reporting.Drawing.Unit(2.7708334922790527D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.052916664630174637D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.aRC_PLAKADataTextBox.Name = "aRC_PLAKADataTextBox";
            this.aRC_PLAKADataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(new Telerik.Reporting.Drawing.Unit(2.6650002002716064D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.60000002384185791D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.aRC_PLAKADataTextBox.StyleName = "Data";
            this.aRC_PLAKADataTextBox.Value = "=Fields.ARC_PLAKA";
            // 
            // aRC_SAH1B1DataTextBox
            // 
            this.aRC_SAH1B1DataTextBox.CanGrow = true;
            this.aRC_SAH1B1DataTextBox.Location = new Telerik.Reporting.Drawing.PointU(new Telerik.Reporting.Drawing.Unit(5.4887504577636719D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.052916664630174637D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.aRC_SAH1B1DataTextBox.Name = "aRC_SAH1B1DataTextBox";
            this.aRC_SAH1B1DataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(new Telerik.Reporting.Drawing.Unit(2.6650002002716064D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.60000002384185791D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.aRC_SAH1B1DataTextBox.StyleName = "Data";
            this.aRC_SAH1B1DataTextBox.Value = "=Fields.ARC_SAH1B1";
            // 
            // aRC_MARKADataTextBox
            // 
            this.aRC_MARKADataTextBox.CanGrow = true;
            this.aRC_MARKADataTextBox.Location = new Telerik.Reporting.Drawing.PointU(new Telerik.Reporting.Drawing.Unit(8.2066669464111328D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.052916664630174637D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.aRC_MARKADataTextBox.Name = "aRC_MARKADataTextBox";
            this.aRC_MARKADataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(new Telerik.Reporting.Drawing.Unit(2.6650002002716064D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.60000002384185791D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.aRC_MARKADataTextBox.StyleName = "Data";
            this.aRC_MARKADataTextBox.Value = "=Fields.ARC_MARKA";
            // 
            // aRC_MODELDataTextBox
            // 
            this.aRC_MODELDataTextBox.CanGrow = true;
            this.aRC_MODELDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(new Telerik.Reporting.Drawing.Unit(10.924583435058594D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.052916664630174637D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.aRC_MODELDataTextBox.Name = "aRC_MODELDataTextBox";
            this.aRC_MODELDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(new Telerik.Reporting.Drawing.Unit(2.6650002002716064D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.60000002384185791D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.aRC_MODELDataTextBox.StyleName = "Data";
            this.aRC_MODELDataTextBox.Value = "=Fields.ARC_MODEL";
            // 
            // aRC_RENKDataTextBox
            // 
            this.aRC_RENKDataTextBox.CanGrow = true;
            this.aRC_RENKDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(new Telerik.Reporting.Drawing.Unit(13.642500877380371D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.052916664630174637D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.aRC_RENKDataTextBox.Name = "aRC_RENKDataTextBox";
            this.aRC_RENKDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(new Telerik.Reporting.Drawing.Unit(2.6650002002716064D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.60000002384185791D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.aRC_RENKDataTextBox.StyleName = "Data";
            this.aRC_RENKDataTextBox.Value = "=Fields.ARC_RENK";
            // 
            // aRC_C1NSDataTextBox
            // 
            this.aRC_C1NSDataTextBox.CanGrow = true;
            this.aRC_C1NSDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(new Telerik.Reporting.Drawing.Unit(16.360416412353516D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.052916664630174637D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.aRC_C1NSDataTextBox.Name = "aRC_C1NSDataTextBox";
            this.aRC_C1NSDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(new Telerik.Reporting.Drawing.Unit(2.6650002002716064D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.60000002384185791D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.aRC_C1NSDataTextBox.StyleName = "Data";
            this.aRC_C1NSDataTextBox.Value = "=Fields.ARC_C1NS";
            // 
            // aRC_SAS1NODataTextBox
            // 
            this.aRC_SAS1NODataTextBox.CanGrow = true;
            this.aRC_SAS1NODataTextBox.Location = new Telerik.Reporting.Drawing.PointU(new Telerik.Reporting.Drawing.Unit(19.078334808349609D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.052916664630174637D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.aRC_SAS1NODataTextBox.Name = "aRC_SAS1NODataTextBox";
            this.aRC_SAS1NODataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(new Telerik.Reporting.Drawing.Unit(2.6650002002716064D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.60000002384185791D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.aRC_SAS1NODataTextBox.StyleName = "Data";
            this.aRC_SAS1NODataTextBox.Value = "=Fields.ARC_SAS1NO";
            // 
            // aRC_TELDataTextBox
            // 
            this.aRC_TELDataTextBox.CanGrow = true;
            this.aRC_TELDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(new Telerik.Reporting.Drawing.Unit(21.79625129699707D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.052916664630174637D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.aRC_TELDataTextBox.Name = "aRC_TELDataTextBox";
            this.aRC_TELDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(new Telerik.Reporting.Drawing.Unit(2.6650002002716064D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.60000002384185791D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.aRC_TELDataTextBox.StyleName = "Data";
            this.aRC_TELDataTextBox.Value = "=Fields.ARC_TEL";
            // 
            // RprAracList
            // 
            this.DataSource = this.dsAracList;
            this.Groups.AddRange(new Telerik.Reporting.Group[] {
            this.labelsGroup});
            this.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.labelsGroupHeader,
            this.labelsGroupFooter,
            this.pageHeader,
            this.pageFooter,
            this.reportHeader,
            this.reportFooter,
            this.detail});
            this.PageSettings.Landscape = true;
            this.PageSettings.Margins.Bottom = new Telerik.Reporting.Drawing.Unit(25.399999618530273D, Telerik.Reporting.Drawing.UnitType.Mm);
            this.PageSettings.Margins.Left = new Telerik.Reporting.Drawing.Unit(25.399999618530273D, Telerik.Reporting.Drawing.UnitType.Mm);
            this.PageSettings.Margins.Right = new Telerik.Reporting.Drawing.Unit(25.399999618530273D, Telerik.Reporting.Drawing.UnitType.Mm);
            this.PageSettings.Margins.Top = new Telerik.Reporting.Drawing.Unit(25.399999618530273D, Telerik.Reporting.Drawing.UnitType.Mm);
            this.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4;
            reportParameter1.Name = "kulAd";
            this.ReportParameters.Add(reportParameter1);
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
            this.Width = new Telerik.Reporting.Drawing.Unit(24.514167785644531D, Telerik.Reporting.Drawing.UnitType.Cm);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion

        private Telerik.Reporting.SqlDataSource dsPlakaList;
        private Telerik.Reporting.SqlDataSource dsAracList;
        private Telerik.Reporting.GroupHeaderSection labelsGroupHeader;
        private Telerik.Reporting.TextBox aRC_SER1NOCaptionTextBox;
        private Telerik.Reporting.TextBox aRC_PLAKACaptionTextBox;
        private Telerik.Reporting.TextBox aRC_SAH1B1CaptionTextBox;
        private Telerik.Reporting.TextBox aRC_MARKACaptionTextBox;
        private Telerik.Reporting.TextBox aRC_MODELCaptionTextBox;
        private Telerik.Reporting.TextBox aRC_RENKCaptionTextBox;
        private Telerik.Reporting.TextBox aRC_C1NSCaptionTextBox;
        private Telerik.Reporting.TextBox aRC_SAS1NOCaptionTextBox;
        private Telerik.Reporting.TextBox aRC_TELCaptionTextBox;
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
        private Telerik.Reporting.TextBox aRC_SER1NODataTextBox;
        private Telerik.Reporting.TextBox aRC_PLAKADataTextBox;
        private Telerik.Reporting.TextBox aRC_SAH1B1DataTextBox;
        private Telerik.Reporting.TextBox aRC_MARKADataTextBox;
        private Telerik.Reporting.TextBox aRC_MODELDataTextBox;
        private Telerik.Reporting.TextBox aRC_RENKDataTextBox;
        private Telerik.Reporting.TextBox aRC_C1NSDataTextBox;
        private Telerik.Reporting.TextBox aRC_SAS1NODataTextBox;
        private Telerik.Reporting.TextBox aRC_TELDataTextBox;
        private Telerik.Reporting.Panel panel8;
        private Telerik.Reporting.PictureBox pictureBox7;
        private Telerik.Reporting.TextBox textBox21;
    }
}