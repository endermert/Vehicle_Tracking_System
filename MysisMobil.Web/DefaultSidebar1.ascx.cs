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
using KUL_SR;

public partial class Sidebar1 : System.Web.UI.UserControl
{
    KullaniciServisClient kul_sr = new KullaniciServisClient();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Entities.LoginIn)
        {
            pnlLoginIn.Visible = false;
            pnlLoginOut.Visible = true;
            kulIsim.Text = Entities.Kullanici.KUL_AD;
        }
        else
        {
            pnlLoginIn.Visible = true;
            pnlLoginOut.Visible = false;
            loginMsj.Visible = false;
        }
    }
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        Entities.Kullanici = kul_sr.getKullanici(kulAd.Text, kulPass.Text);

        if (Entities.Kullanici == null)
            Entities.LoginIn = false;
        else
            Entities.LoginIn = true;


        if (Entities.LoginIn)
        {
            pnlLoginIn.Visible = false;
            pnlLoginOut.Visible = true;
            kulIsim.Text = Entities.Kullanici.KUL_AD;
            Session["kulAd"] = Entities.Kullanici.KUL_AD;
        }
        else
        {
            loginMsj.Visible = true;
            loginMsj.Text = "Hatalý Kullanýcý Adý veya Þifre..";
        }

        /*
        KullaniciPro kulPro = new KullaniciPro();
        Entities.Kullanici = kulPro.getKullanici(kulAd.Text,kulPass.Text);

        if (Entities.LoginIn)
        {
            pnlLoginIn.Visible = false;
            pnlLoginOut.Visible = true;
            kulIsim.Text = Entities.Kullanici.KUL_AD;
        }
        else
        {
            loginMsj.Visible = true;
            loginMsj.Text = "Hatalý Kullanýcý Adý veya Þifre..";
        }

        */
    }

    protected void btnLogOut_Click(object sender, EventArgs e)
    {
        pnlLoginIn.Visible = true;
        pnlLoginOut.Visible = false;
        kulIsim.Text = "";
        loginMsj.Visible = false;
        Session["kulAd"] = null;
    }
}
