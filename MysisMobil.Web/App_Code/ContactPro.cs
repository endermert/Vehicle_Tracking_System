using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySis;
using System.Data.SqlClient;
using System.Data;
/// <summary>
/// Summary description for ContactPro
/// </summary>
public class ContactPro
{
	public ContactPro()
	{

	}
    public static Boolean ContactKayit(string tIsim,string tPosta,string tMesaj)
    {
        
        int cvp = 0;
        string sorgu = "INSERT INTO ATS_MESAJ (MSJ_AD,MSJ_POSTA,MSJ_MESAJ,MSJ_TAR) VALUES (@p1,@p2,@p3,@p4);";
        SqlParameter[] prm = new SqlParameter[4];
        
        prm[0] = new SqlParameter("p1", tIsim);
        prm[1] = new SqlParameter("p2", tPosta );
        prm[2] = new SqlParameter("p3", tMesaj);
        prm[3] = new SqlParameter("p4", DateTime.Now);

        cvp=SqlHelper.ExecuteNonQuery(SqlHelper.ConnStr, CommandType.Text, sorgu, prm);

        if (cvp == 1)
            return true;
        else
            return false;

    }
}