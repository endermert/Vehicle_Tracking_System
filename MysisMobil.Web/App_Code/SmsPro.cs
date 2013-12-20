using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySis;
using System.Drawing;
/// <summary>
/// Summary description for SmsPro
/// </summary>
public class SmsPro
{
	public SmsPro()
	{

	}
    public static void setSmsGorevler(string tGsm, string tPass)
    {
        string tSmsText = "Kullanici Adi:DEMO Sifreniz:"+tPass + "  Sadece 1(bir) gun gecerlidir..";
        string sorgu = "INSERT INTO smsgorevler (gsm,smstext) values ('"+tGsm+"','"+tSmsText+"');";
        SqlHelper.ExecutePro("ConnPoz",sorgu);
    }

    
}