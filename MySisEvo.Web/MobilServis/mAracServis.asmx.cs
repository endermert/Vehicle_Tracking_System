using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Collections.ObjectModel;
using MySisEvo.Web.Classes;

namespace MySisEvo.Web.MobilServis
{
    /// <summary>
    /// Summary description for mAracServis
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]

    public class mAracServis : System.Web.Services.WebService
    {
        AraclarPro AraclarPro = new AraclarPro();
        [WebMethod]
        public ObservableCollection<Araclar> getAraclar(string kulAd)
        {
            ObservableCollection<Araclar> arcList = new ObservableCollection<Araclar>();
            arcList = AraclarPro.getAraclarList(kulAd);
            return arcList;
        }
        [WebMethod]
        public void updateArac(Araclar arac)
        {
            AraclarPro.updateArac(arac);
        }


    }
}
