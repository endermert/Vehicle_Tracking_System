using System;
using System.Windows;

namespace MySisEvo
{
    public static class URIHelper
    {
        public static Uri CurrentApplicationURL 
        {
            get
            {
                return System.Windows.Browser.HtmlPage.Document.DocumentUri;
            }
        }
    }
}
