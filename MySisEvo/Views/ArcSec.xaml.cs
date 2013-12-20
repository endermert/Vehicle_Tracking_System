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
using Telerik.Windows.Controls;
using MySisEvo.Classes;

namespace MySisEvo.Views
{
    public partial class ArcSec : RadWindow

    {
        public ArcSec()
        {
            InitializeComponent();
            
        }

        private void RadWindow_Loaded(object sender, RoutedEventArgs e)
        {
            coverFlow.ItemsSource = Entities.AraclarList;
            ArcSeclistBox1.ItemsSource = null;
            if (Entities.MultiArcSec == true)
            {
                Entities.ArcSecSay = 0;
                btnHSec.IsEnabled = true;
            }
            else
                btnHSec.IsEnabled = false;

            ArcSeclistBox1.ItemsSource = Entities.AracDataList;
            ArcSeclistBox1.SelectedIndex = Entities.SeciliArcIndex;
        }

        private void ArcSeclistBox1_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (ArcSeclistBox1.SelectedIndex != coverFlow.SelectedIndex)
                coverFlow.SelectedIndex = ArcSeclistBox1.SelectedIndex;

            if (ArcSeclistBox1.SelectedIndex != -1)
            {
                txtmarka.Text = Entities.AracDataList[ArcSeclistBox1.SelectedIndex].Arac.ARC_MARKA;
                txtModel.Text = Entities.AracDataList[ArcSeclistBox1.SelectedIndex].Arac.ARC_MODEL;
                txtSahibi.Text = Entities.AracDataList[ArcSeclistBox1.SelectedIndex].Arac.ARC_SAHIBI;
            }
        }

        private void coverFlow_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (ArcSeclistBox1.SelectedIndex!=coverFlow.SelectedIndex)
                ArcSeclistBox1.SelectedIndex=coverFlow.SelectedIndex;
        }

        private CheckBox lastcheck = null;
        private void ArcSec_Checked(object sender, RoutedEventArgs e)
        {
            string sn = ((CheckBox)sender).Tag.ToString();
            int index = Entities.getArcListIndex(int.Parse(sn));

            if (Entities.MultiArcSec == false)
            {
                for (int i = 0; i < Entities.AracDataList.Count; i++)
                {
                    Entities.AracDataList[i].Secili = false;
                    
                }

                Entities.Serinolar = Entities.Serinolar = "";
                Entities.ArcSecSay = 0;

                if (lastcheck != null && lastcheck != ((CheckBox)sender))
                    lastcheck.IsChecked = false;

            }

            lastcheck = ((CheckBox)sender);
            if (((CheckBox)sender).IsChecked == true)
            {
                Entities.AracDataList[index].Secili = true;
                Entities.Serinolar = Entities.Serinolar + sn + ";";
                Entities.ArcSecSay++;
            }
            else
            {
                Entities.AracDataList[index].Secili = false;
                Entities.Serinolar = Entities.Serinolar.Replace(sn+";","");
                if (Entities.MultiArcSec == true)
                    Entities.ArcSecSay--;
            }
        }

        private void btnHSec_Click(object sender, RoutedEventArgs e)
        {
            if (Entities.MultiArcSec == true && Entities.ArcSecSay <Entities.AracDataList.Count)
            {
                Entities.ArcSecSay = 0;
                Entities.Serinolar = "";
                for (int i = 0; i < Entities.AracDataList.Count; i++)
                {
                    Entities.AracDataList[i].Secili = true;
                }
                ArcSeclistBox1.ItemsSource = null;
                ArcSeclistBox1.ItemsSource = Entities.AracDataList;
            }
            else
                MessageBox.Show("Bir sonraki adým için sadece bir arac seçebilirsiniz!","Dikkat",MessageBoxButton.OK);
        }

        private void btnHTem_Click(object sender, RoutedEventArgs e)
        {
            SecimTemizle();
        }

        void SecimTemizle()
        {
            for (int i = 0; i < Entities.AracDataList.Count; i++)
            {
                Entities.AracDataList[i].Secili = false;
            }
            ArcSeclistBox1.ItemsSource = null;
            Entities.Serinolar = Entities.Serinolar = "";
            ArcSeclistBox1.ItemsSource = Entities.AracDataList;
            Entities.ArcSecSay = 0;
        }
        private void btnOKSec_Click(object sender, RoutedEventArgs e)
        {
            Entities.MultiArcSec = false;
            this.Close();
        }
       
    }
}