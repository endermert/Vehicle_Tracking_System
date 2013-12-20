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

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    protected void btnGonder_Click(object sender, EventArgs e)
    {
        Boolean snc = false;
        snc = DealersPro.DealersKayit(til.Text, tilce.Text, tUnvan.Text, tYetkili.Text, tAdres.Text, tTel.Text, tFax.Text, tGsm.Text, tEmail.Text);
        if (snc)
            cvpLabel.Text = "Gönderildi..";
        else
            cvpLabel.Text = "Ýþlem Baþarýþýz..";
    }
}

