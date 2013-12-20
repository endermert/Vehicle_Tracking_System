using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySis;
using System.Data.SqlClient;
using System.Data;
/// <summary>
/// Summary description for DealersPro
/// </summary>
public class DealersPro
{
    public DealersPro()
	{

	}
    public static Boolean DealersKayit(string til,string tilce,string tunvan,string tIsim,string tadres,string ttel,string tfax,string tgsm, string tPosta)
    {
        
        int cvp = 0;
        string sorgu = "INSERT INTO ATS_BAY1FRM (BAY_1L,BAY_1LCE,BAY_UNVAN,BAY_YETK1L1,BAY_ADRES,BAY_GMS,BAY_TEL,BAY_FAX,BAY_EPOSTA,BAY_DURUM,BAY_TAR) VALUES (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11);";
        SqlParameter[] prm = new SqlParameter[11];
        
        prm[0] = new SqlParameter("p1", til);
        prm[1] = new SqlParameter("p2", tilce );
        prm[2] = new SqlParameter("p3", tunvan);
        prm[3] = new SqlParameter("p4", tIsim);
        prm[4] = new SqlParameter("p5", tadres);
        prm[5] = new SqlParameter("p6", tgsm);
        prm[6] = new SqlParameter("p7", ttel);
        prm[7] = new SqlParameter("p8", tfax);
        prm[8] = new SqlParameter("p9", tPosta);
        prm[9] = new SqlParameter("p10", "incelemede");
        prm[10] = new SqlParameter("p11", DateTime.Now);

        cvp=SqlHelper.ExecuteNonQuery(SqlHelper.ConnStr, CommandType.Text, sorgu, prm);

        if (cvp == 1)
            return true;
        else
            return false;

    }
}