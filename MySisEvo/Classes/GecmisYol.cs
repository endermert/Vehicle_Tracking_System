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
using System.Collections.ObjectModel;
using MySisEvo.DATA_SR;
using Telerik.Windows.Controls.Map;

namespace MySisEvo.Classes
{
    public class GecmisYol
    {
        public ObservableCollection<ObservableCollection<Datas>> DataList = new ObservableCollection<ObservableCollection<Datas>>();
        public ObservableCollection<MapPolyline> HamYol = new ObservableCollection<MapPolyline>();
        public ObservableCollection<MapPolyline> CalYol = new ObservableCollection<MapPolyline>();
        public ObservableCollection<AracData> AracData = new ObservableCollection<AracData>();
    }
}
