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
using System.Windows.Navigation;
using System.Windows.Shapes;
using MySisEvo.DATA_SR;
using System.ServiceModel;
using MySisEvo.Classes;
using MySisEvo.Controls;
using System.Net.Sockets;
using System.Text;
using Telerik.Windows.Controls.Map;
using System.Windows.Threading;

namespace MySisEvo
{
    public partial class LoginPage : UserControl
    {
        private SocketAsyncEventArgs MyAsenkronOlay;
        private string gelen;
        private byte[] ServerData;
        public delegate void SetCallBack(string Textim);
        public static string[,] mesaj = new string[10, 10];

        
        public LoginPage()
        {
            InitializeComponent();
            //loginBusy.IsBusy = true;
        }

        DispatcherTimer conControl = new DispatcherTimer();

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            Entities.DatasList = new System.Collections.ObjectModel.ObservableCollection<Datas>();
            Entities.DatasYol = new System.Collections.ObjectModel.ObservableCollection<Datas>();
            Entities.AracDataList = new System.Collections.ObjectModel.ObservableCollection<AracData>();

            MapLink.Visibility = Visibility.Collapsed;
            LoginLink.Visibility = Visibility.Visible;
            DiagnostikLink.Visibility = Visibility.Collapsed;
            RaporPageLink.Visibility = Visibility.Collapsed;
            HakkindaLink.Visibility = Visibility.Collapsed;
            TanimLink.Visibility = Visibility.Collapsed;

            Entities.data_sr.getKullaniciCompleted += new EventHandler<getKullaniciCompletedEventArgs>(kul_sr_getKullaniciCompleted);
            Entities.data_sr.getAraclarCompleted += new EventHandler<getAraclarCompletedEventArgs>(arc_sr_getAraclarCompleted);
            Entities.data_sr.getDataCompleted += new EventHandler<getDataCompletedEventArgs>(data_sr_getDataCompleted);
            Entities.data_sr.getDatasCompleted += new EventHandler<getDatasCompletedEventArgs>(data_sr_getDatasCompleted);

            MyAsenkronOlay = new SocketAsyncEventArgs();

            MyAsenkronOlay.RemoteEndPoint = SocketIslemler.MyEndPoint;
            MyAsenkronOlay.Completed += new EventHandler<SocketAsyncEventArgs>(MyAsenkronOlay_Completed);

            SocketIslemler.MysisSocket.ConnectAsync(MyAsenkronOlay);

            
            conControl.Interval = TimeSpan.FromSeconds(300);
            conControl.Tick += new EventHandler(conControl_Tick);

            if (ClientIslem.LoginIn == false)
            {
                ContentFrame.Navigate(new Uri("Home", UriKind.Relative));
            }

            ClientIslem.setAracImages();
        }

       

        

        void data_sr_getDataCompleted (object sender,getDataCompletedEventArgs e)
        {
            if (e.Result != null)
            {
                //Entities.DatasList.Add(e.Result);
                for (int i = 0; i < Entities.AraclarList.Count; i++)
                {
                    if (Entities.AraclarList[i].ARC_SERINO == e.Result.ARC_SER1NO)
                    {
                        Entities.DatasList[i] = e.Result;
                        Entities.DatasYol[i] = e.Result;
                        Entities.AracDataList[i].Data = e.Result;
                        string kontaki = "Collapsed";
                        if (Entities.AracDataList[i].Data.DT_KONTAK=="Kapalý")
                            kontaki = "Collapsed";
                        else
                            kontaki = "Visible";
                        Entities.AraclarList[i].ARC_KONTAK = kontaki;
                        ClientIslem.geoIndexList.Add(i);
                    }
                }
            }
            else
            {
                Entities.DatasList.Add(new Datas());
                Entities.DatasYol.Add(new Datas());
            }
        }

        void data_sr_getDatasCompleted(object sender, getDatasCompletedEventArgs e)
        {
            if (e.Result != null)
            {
                //Entities.DatasList.Add(e.Result);
                Entities.DatasList = e.Result;
                Entities.DatasYol= e.Result;

                for (int i = 0; i < Entities.AraclarList.Count; i++)
                {
                    Entities.AracDataList[i].Data = e.Result[i];
                     ClientIslem.geoIndexList.Add(i);

                     string kontaki = "Collapsed";
                     if (e.Result[i].DT_KONTAK == "Kapalý")
                     {
                         kontaki = "Collapsed";
                         Entities.AracDataList[i].Data.DT_H1Z = "0";
                     }
                     else
                         kontaki = "Visible";
                     Entities.AraclarList[i].ARC_KONTAK = kontaki;
                }
                ClientIslem.SetBestView();
            }
           
            loginBusy.IsBusy = false;

        }

        void MyAsenkronOlay_Completed(object sender, SocketAsyncEventArgs e)
        {
            SocketIslemler.MysisSocketOlay = new SocketAsyncEventArgs();
            SocketIslemler.MysisSocketOlay.RemoteEndPoint = SocketIslemler.MyEndPoint;
            e.Completed -= new EventHandler<SocketAsyncEventArgs>(MyAsenkronOlay_Completed);
            e.Completed += new EventHandler<SocketAsyncEventArgs>(Veriyi_Al);
            ServerData = new byte[5000];
            e.SetBuffer(ServerData, 0, ServerData.Length);
            SocketIslemler.MysisSocket.ReceiveAsync(e);
        }

        void Veriyi_Al(object sender, SocketAsyncEventArgs e)
        {
            gelen = Encoding.UTF8.GetString(ServerData, e.Offset, e.BytesTransferred);
            SetText(gelen);
            SocketIslemler.MysisSocket.ReceiveAsync(e);

        }

        void SetText(string Data)
        {
            this.Dispatcher.BeginInvoke(new SetCallBack(TextboxGuncelle), Data);
        }

        void TextboxGuncelle(string Datam)
        {
            string gelen = Datam;
            try
            {
                
                string strbas = "<SRV>";
                string strson = "</SRV>";

                //ôôô
                if (gelen.IndexOf(strbas) != -1)
                {
                    gelen = gelen.Substring(gelen.IndexOf(strbas));
                }

                string metin = gelen;

                while (metin.Length>0)
                {

                    if (metin.IndexOf(strson) != -1)
                    {
                        string paket = metin.Substring(0, metin.IndexOf(strson)+strson.Length);
                        SrvIslemler.GelenGenelPro(paket);
                        metin = metin.Substring(metin.IndexOf(strson) + strson.Length);
                        if (metin.IndexOf(strbas) != -1)
                            metin = metin.Substring(metin.IndexOf(strbas));
                    }
                    else
                       metin = "";

                }


            }
            catch
            {

            }

        }

        void arc_sr_getAraclarCompleted(object sender, getAraclarCompletedEventArgs e)
        {
            Entities.AraclarList = e.Result;
            Entities.AracDataList = new System.Collections.ObjectModel.ObservableCollection<AracData>();
            SrvIslemler.DataIstek();
            loginBusy.BusyContent = "Veriler Yükleniyor.";
            
        }
        void kul_sr_getKullaniciCompleted(object sender, getKullaniciCompletedEventArgs e)
        {
            if (e.Result == null)
            {
                ClientIslem.LoginIn = false;
                LayoutRoot2.Visibility = Visibility.Visible;

                MapLink.Visibility = Visibility.Collapsed;
                RaporPageLink.Visibility = Visibility.Collapsed;

                LoginLink.Visibility = Visibility.Visible;
                TanimLink.Visibility = Visibility.Collapsed;

                DiagnostikLink.Visibility = Visibility.Collapsed;
                kulTxt.Text = "Kullanýcý Adý ya da Þifre Hatalý..";
                ContentFrame.Navigate(new Uri("Home", UriKind.Relative));
                

            }
            else
            {
                ClientIslem.LoginIn = true;
                //ServisIslemler.ses_sr.SetSessionValueAsync("kulAd",e.Result.KUL_AD);
                //ServisIslemler.ses_sr.SetSessionValueAsync("kulPass", e.Result.KUL_SIFRE);
                //ContentFrame.Navigate(new Uri("Home", UriKind.Relative));
                SrvIslemler.LoginGonder(textBox1.Text,passwordBox1.Password);
                LayoutRoot2.Visibility= Visibility.Collapsed;
                LoginLink.Visibility = Visibility.Collapsed;
                MapLink.Visibility = Visibility.Visible;
                RaporPageLink.Visibility = Visibility.Visible;
                TanimLink.Visibility = Visibility.Collapsed;//**
                Entities.Kullanici = e.Result;
                Entities.data_sr.getAraclarAsync(Entities.Kullanici.KUL_AD);
                //ContentFrame.Navigate(new Uri("MapPage", UriKind.Relative));
                ContentFrame.Navigate(MapLink.NavigateUri);
                loginBusy.BusyContent = "Araclar Yükleniyor..";
            }
        }
       
        private void hyperlinkButton1_Click(object sender, RoutedEventArgs e)
        {
            if (textBox1.Text.Trim().Length > 0 && passwordBox1.Password.Trim().Length > 0)
            {
                Entities.data_sr.getKullaniciAsync(textBox1.Text, passwordBox1.Password);
                LayoutRoot2.Visibility = Visibility.Collapsed;
                loginBusy.Visibility = Visibility.Visible;
                loginBusy.IsBusy = true;
                
                loginBusy.BusyContent = "Kullanýcý Yükleniyor..";
            }
        }

        // After the Frame navigates, ensure the HyperlinkButton representing the current page is selected
        private void ContentFrame_Navigated(object sender, NavigationEventArgs e)
        {
            foreach (UIElement child in LinksStackPanel.Children)
            {
                HyperlinkButton hb = child as HyperlinkButton;
                if (hb != null && hb.NavigateUri != null)
                {
                    if (ContentFrame.UriMapper.MapUri(e.Uri).ToString().Equals(ContentFrame.UriMapper.MapUri(hb.NavigateUri).ToString()))
                    {
                        VisualStateManager.GoToState(hb, "ActiveLink", true);
                    }
                    else
                    {
                        VisualStateManager.GoToState(hb, "InactiveLink", true);
                    }
                }
            }
        }

        // If an error occurs during navigation, show an error window
        private void ContentFrame_NavigationFailed(object sender, NavigationFailedEventArgs e)
        {
            e.Handled = true;
            ChildWindow errorWin = new ErrorWindow(e.Uri);
            errorWin.Show();
        }

        private void UserControl_MouseEnter(object sender, MouseEventArgs e)
        {
            conControl.Stop();   
        }

        private void UserControl_MouseLeave(object sender, MouseEventArgs e)
        {
            conControl.Start();
        }

        void conControl_Tick(object sender, EventArgs e)
        {
            try
            {
                SocketIslemler.MysisSocket.Shutdown(SocketShutdown.Both);
                MessageBox.Show("Sistem ile uzun süre etkileþim de bulunmadýðýnýz için oturumunuz sonlandýrýldý..", "Dikkat", MessageBoxButton.OK);
                System.Windows.Browser.HtmlPage.Document.Submit();
                //SocketIslemler.MysisSocketOlay = new SocketAsyncEventArgs();
                //SocketIslemler.MysisSocketOlay.Completed -= new EventHandler<SocketAsyncEventArgs>(Veriyi_Al);

                ////NavigationService ns = new NavigationService();

                ////this.ContentFrame.Navigate(new Uri("", UriKind.Relative));
                ////ContentFrame.Navigate(new Uri("", UriKind.Relative));

                //ClientIslem.LoginIn = false;
                //LayoutRoot2.Visibility = Visibility.Visible;

                //MapLink.Visibility = Visibility.Collapsed;
                //RaporPageLink.Visibility = Visibility.Collapsed;

                //LoginLink.Visibility = Visibility.Visible;
                //TanimLink.Visibility = Visibility.Collapsed;

                //DiagnostikLink.Visibility = Visibility.Collapsed;
                //kulTxt.Text = "";
                ////ContentFrame.Navigate(new Uri("", UriKind.Relative));
                //ContentFrame.Navigate(new Uri("Home", UriKind.Relative));
            }
            catch
            { 

            }
        }
       
    }
}