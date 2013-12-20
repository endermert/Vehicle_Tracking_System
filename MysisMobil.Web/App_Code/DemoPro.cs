using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySis;
using System.Data.SqlClient;
using System.Data;

public class DemoPro
{
	public DemoPro()
	{

	}
    public static void setDemoFrm(string tGsm, string tYetkili,string tKulAd, string tKulPass)
    {
        
        //string sorgu = "INSERT INTO ATS_DEMOFRM (DM_KULAD,DM_KULPASS,DM_TAR,DM_GSM,DM_YETK1L1,DM_EPOSTA,DM_ADRES,DM_F1RMA,DM_LOG1N1N) VALUES (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11);";
        string sorgu = "INSERT INTO ATS_DEMOFRM (DM_KULAD,DM_KULPASS,DM_TAR,DM_GSM) VALUES (@p1,@p2,@p3,@p4);";
        SqlParameter[] prm = new SqlParameter[4];

        prm[0] = new SqlParameter("p1", tKulAd);
        prm[1] = new SqlParameter("p2", tKulPass);
        prm[2] = new SqlParameter("p3", DateTime.Now.AddDays(1));
        prm[3] = new SqlParameter("p4", tGsm);
        SqlHelper.ExecuteNonQuery(SqlHelper.ConnStr, CommandType.Text, sorgu, prm);
    }
}