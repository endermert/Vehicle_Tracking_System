using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Browser;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace MySisEvo.Controls
{
    public class EkranAyarlari
    {
        public static int getYukseklik()
        {
            int res = 0;
            try
            {
               res=int.Parse(HtmlPage.Window.Eval("screen.height").ToString());
            }
            catch
            {
                res = -1;
            }

            return res;
        }

       
         
    }
    
}
