using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySisEvo.Web.Classes;
using System.Data;
using System.Data.SqlClient;

namespace MySisEvo.Web.Classes
{
    public class KullaniciPro
    {
        private Kullanici kullanici;
        private List<Kullanici> kullanicilar=null;
        private DataSet Eds;

        public Kullanici getKullanici(string kulad,string kulsifre)
        {
            if (getDemo(kulad, kulsifre))
            {
                setDemoLoginIn(kulad, kulsifre);
                kulad = "demo";
                kulsifre = "demo";
            }
            String sorgu = "select * from bayiler where kullaniciadi='"+kulad+"' and sifre='"+kulsifre+"' and aktif=1";

            kullanici = new Kullanici();
            Eds =SqlHelper.DataBasePro(sorgu);
            kullanici = getKullanici(Eds);

            return kullanici;
        }
        /*
        public DataSet DataBasePro(string sorgu)
        {
            DataSet ds = new DataSet();
            String ConnStr = System.Configuration.ConfigurationManager.ConnectionStrings["ConnStr"].ToString();
            ds = SqlHelper.ExecuteDataset(ConnStr,CommandType.Text,sorgu);
            return ds;
        }
         */
        public Kullanici getKullanici(DataSet ds)
        {
            Kullanici kul = null;
            if (ds.Tables.Count != 0)
            {
                if (ds.Tables[0].Rows.Count != 0)
                {
                    kul = new Kullanici();
                    kul.KUL_ID = int.Parse(ds.Tables[0].Rows[0][0].ToString());
                    kul.KUL_AD = ds.Tables[0].Rows[0]["kullaniciadi"].ToString();
                    kul.KUL_SIFRE = ds.Tables[0].Rows[0]["sifre"].ToString();
                    kul.FRM_1D = 1;
                }
            }
            return kul;
        }

        public List<Kullanici> getKullaniciList(DataSet ds)
        {
            if (ds.Tables.Count != 0)
            {
                kullanicilar = new List<Kullanici>();
                for (int i = 0; i < ds.Tables.Count; i++)
                {
                    kullanici = new Kullanici();
                    kullanici.KUL_ID = int.Parse(ds.Tables[0].Rows[i][0].ToString());
                    kullanici.KUL_AD = ds.Tables[0].Rows[i]["kullaniciadi"].ToString();
                    kullanici.KUL_SIFRE = ds.Tables[0].Rows[i]["sifre"].ToString();
                    kullanicilar.Add(kullanici);
                }
            }
            return kullanicilar;
        }

        public Boolean  getDemo(string kulad, string kulsifre)
        {
            DataSet dsDemo=new DataSet();
            String sorgu = "select * from ATS_DEMOFRM  where DM_KULAD='" + kulad + "' and DM_KULPASS='" + kulsifre + "' and (DM_TAR > '" + String.Format("{0:yyyy-MM-dd  HH:mm:ss}", DateTime.Now) + "')";
            dsDemo = SqlHelper.DataBasePro(sorgu);
            if (dsDemo.Tables[0].Rows.Count > 0)
                return true;
            else
                return false;
        }
        public void setDemoLoginIn(string kulad, string kulsifre)
        {
            String sorgu = "Update ATS_DEMOFRM set DM_LOG1N1N='1'  where DM_KULAD='" + kulad + "' and DM_KULPASS='" + kulsifre + "'";
            SqlHelper.ExecuteNonQuery(SqlHelper.ConnStr,CommandType.Text,sorgu);
         
        }
    }
}