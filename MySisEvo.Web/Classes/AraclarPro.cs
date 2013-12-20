using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using MySisEvo.Web.Classes;
using System.Data;
using System.Data.SqlClient;

namespace MySisEvo.Web.Classes
{
    public class AraclarPro
    {

        ObservableCollection<Araclar> arcList = null;
        private DataSet Eds;

        public ObservableCollection<Araclar> getAraclarList(int frmId)
        {
            
            ObservableCollection<Araclar> arcList = new ObservableCollection<Araclar>();
            //string sorgu="SELECT bayifirma.bayia AS bayii, bayifirma.firma AS firma, cihazlar.cihazad AS cihaz, cihazlar.serino AS serino, cihazlar.model AS model FROM bayifirma INNER JOIN cihazlar ON bayifirma.firma = cihazlar.firma where  bayifirma.bayia='"+kulAd+"' and cihazlar.port=17817 order by bayifirma.firma";
            string sorgu = "SELECT * FROM bayifirma INNER JOIN ATS_ARACLAR ON bayifirma.serino = CONVERT(VARCHAR, ATS_ARACLAR.ARC_SER1NO) where  bayifirma.bayia='ender'";
            //string sorgu = "SELECT * FROM ATS_ARACLAR WHERE FRM_1D=" + frmId.ToString();
            Eds = SqlHelper.DataBasePro(sorgu);
            arcList = getAraclarList(Eds);
            return arcList;
        }
        public ObservableCollection<Araclar> getAraclarList(string kulAd)
        {

            ObservableCollection<Araclar> arcList = new ObservableCollection<Araclar>();
            //string sorgu="SELECT bayifirma.bayia AS bayii, bayifirma.firma AS firma, cihazlar.cihazad AS cihaz, cihazlar.serino AS serino, cihazlar.model AS model FROM bayifirma INNER JOIN cihazlar ON bayifirma.firma = cihazlar.firma where  bayifirma.bayia='"+kulAd+"' and cihazlar.port=17817 order by bayifirma.firma";
            string sorgu = "SELECT * FROM bayifirma INNER JOIN ATS_ARACLAR ON bayifirma.serino = CONVERT(VARCHAR, ATS_ARACLAR.ARC_SER1NO) where  bayifirma.bayia='" + kulAd + "'";
            //string sorgu = "SELECT * FROM ATS_ARACLAR WHERE FRM_1D=" + frmId.ToString();
            Eds = SqlHelper.DataBasePro(sorgu);
            arcList = getAraclarList(Eds);
            return arcList;
        }
        public ObservableCollection<Araclar> getAraclarList(DataSet ds)
        {
            if (ds.Tables.Count != 0)
            {
                arcList = new ObservableCollection<Araclar>();
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    Araclar arc = new Araclar();
                    arc.ARC_ID = int.Parse(ds.Tables[0].Rows[i]["ARC_1D"].ToString());
                    arc.ARC_SERINO = int.Parse(ds.Tables[0].Rows[i]["ARC_SER1NO"].ToString());
                    arc.ARC_SAHIBI = ds.Tables[0].Rows[i]["ARC_SAH1B1"].ToString();
                    arc.ARC_CINS = ds.Tables[0].Rows[i]["ARC_C1NS"].ToString();
                    arc.ARC_MARKA = ds.Tables[0].Rows[i]["ARC_MARKA"].ToString();
                    arc.ARC_MODEL = ds.Tables[0].Rows[i]["ARC_MODEL"].ToString();
                    arc.ARC_PLAKA = ds.Tables[0].Rows[i]["ARC_PLAKA"].ToString();
                    arc.ARC_RENK = ds.Tables[0].Rows[i]["ARC_RENK"].ToString();
                    arc.ARC_SASINO = ds.Tables[0].Rows[i]["ARC_SAS1NO"].ToString();
                    arc.ARC_TEL = ds.Tables[0].Rows[i]["ARC_TEL"].ToString();
                    arc.ARC_RES1M = ds.Tables[0].Rows[i]["ARC_RES1M"].ToString();
                    arc.ARC_ICON = ds.Tables[0].Rows[i]["ARC_1CON"].ToString();
                    arc.CHZ_ID = int.Parse(ds.Tables[0].Rows[i]["CHZ_1D"].ToString());
                    arc.FRM_ID = int.Parse(ds.Tables[0].Rows[i]["FRM_1D"].ToString());
                    arc.GRP_ID = int.Parse(ds.Tables[0].Rows[i]["GRP_1D"].ToString());
                    arc.ARC_KONTAK = "Collapsed";
                    arcList.Add(arc);
                }
            }
            return arcList;
        }
        public void updateArac(Araclar arac)
        {
            string sorgu = "UPDATE ATS_ARACLAR SET ARC_SAH1B1=@P0,ARC_MARKA=@P1,ARC_MODEL=@P2,ARC_C1NS=@P3,ARC_RENK=@P4,ARC_1CON=@P5,ARC_PLAKA=@P6,ARC_TEL=@P7,ARC_SER1NO=@P8,ARC_SAS1NO=@P9,ARC_RES1M=@P11 WHERE ARC_1D=@P10";
            SqlParameter [] prm=new SqlParameter[12];
            prm[0] = new SqlParameter("P0", arac.ARC_SAHIBI);
            prm[1] = new SqlParameter("P1", arac.ARC_MARKA);
            prm[2] = new SqlParameter("P2", arac.ARC_MODEL);
            prm[3] = new SqlParameter("P3", arac.ARC_CINS);
            prm[4] = new SqlParameter("P4", arac.ARC_RENK);
            prm[5] = new SqlParameter("P5", arac.ARC_ICON);
            prm[6] = new SqlParameter("P6", arac.ARC_PLAKA);
            prm[7] = new SqlParameter("P7", arac.ARC_TEL);
            prm[8] = new SqlParameter("P8", arac.ARC_SERINO);
            prm[9] = new SqlParameter("P9", arac.ARC_SASINO);
            prm[10] = new SqlParameter("P10", arac.ARC_ID);
            prm[11] = new SqlParameter("P11", arac.ARC_RES1M);
            SqlHelper.ExecuteNonQuery(SqlHelper.ConnStr, CommandType.Text, sorgu,prm);
        }
    }
}