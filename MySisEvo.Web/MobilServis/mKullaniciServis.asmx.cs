using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using MySisEvo.Web.Classes;

namespace MySisEvo.Web.MobilServis
{
    /// <summary>
    /// Summary description for mKullaniciServis
    /// </summary>
    [WebService(Namespace = "http://mysismobile.com/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class mKullaniciServis : System.Web.Services.WebService
    {
        public Kullanici kul= new Kullanici();
        public KullaniciPro kulPro =new KullaniciPro();

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public Kullanici getKullanici(string kulAd, string kulSifre)
        {
            kul = kulPro.getKullanici(kulAd, kulSifre);
            return kul;
        }
    }
}
