using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Telerik.Windows.Controls.Map;
using System.Collections.Generic;
using System.Windows.Threading;
using MySisEvo.DATA_SR;
using MySisEvo.Classes;
using System.Windows.Media.Imaging;
using System.Collections.ObjectModel;

namespace MySisEvo.Controls
{
    public class ClientIslem
    {
        public static Boolean LoginIn = false;
        public static BingRouteProvider routeProvider;
        public static LocationCollection routePoints = new LocationCollection();
        public static BingGeocodeProvider geoProvider;
        public static BingSearchProvider searchProvider;

        public static List<int> dtYolindex = new List<int>();
        public static int dtYolIndex = -1;
        public static int dtIlkYol = -1;
        
        public static int geoIndex = -1;
        public static List<int> geoIndexList = new List<int>();
        public static Boolean geoDurum = true;

        public static BingRouteProvider yolAniProvider;
        public static LocationCollection yolAniPoints = new LocationCollection();
        public static LocationCollection yolPoints = new LocationCollection();
        public static LocationCollection rotaPoints = new LocationCollection();

        public static MapPolyline hamYol = new MapPolyline();
        public static MapPolyline calYol = new MapPolyline();
        public static ObservableCollection<Datas> aniDataList = new ObservableCollection<Datas>();

        public static MapPolyline yolLine = new MapPolyline();
        public static LocationRect rect1=new LocationRect();
      

        public static void yolBul(Location location)
        {            
            ClientIslem.dtYolIndex++;
            RouteRequest routeRequest = new RouteRequest();
            routeRequest.Culture = new System.Globalization.CultureInfo("en-US");
            routeRequest.Options.RoutePathType = RoutePathType.Points;
            
            routeRequest.Waypoints.Add(location);
            routeRequest.Waypoints.Add(location);
            routeProvider.CalculateRouteAsync(routeRequest);            
        }

        public static void yolIstek (LocationCollection locations)
        {

            RouteRequest routeRequest = new RouteRequest();
            routeRequest.Culture = new System.Globalization.CultureInfo("en-US");
            routeRequest.Options.RoutePathType = RoutePathType.Points;
            for (int i = 0; i < locations.Count;i++)
            {
                routeRequest.Waypoints.Add(locations[i]);
            }
            yolAniProvider.CalculateRouteAsync(routeRequest);
        }
        public static void setAracImages()
        {
            Entities.AracIconList = new System.Collections.ObjectModel.ObservableCollection<ImageSource>();
            Entities.AracIconList.Add(new BitmapImage(new Uri("/MySisEvo;component/Images/Cars/ww1_40x27.png", UriKind.Relative)));
            Entities.AracIconList.Add(new BitmapImage(new Uri("/MySisEvo;component/Images/Cars/ww2_40x27.png", UriKind.Relative)));
            Entities.AracIconList.Add(new BitmapImage(new Uri("/MySisEvo;component/Images/Cars/camaro_65x27.png", UriKind.Relative)));
            Entities.AracIconList.Add(new BitmapImage(new Uri("/MySisEvo;component/Images/Cars/ferrari_77x27.png", UriKind.Relative)));
            Entities.AracIconList.Add(new BitmapImage(new Uri("/MySisEvo;component/Images/Cars/bmw_43x27.png", UriKind.Relative)));
            Entities.AracIconList.Add(new BitmapImage(new Uri("/MySisEvo;component/Images/Cars/chev_52x27.png", UriKind.Relative)));
            Entities.AracIconList.Add(new BitmapImage(new Uri("/MySisEvo;component/Images/Cars/7.png", UriKind.Relative)));
            Entities.AracIconList.Add(new BitmapImage(new Uri("/MySisEvo;component/Images/Cars/8.png", UriKind.Relative)));
            Entities.AracIconList.Add(new BitmapImage(new Uri("/MySisEvo;component/Images/Cars/9.png", UriKind.Relative)));
            Entities.AracIconList.Add(new BitmapImage(new Uri("/MySisEvo;component/Images/Cars/10.png", UriKind.Relative)));
            Entities.AracIconList.Add(new BitmapImage(new Uri("/MySisEvo;component/Images/Cars/11.png", UriKind.Relative)));
            Entities.AracIconList.Add(new BitmapImage(new Uri("/MySisEvo;component/Images/Cars/12.png", UriKind.Relative)));
            Entities.AracIconList.Add(new BitmapImage(new Uri("/MySisEvo;component/Images/Cars/13.png", UriKind.Relative)));
            Entities.AracIconList.Add(new BitmapImage(new Uri("/MySisEvo;component/Images/Cars/14.png", UriKind.Relative)));
            Entities.AracIconList.Add(new BitmapImage(new Uri("/MySisEvo;component/Images/Cars/15.png", UriKind.Relative)));

            for (int i=0;i<Entities.AracDataList.Count;i++)
            {
                Entities.AracDataList[i].AracIcon=Entities.AracIconList[int.Parse(Entities.AracDataList[i].Arac.ARC_ICON)];
            }
        }
        public static void initVariable(string vName)
        {
            if (vName == "GecmisYollar")
            {
                Entities.GecmisYollar = new GecmisYol();
                Entities.GecmisYollar.DataList = new ObservableCollection<ObservableCollection<Datas>>();
                Entities.GecmisYollar.CalYol = new ObservableCollection<MapPolyline>();
                Entities.GecmisYollar.HamYol = new ObservableCollection<MapPolyline>();
                Entities.GecmisYollar.AracData = new ObservableCollection<AracData>();
            }
        }

        

        public static void SetBestView()
        {

            Location loc1 = new Location(40.000, 32.000);
            Location loc2 = new Location(40.000, 32.000);
            for (int i = 0; i < Entities.AracDataList.Count; i++)
            {
                double en = Double.Parse(Entities.AracDataList[i].Data.DT_ENLEM);
                double boy = Double.Parse(Entities.AracDataList[i].Data.DT_BOYLAM);
                Location loc = new Location(en, boy);
                if (i == 0)
                {
                    loc1 = loc;
                    loc2 = loc;
                }
                if (loc.Latitude < loc1.Latitude || loc.Longitude > loc1.Longitude)
                    loc1 = loc;

                if (loc.Latitude > loc2.Latitude || loc.Longitude < loc2.Longitude)
                    loc2 = loc;

                //if (loc1.Latitude > loc.Latitude)
                //    loc1.Latitude = loc.Latitude;
                //if (loc.Longitude > loc1.Longitude)
                //    loc1.Longitude = loc.Longitude;
                //if (loc.Latitude > loc2.Latitude)
                //    loc2.Latitude = loc.Latitude;
                //if (loc.Longitude < loc2.Longitude)
                //    loc2.Longitude = loc.Longitude;

            }
            rect1 = new LocationRect(loc1, loc2);
        }

    }
}
