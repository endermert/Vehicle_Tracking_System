using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using MySisEvo.Web.Classes;
using System.Collections.ObjectModel;

namespace MySisEvo.Web.MobilServis
{
    /// <summary>
    /// Summary description for mDataServis
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class mDataServis : System.Web.Services.WebService
    {
        private DatasPro DataPro = new DatasPro();
        [WebMethod]
        public Datas getData(int serino)
        {
            Datas data1 = new Datas();
            data1 = DataPro.getData(serino);

            return data1;
        }

        [WebMethod]
        public ObservableCollection<Datas> getDatas(List<String> serinolar)
        {
            ObservableCollection<Datas> data1 = new ObservableCollection<Datas>();
            data1 = DataPro.getData(serinolar);
            return data1;
        }


        [WebMethod]
        public ObservableCollection<Datas> getDataList(int serino, DateTime basTar, DateTime bitTar)
        {
            ObservableCollection<Datas> data1 = new ObservableCollection<Datas>();
            data1 = DataPro.getData(serino, basTar, bitTar);
            return data1;
        }
    }
}
