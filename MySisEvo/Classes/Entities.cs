using System;
using System.Net;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using MySisEvo.DATA_SR;
using System.ComponentModel;

namespace MySisEvo.Classes
{
    public class Entities
    {
        public static DataServisClient data_sr = new DataServisClient();
        public static Kullanici Kullanici { get; set; }
        public static ObservableCollection<Araclar> AraclarList { get; set; }
        public static Araclar Arac { get; set; }
        public static ObservableCollection<Datas> DatasList { get; set; }
        public static ObservableCollection<Datas> DatasYol { get; set; }
        public static Datas Data {get;set;}
        public static ObservableCollection<AracData> AracDataList { get; set; }
        public static ObservableCollection<Adres> AdresList1 { get; set; }
        public static ObservableCollection<Alarmlar> Alarmlarim { get; set; }
        
        public static ObservableCollection<ImageSource> AracIconList { get; set; }
        public static ImageSource AracIcon { get; set; }

        public static Visibility DetayGridVisible { get; set; }

        public static GecmisYol GecmisYollar;
        public static String Serinolar;
        public static Boolean MultiArcSec = false;
        public static int ArcSecSay = 0;
        public static int SeciliArcIndex = 0;
        public static Araclar getArac(string plaka)
        {
            Araclar arc = new Araclar();
            for (int i = 0; i < AraclarList.Count; i++)
            {
                if (AraclarList[i].ARC_PLAKA == plaka)
                {
                    arc = AraclarList[i];
                    break;
                }
            }
                return arc;
        }
        public static Araclar getArac(int serino)
        {
            Araclar arc = new Araclar();
            for (int i = 0; i < AraclarList.Count; i++)
            {
                if (AraclarList[i].ARC_SERINO == serino)
                {
                    arc = AraclarList[i];
                    break;
                }
            }
            return arc;
        }

        public static int getArcListIndex(int serino)
        {
            int index=-1;
            for (int i = 0; i < AraclarList.Count; i++)
            {
                if (AraclarList[i].ARC_SERINO == serino)
                {
                    index=i;
                    break;
                }
            }
            return index;
        }
     
    }
}
