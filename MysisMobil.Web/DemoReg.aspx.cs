using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using MySis;

public partial class DemoReg : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }
    protected void bntDemoSmsGonder_Click(object sender, EventArgs e)
    {
        if (RadCaptcha1.IsValid)
        {
            Random r=new Random();
            int rndPass=r.Next(100000,9999999);
            DemoPro.setDemoFrm("0"+tGsm.Text,tYetkili.Text,"demo",rndPass.ToString());

            SmsPro.setSmsGorevler("0" + tGsm.Text, rndPass.ToString());
            cvpLabel.Text = "Kullanýcý Adýnýz ve Þifreniz Gönderildi..";
        }

    }
}
