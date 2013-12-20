using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Windows.Navigation;
using Telerik.ReportViewer.Silverlight;
using MySisEvo.Classes;

namespace MySisEvo
{
    public partial class RaporPage : Page
    {

        
        public RaporPage()
        {
            InitializeComponent();

            this.ReportViewer1.RenderBegin += new RenderBeginEventHandler(ReportViewer1_RenderBegin);
        }

        void ReportViewer1_RenderBegin(object sender, RenderBeginEventArgs args)
        {
            args.ParameterValues["kulAd"] = Entities.Kullanici.KUL_AD;
            args.ParameterValues["kulPass"] = Entities.Kullanici.KUL_SIFRE;
        }
        
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void RadButton_Click(object sender, RoutedEventArgs e)
        {
            ReportViewer1.Report = null;
            ReportViewer1.Report = "MySisRapor.Report1,MySisRapor";
        }

       

    }
}
