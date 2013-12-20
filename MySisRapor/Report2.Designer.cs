namespace MySisRapor
{
    partial class Report2
    {
        #region Component Designer generated code
        /// <summary>
        /// Required method for telerik Reporting designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Report2));
            Telerik.Reporting.Drawing.StyleRule styleRule1 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule2 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule3 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule4 = new Telerik.Reporting.Drawing.StyleRule();
            this.sqlDataSource1 = new Telerik.Reporting.SqlDataSource();
            this.labelsGroupHeader = new Telerik.Reporting.GroupHeaderSection();
            this.labelsGroupFooter = new Telerik.Reporting.GroupFooterSection();
            this.labelsGroup = new Telerik.Reporting.Group();
            this.aRC_SER1NOCaptionTextBox = new Telerik.Reporting.TextBox();
            this.dT_ENLEMCaptionTextBox = new Telerik.Reporting.TextBox();
            this.dT_BOYLAMCaptionTextBox = new Telerik.Reporting.TextBox();
            this.dT_TAR1HCaptionTextBox = new Telerik.Reporting.TextBox();
            this.dT_H1ZCaptionTextBox = new Telerik.Reporting.TextBox();
            this.dT_KONTAKCaptionTextBox = new Telerik.Reporting.TextBox();
            this.dT_ADRESCaptionTextBox = new Telerik.Reporting.TextBox();
            this.dT_DURAKLAMACaptionTextBox = new Telerik.Reporting.TextBox();
            this.dT_DURBASTARCaptionTextBox = new Telerik.Reporting.TextBox();
            this.dT_DURBITTARCaptionTextBox = new Telerik.Reporting.TextBox();
            this.dT_DURSURESICaptionTextBox = new Telerik.Reporting.TextBox();
            this.dT_ROLANTCaptionTextBox = new Telerik.Reporting.TextBox();
            this.dT_RLNBASTARCaptionTextBox = new Telerik.Reporting.TextBox();
            this.dT_RLNBITTARCaptionTextBox = new Telerik.Reporting.TextBox();
            this.dT_RLNSURESICaptionTextBox = new Telerik.Reporting.TextBox();
            this.pageHeader = new Telerik.Reporting.PageHeaderSection();
            this.reportNameTextBox = new Telerik.Reporting.TextBox();
            this.pageFooter = new Telerik.Reporting.PageFooterSection();
            this.currentTimeTextBox = new Telerik.Reporting.TextBox();
            this.pageInfoTextBox = new Telerik.Reporting.TextBox();
            this.reportHeader = new Telerik.Reporting.ReportHeaderSection();
            this.titleTextBox = new Telerik.Reporting.TextBox();
            this.reportFooter = new Telerik.Reporting.ReportFooterSection();
            this.detail = new Telerik.Reporting.DetailSection();
            this.aRC_SER1NODataTextBox = new Telerik.Reporting.TextBox();
            this.dT_ENLEMDataTextBox = new Telerik.Reporting.TextBox();
            this.dT_BOYLAMDataTextBox = new Telerik.Reporting.TextBox();
            this.dT_TAR1HDataTextBox = new Telerik.Reporting.TextBox();
            this.dT_H1ZDataTextBox = new Telerik.Reporting.TextBox();
            this.dT_KONTAKDataTextBox = new Telerik.Reporting.TextBox();
            this.dT_ADRESDataTextBox = new Telerik.Reporting.TextBox();
            this.dT_DURAKLAMADataTextBox = new Telerik.Reporting.TextBox();
            this.dT_DURBASTARDataTextBox = new Telerik.Reporting.TextBox();
            this.dT_DURBITTARDataTextBox = new Telerik.Reporting.TextBox();
            this.dT_DURSURESIDataTextBox = new Telerik.Reporting.TextBox();
            this.dT_ROLANTDataTextBox = new Telerik.Reporting.TextBox();
            this.dT_RLNBASTARDataTextBox = new Telerik.Reporting.TextBox();
            this.dT_RLNBITTARDataTextBox = new Telerik.Reporting.TextBox();
            this.dT_RLNSURESIDataTextBox = new Telerik.Reporting.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionString = "MySisRapor.Properties.Settings.ElektrometreServer17817";
            this.sqlDataSource1.Name = "sqlDataSource1";
            this.sqlDataSource1.SelectCommand = resources.GetString("sqlDataSource1.SelectCommand");
            // 
            // labelsGroupHeader
            // 
            this.labelsGroupHeader.Height = new Telerik.Reporting.Drawing.Unit(0.71437495946884155D, Telerik.Reporting.Drawing.UnitType.Cm);
            this.labelsGroupHeader.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.aRC_SER1NOCaptionTextBox,
            this.dT_ENLEMCaptionTextBox,
            this.dT_BOYLAMCaptionTextBox,
            this.dT_TAR1HCaptionTextBox,
            this.dT_H1ZCaptionTextBox,
            this.dT_KONTAKCaptionTextBox,
            this.dT_ADRESCaptionTextBox,
            this.dT_DURAKLAMACaptionTextBox,
            this.dT_DURBASTARCaptionTextBox,
            this.dT_DURBITTARCaptionTextBox,
            this.dT_DURSURESICaptionTextBox,
            this.dT_ROLANTCaptionTextBox,
            this.dT_RLNBASTARCaptionTextBox,
            this.dT_RLNBITTARCaptionTextBox,
            this.dT_RLNSURESICaptionTextBox});
            this.labelsGroupHeader.Name = "labelsGroupHeader";
            this.labelsGroupHeader.PrintOnEveryPage = true;
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
            // aRC_SER1NOCaptionTextBox
            // 
            this.aRC_SER1NOCaptionTextBox.CanGrow = true;
            this.aRC_SER1NOCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(new Telerik.Reporting.Drawing.Unit(0.052916664630174637D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.052916664630174637D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.aRC_SER1NOCaptionTextBox.Name = "aRC_SER1NOCaptionTextBox";
            this.aRC_SER1NOCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(new Telerik.Reporting.Drawing.Unit(1.5778334140777588D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.60000002384185791D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.aRC_SER1NOCaptionTextBox.StyleName = "Caption";
            this.aRC_SER1NOCaptionTextBox.Value = "ARC_SER1NO";
            // 
            // dT_ENLEMCaptionTextBox
            // 
            this.dT_ENLEMCaptionTextBox.CanGrow = true;
            this.dT_ENLEMCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(new Telerik.Reporting.Drawing.Unit(1.6836668252944946D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.052916664630174637D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.dT_ENLEMCaptionTextBox.Name = "dT_ENLEMCaptionTextBox";
            this.dT_ENLEMCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(new Telerik.Reporting.Drawing.Unit(1.5778334140777588D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.60000002384185791D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.dT_ENLEMCaptionTextBox.StyleName = "Caption";
            this.dT_ENLEMCaptionTextBox.Value = "DT_ENLEM";
            // 
            // dT_BOYLAMCaptionTextBox
            // 
            this.dT_BOYLAMCaptionTextBox.CanGrow = true;
            this.dT_BOYLAMCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(new Telerik.Reporting.Drawing.Unit(3.3144168853759766D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.052916664630174637D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.dT_BOYLAMCaptionTextBox.Name = "dT_BOYLAMCaptionTextBox";
            this.dT_BOYLAMCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(new Telerik.Reporting.Drawing.Unit(1.5778334140777588D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.60000002384185791D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.dT_BOYLAMCaptionTextBox.StyleName = "Caption";
            this.dT_BOYLAMCaptionTextBox.Value = "DT_BOYLAM";
            // 
            // dT_TAR1HCaptionTextBox
            // 
            this.dT_TAR1HCaptionTextBox.CanGrow = true;
            this.dT_TAR1HCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(new Telerik.Reporting.Drawing.Unit(4.945167064666748D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.052916664630174637D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.dT_TAR1HCaptionTextBox.Name = "dT_TAR1HCaptionTextBox";
            this.dT_TAR1HCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(new Telerik.Reporting.Drawing.Unit(1.5778334140777588D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.60000002384185791D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.dT_TAR1HCaptionTextBox.StyleName = "Caption";
            this.dT_TAR1HCaptionTextBox.Value = "DT_TAR1H";
            // 
            // dT_H1ZCaptionTextBox
            // 
            this.dT_H1ZCaptionTextBox.CanGrow = true;
            this.dT_H1ZCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(new Telerik.Reporting.Drawing.Unit(6.5759172439575195D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.052916664630174637D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.dT_H1ZCaptionTextBox.Name = "dT_H1ZCaptionTextBox";
            this.dT_H1ZCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(new Telerik.Reporting.Drawing.Unit(1.5778334140777588D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.60000002384185791D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.dT_H1ZCaptionTextBox.StyleName = "Caption";
            this.dT_H1ZCaptionTextBox.Value = "DT_H1Z";
            // 
            // dT_KONTAKCaptionTextBox
            // 
            this.dT_KONTAKCaptionTextBox.CanGrow = true;
            this.dT_KONTAKCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(new Telerik.Reporting.Drawing.Unit(8.2066669464111328D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.052916664630174637D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.dT_KONTAKCaptionTextBox.Name = "dT_KONTAKCaptionTextBox";
            this.dT_KONTAKCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(new Telerik.Reporting.Drawing.Unit(1.5778334140777588D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.60000002384185791D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.dT_KONTAKCaptionTextBox.StyleName = "Caption";
            this.dT_KONTAKCaptionTextBox.Value = "DT_KONTAK";
            // 
            // dT_ADRESCaptionTextBox
            // 
            this.dT_ADRESCaptionTextBox.CanGrow = true;
            this.dT_ADRESCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(new Telerik.Reporting.Drawing.Unit(9.8374166488647461D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.052916664630174637D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.dT_ADRESCaptionTextBox.Name = "dT_ADRESCaptionTextBox";
            this.dT_ADRESCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(new Telerik.Reporting.Drawing.Unit(1.5778334140777588D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.60000002384185791D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.dT_ADRESCaptionTextBox.StyleName = "Caption";
            this.dT_ADRESCaptionTextBox.Value = "DT_ADRES";
            // 
            // dT_DURAKLAMACaptionTextBox
            // 
            this.dT_DURAKLAMACaptionTextBox.CanGrow = true;
            this.dT_DURAKLAMACaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(new Telerik.Reporting.Drawing.Unit(11.468167304992676D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.052916664630174637D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.dT_DURAKLAMACaptionTextBox.Name = "dT_DURAKLAMACaptionTextBox";
            this.dT_DURAKLAMACaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(new Telerik.Reporting.Drawing.Unit(1.5778334140777588D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.60000002384185791D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.dT_DURAKLAMACaptionTextBox.StyleName = "Caption";
            this.dT_DURAKLAMACaptionTextBox.Value = "DT_DURAKLAMA";
            // 
            // dT_DURBASTARCaptionTextBox
            // 
            this.dT_DURBASTARCaptionTextBox.CanGrow = true;
            this.dT_DURBASTARCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(new Telerik.Reporting.Drawing.Unit(13.098917007446289D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.052916664630174637D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.dT_DURBASTARCaptionTextBox.Name = "dT_DURBASTARCaptionTextBox";
            this.dT_DURBASTARCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(new Telerik.Reporting.Drawing.Unit(1.5778334140777588D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.60000002384185791D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.dT_DURBASTARCaptionTextBox.StyleName = "Caption";
            this.dT_DURBASTARCaptionTextBox.Value = "DT_DURBASTAR";
            // 
            // dT_DURBITTARCaptionTextBox
            // 
            this.dT_DURBITTARCaptionTextBox.CanGrow = true;
            this.dT_DURBITTARCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(new Telerik.Reporting.Drawing.Unit(14.729666709899902D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.052916664630174637D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.dT_DURBITTARCaptionTextBox.Name = "dT_DURBITTARCaptionTextBox";
            this.dT_DURBITTARCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(new Telerik.Reporting.Drawing.Unit(1.5778334140777588D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.60000002384185791D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.dT_DURBITTARCaptionTextBox.StyleName = "Caption";
            this.dT_DURBITTARCaptionTextBox.Value = "DT_DURBITTAR";
            // 
            // dT_DURSURESICaptionTextBox
            // 
            this.dT_DURSURESICaptionTextBox.CanGrow = true;
            this.dT_DURSURESICaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(new Telerik.Reporting.Drawing.Unit(16.360418319702148D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.052916664630174637D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.dT_DURSURESICaptionTextBox.Name = "dT_DURSURESICaptionTextBox";
            this.dT_DURSURESICaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(new Telerik.Reporting.Drawing.Unit(1.5778334140777588D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.60000002384185791D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.dT_DURSURESICaptionTextBox.StyleName = "Caption";
            this.dT_DURSURESICaptionTextBox.Value = "DT_DURSURESI";
            // 
            // dT_ROLANTCaptionTextBox
            // 
            this.dT_ROLANTCaptionTextBox.CanGrow = true;
            this.dT_ROLANTCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(new Telerik.Reporting.Drawing.Unit(17.991167068481445D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.052916664630174637D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.dT_ROLANTCaptionTextBox.Name = "dT_ROLANTCaptionTextBox";
            this.dT_ROLANTCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(new Telerik.Reporting.Drawing.Unit(1.5778334140777588D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.60000002384185791D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.dT_ROLANTCaptionTextBox.StyleName = "Caption";
            this.dT_ROLANTCaptionTextBox.Value = "DT_ROLANT";
            // 
            // dT_RLNBASTARCaptionTextBox
            // 
            this.dT_RLNBASTARCaptionTextBox.CanGrow = true;
            this.dT_RLNBASTARCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(new Telerik.Reporting.Drawing.Unit(19.621917724609375D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.052916664630174637D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.dT_RLNBASTARCaptionTextBox.Name = "dT_RLNBASTARCaptionTextBox";
            this.dT_RLNBASTARCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(new Telerik.Reporting.Drawing.Unit(1.5778334140777588D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.60000002384185791D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.dT_RLNBASTARCaptionTextBox.StyleName = "Caption";
            this.dT_RLNBASTARCaptionTextBox.Value = "DT_RLNBASTAR";
            // 
            // dT_RLNBITTARCaptionTextBox
            // 
            this.dT_RLNBITTARCaptionTextBox.CanGrow = true;
            this.dT_RLNBITTARCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(new Telerik.Reporting.Drawing.Unit(21.252666473388672D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.052916664630174637D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.dT_RLNBITTARCaptionTextBox.Name = "dT_RLNBITTARCaptionTextBox";
            this.dT_RLNBITTARCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(new Telerik.Reporting.Drawing.Unit(1.5778334140777588D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.60000002384185791D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.dT_RLNBITTARCaptionTextBox.StyleName = "Caption";
            this.dT_RLNBITTARCaptionTextBox.Value = "DT_RLNBITTAR";
            // 
            // dT_RLNSURESICaptionTextBox
            // 
            this.dT_RLNSURESICaptionTextBox.CanGrow = true;
            this.dT_RLNSURESICaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(new Telerik.Reporting.Drawing.Unit(22.8834171295166D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.052916664630174637D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.dT_RLNSURESICaptionTextBox.Name = "dT_RLNSURESICaptionTextBox";
            this.dT_RLNSURESICaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(new Telerik.Reporting.Drawing.Unit(1.5778334140777588D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.60000002384185791D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.dT_RLNSURESICaptionTextBox.StyleName = "Caption";
            this.dT_RLNSURESICaptionTextBox.Value = "DT_RLNSURESI";
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
            this.reportNameTextBox.Value = "Report2";
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
            this.titleTextBox});
            this.reportHeader.Name = "reportHeader";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new Telerik.Reporting.Drawing.PointU(new Telerik.Reporting.Drawing.Unit(0D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new Telerik.Reporting.Drawing.SizeU(new Telerik.Reporting.Drawing.Unit(24.514167785644531D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(2D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.titleTextBox.StyleName = "Title";
            this.titleTextBox.Value = "Report2";
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
            this.dT_ENLEMDataTextBox,
            this.dT_BOYLAMDataTextBox,
            this.dT_TAR1HDataTextBox,
            this.dT_H1ZDataTextBox,
            this.dT_KONTAKDataTextBox,
            this.dT_ADRESDataTextBox,
            this.dT_DURAKLAMADataTextBox,
            this.dT_DURBASTARDataTextBox,
            this.dT_DURBITTARDataTextBox,
            this.dT_DURSURESIDataTextBox,
            this.dT_ROLANTDataTextBox,
            this.dT_RLNBASTARDataTextBox,
            this.dT_RLNBITTARDataTextBox,
            this.dT_RLNSURESIDataTextBox});
            this.detail.Name = "detail";
            // 
            // aRC_SER1NODataTextBox
            // 
            this.aRC_SER1NODataTextBox.CanGrow = true;
            this.aRC_SER1NODataTextBox.Location = new Telerik.Reporting.Drawing.PointU(new Telerik.Reporting.Drawing.Unit(0.052916664630174637D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.052916664630174637D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.aRC_SER1NODataTextBox.Name = "aRC_SER1NODataTextBox";
            this.aRC_SER1NODataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(new Telerik.Reporting.Drawing.Unit(1.5778334140777588D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.60000002384185791D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.aRC_SER1NODataTextBox.StyleName = "Data";
            this.aRC_SER1NODataTextBox.Value = "=Fields.ARC_SER1NO";
            // 
            // dT_ENLEMDataTextBox
            // 
            this.dT_ENLEMDataTextBox.CanGrow = true;
            this.dT_ENLEMDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(new Telerik.Reporting.Drawing.Unit(1.6836668252944946D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.052916664630174637D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.dT_ENLEMDataTextBox.Name = "dT_ENLEMDataTextBox";
            this.dT_ENLEMDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(new Telerik.Reporting.Drawing.Unit(1.5778334140777588D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.60000002384185791D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.dT_ENLEMDataTextBox.StyleName = "Data";
            this.dT_ENLEMDataTextBox.Value = "=Fields.DT_ENLEM";
            // 
            // dT_BOYLAMDataTextBox
            // 
            this.dT_BOYLAMDataTextBox.CanGrow = true;
            this.dT_BOYLAMDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(new Telerik.Reporting.Drawing.Unit(3.3144168853759766D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.052916664630174637D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.dT_BOYLAMDataTextBox.Name = "dT_BOYLAMDataTextBox";
            this.dT_BOYLAMDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(new Telerik.Reporting.Drawing.Unit(1.5778334140777588D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.60000002384185791D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.dT_BOYLAMDataTextBox.StyleName = "Data";
            this.dT_BOYLAMDataTextBox.Value = "=Fields.DT_BOYLAM";
            // 
            // dT_TAR1HDataTextBox
            // 
            this.dT_TAR1HDataTextBox.CanGrow = true;
            this.dT_TAR1HDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(new Telerik.Reporting.Drawing.Unit(4.945167064666748D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.052916664630174637D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.dT_TAR1HDataTextBox.Name = "dT_TAR1HDataTextBox";
            this.dT_TAR1HDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(new Telerik.Reporting.Drawing.Unit(1.5778334140777588D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.60000002384185791D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.dT_TAR1HDataTextBox.StyleName = "Data";
            this.dT_TAR1HDataTextBox.Value = "=Fields.DT_TAR1H";
            // 
            // dT_H1ZDataTextBox
            // 
            this.dT_H1ZDataTextBox.CanGrow = true;
            this.dT_H1ZDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(new Telerik.Reporting.Drawing.Unit(6.5759172439575195D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.052916664630174637D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.dT_H1ZDataTextBox.Name = "dT_H1ZDataTextBox";
            this.dT_H1ZDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(new Telerik.Reporting.Drawing.Unit(1.5778334140777588D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.60000002384185791D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.dT_H1ZDataTextBox.StyleName = "Data";
            this.dT_H1ZDataTextBox.Value = "=Fields.DT_H1Z";
            // 
            // dT_KONTAKDataTextBox
            // 
            this.dT_KONTAKDataTextBox.CanGrow = true;
            this.dT_KONTAKDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(new Telerik.Reporting.Drawing.Unit(8.2066669464111328D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.052916664630174637D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.dT_KONTAKDataTextBox.Name = "dT_KONTAKDataTextBox";
            this.dT_KONTAKDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(new Telerik.Reporting.Drawing.Unit(1.5778334140777588D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.60000002384185791D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.dT_KONTAKDataTextBox.StyleName = "Data";
            this.dT_KONTAKDataTextBox.Value = "=Fields.DT_KONTAK";
            // 
            // dT_ADRESDataTextBox
            // 
            this.dT_ADRESDataTextBox.CanGrow = true;
            this.dT_ADRESDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(new Telerik.Reporting.Drawing.Unit(9.8374166488647461D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.052916664630174637D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.dT_ADRESDataTextBox.Name = "dT_ADRESDataTextBox";
            this.dT_ADRESDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(new Telerik.Reporting.Drawing.Unit(1.5778334140777588D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.60000002384185791D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.dT_ADRESDataTextBox.StyleName = "Data";
            this.dT_ADRESDataTextBox.Value = "=Fields.DT_ADRES";
            // 
            // dT_DURAKLAMADataTextBox
            // 
            this.dT_DURAKLAMADataTextBox.CanGrow = true;
            this.dT_DURAKLAMADataTextBox.Location = new Telerik.Reporting.Drawing.PointU(new Telerik.Reporting.Drawing.Unit(11.468167304992676D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.052916664630174637D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.dT_DURAKLAMADataTextBox.Name = "dT_DURAKLAMADataTextBox";
            this.dT_DURAKLAMADataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(new Telerik.Reporting.Drawing.Unit(1.5778334140777588D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.60000002384185791D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.dT_DURAKLAMADataTextBox.StyleName = "Data";
            this.dT_DURAKLAMADataTextBox.Value = "=Fields.DT_DURAKLAMA";
            // 
            // dT_DURBASTARDataTextBox
            // 
            this.dT_DURBASTARDataTextBox.CanGrow = true;
            this.dT_DURBASTARDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(new Telerik.Reporting.Drawing.Unit(13.098917007446289D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.052916664630174637D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.dT_DURBASTARDataTextBox.Name = "dT_DURBASTARDataTextBox";
            this.dT_DURBASTARDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(new Telerik.Reporting.Drawing.Unit(1.5778334140777588D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.60000002384185791D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.dT_DURBASTARDataTextBox.StyleName = "Data";
            this.dT_DURBASTARDataTextBox.Value = "=Fields.DT_DURBASTAR";
            // 
            // dT_DURBITTARDataTextBox
            // 
            this.dT_DURBITTARDataTextBox.CanGrow = true;
            this.dT_DURBITTARDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(new Telerik.Reporting.Drawing.Unit(14.729666709899902D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.052916664630174637D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.dT_DURBITTARDataTextBox.Name = "dT_DURBITTARDataTextBox";
            this.dT_DURBITTARDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(new Telerik.Reporting.Drawing.Unit(1.5778334140777588D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.60000002384185791D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.dT_DURBITTARDataTextBox.StyleName = "Data";
            this.dT_DURBITTARDataTextBox.Value = "=Fields.DT_DURBITTAR";
            // 
            // dT_DURSURESIDataTextBox
            // 
            this.dT_DURSURESIDataTextBox.CanGrow = true;
            this.dT_DURSURESIDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(new Telerik.Reporting.Drawing.Unit(16.360418319702148D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.052916664630174637D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.dT_DURSURESIDataTextBox.Name = "dT_DURSURESIDataTextBox";
            this.dT_DURSURESIDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(new Telerik.Reporting.Drawing.Unit(1.5778334140777588D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.60000002384185791D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.dT_DURSURESIDataTextBox.StyleName = "Data";
            this.dT_DURSURESIDataTextBox.Value = "=Fields.DT_DURSURESI";
            // 
            // dT_ROLANTDataTextBox
            // 
            this.dT_ROLANTDataTextBox.CanGrow = true;
            this.dT_ROLANTDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(new Telerik.Reporting.Drawing.Unit(17.991167068481445D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.052916664630174637D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.dT_ROLANTDataTextBox.Name = "dT_ROLANTDataTextBox";
            this.dT_ROLANTDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(new Telerik.Reporting.Drawing.Unit(1.5778334140777588D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.60000002384185791D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.dT_ROLANTDataTextBox.StyleName = "Data";
            this.dT_ROLANTDataTextBox.Value = "=Fields.DT_ROLANT";
            // 
            // dT_RLNBASTARDataTextBox
            // 
            this.dT_RLNBASTARDataTextBox.CanGrow = true;
            this.dT_RLNBASTARDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(new Telerik.Reporting.Drawing.Unit(19.621917724609375D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.052916664630174637D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.dT_RLNBASTARDataTextBox.Name = "dT_RLNBASTARDataTextBox";
            this.dT_RLNBASTARDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(new Telerik.Reporting.Drawing.Unit(1.5778334140777588D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.60000002384185791D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.dT_RLNBASTARDataTextBox.StyleName = "Data";
            this.dT_RLNBASTARDataTextBox.Value = "=Fields.DT_RLNBASTAR";
            // 
            // dT_RLNBITTARDataTextBox
            // 
            this.dT_RLNBITTARDataTextBox.CanGrow = true;
            this.dT_RLNBITTARDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(new Telerik.Reporting.Drawing.Unit(21.252666473388672D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.052916664630174637D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.dT_RLNBITTARDataTextBox.Name = "dT_RLNBITTARDataTextBox";
            this.dT_RLNBITTARDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(new Telerik.Reporting.Drawing.Unit(1.5778334140777588D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.60000002384185791D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.dT_RLNBITTARDataTextBox.StyleName = "Data";
            this.dT_RLNBITTARDataTextBox.Value = "=Fields.DT_RLNBITTAR";
            // 
            // dT_RLNSURESIDataTextBox
            // 
            this.dT_RLNSURESIDataTextBox.CanGrow = true;
            this.dT_RLNSURESIDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(new Telerik.Reporting.Drawing.Unit(22.8834171295166D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.052916664630174637D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.dT_RLNSURESIDataTextBox.Name = "dT_RLNSURESIDataTextBox";
            this.dT_RLNSURESIDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(new Telerik.Reporting.Drawing.Unit(1.5778334140777588D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.60000002384185791D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.dT_RLNSURESIDataTextBox.StyleName = "Data";
            this.dT_RLNSURESIDataTextBox.Value = "=Fields.DT_RLNSURESI";
            // 
            // Report2
            // 
            this.DataSource = this.sqlDataSource1;
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
            this.Style.BackgroundColor = System.Drawing.Color.White;
            styleRule1.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.StyleSelector("Title")});
            styleRule1.Style.Color = System.Drawing.Color.Black;
            styleRule1.Style.Font.Bold = true;
            styleRule1.Style.Font.Italic = false;
            styleRule1.Style.Font.Name = "Tahoma";
            styleRule1.Style.Font.Size = new Telerik.Reporting.Drawing.Unit(20D, Telerik.Reporting.Drawing.UnitType.Point);
            styleRule1.Style.Font.Strikeout = false;
            styleRule1.Style.Font.Underline = false;
            styleRule2.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.StyleSelector("Caption")});
            styleRule2.Style.Color = System.Drawing.Color.Black;
            styleRule2.Style.Font.Name = "Tahoma";
            styleRule2.Style.Font.Size = new Telerik.Reporting.Drawing.Unit(11D, Telerik.Reporting.Drawing.UnitType.Point);
            styleRule2.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            styleRule3.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.StyleSelector("Data")});
            styleRule3.Style.Font.Name = "Tahoma";
            styleRule3.Style.Font.Size = new Telerik.Reporting.Drawing.Unit(11D, Telerik.Reporting.Drawing.UnitType.Point);
            styleRule3.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            styleRule4.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.StyleSelector("PageInfo")});
            styleRule4.Style.Font.Name = "Tahoma";
            styleRule4.Style.Font.Size = new Telerik.Reporting.Drawing.Unit(11D, Telerik.Reporting.Drawing.UnitType.Point);
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

        private Telerik.Reporting.SqlDataSource sqlDataSource1;
        private Telerik.Reporting.GroupHeaderSection labelsGroupHeader;
        private Telerik.Reporting.TextBox aRC_SER1NOCaptionTextBox;
        private Telerik.Reporting.TextBox dT_ENLEMCaptionTextBox;
        private Telerik.Reporting.TextBox dT_BOYLAMCaptionTextBox;
        private Telerik.Reporting.TextBox dT_TAR1HCaptionTextBox;
        private Telerik.Reporting.TextBox dT_H1ZCaptionTextBox;
        private Telerik.Reporting.TextBox dT_KONTAKCaptionTextBox;
        private Telerik.Reporting.TextBox dT_ADRESCaptionTextBox;
        private Telerik.Reporting.TextBox dT_DURAKLAMACaptionTextBox;
        private Telerik.Reporting.TextBox dT_DURBASTARCaptionTextBox;
        private Telerik.Reporting.TextBox dT_DURBITTARCaptionTextBox;
        private Telerik.Reporting.TextBox dT_DURSURESICaptionTextBox;
        private Telerik.Reporting.TextBox dT_ROLANTCaptionTextBox;
        private Telerik.Reporting.TextBox dT_RLNBASTARCaptionTextBox;
        private Telerik.Reporting.TextBox dT_RLNBITTARCaptionTextBox;
        private Telerik.Reporting.TextBox dT_RLNSURESICaptionTextBox;
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
        private Telerik.Reporting.TextBox dT_ENLEMDataTextBox;
        private Telerik.Reporting.TextBox dT_BOYLAMDataTextBox;
        private Telerik.Reporting.TextBox dT_TAR1HDataTextBox;
        private Telerik.Reporting.TextBox dT_H1ZDataTextBox;
        private Telerik.Reporting.TextBox dT_KONTAKDataTextBox;
        private Telerik.Reporting.TextBox dT_ADRESDataTextBox;
        private Telerik.Reporting.TextBox dT_DURAKLAMADataTextBox;
        private Telerik.Reporting.TextBox dT_DURBASTARDataTextBox;
        private Telerik.Reporting.TextBox dT_DURBITTARDataTextBox;
        private Telerik.Reporting.TextBox dT_DURSURESIDataTextBox;
        private Telerik.Reporting.TextBox dT_ROLANTDataTextBox;
        private Telerik.Reporting.TextBox dT_RLNBASTARDataTextBox;
        private Telerik.Reporting.TextBox dT_RLNBITTARDataTextBox;
        private Telerik.Reporting.TextBox dT_RLNSURESIDataTextBox;
    }
}