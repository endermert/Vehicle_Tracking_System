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

namespace MySisEvo.Classes
{
    public class Adres
    {
        public int ADR_ID { get; set; }
        public string ADR_ADRES { get; set; }
        public string ADR_ULKE { get; set; }
        public string ADR_IL { get; set; }
        public string ADR_ILCE { get; set; }
        public string ADR_SEMT { get; set; }
        public string ADR_CAD { get; set; }
        public string ADR_BASLIK { get; set; }
        public string ADR_ACIKLAMA { get; set; }
        public Location ADR_LOCATION { get; set; }
    }
}
