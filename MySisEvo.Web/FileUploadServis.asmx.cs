using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.IO;

namespace MySisEvo.Web
{
    /// <summary>
    /// Summary description for FileUploadServis
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class FileUploadServis : System.Web.Services.WebService
    {

        [WebMethod]
        public long DosyaBoyut(string FileName)
        {
            long FileLength = 0;
            try
            {
                string path = Server.MapPath(".") + @"\documents\images\" + FileName;
                File.Delete(path);
                FileInfo FileInf = new FileInfo(path);
                FileLength = FileInf.Length;
                
            }
            catch
            { 

            }
            return FileLength;
        }

        [WebMethod]
        public long Kaydet(byte[] Data,string FileName)
        {
            MemoryStream MS = new MemoryStream(Data);
            string path = Server.MapPath(".") + @"\documents\images\" + FileName;
            FileStream FS;
            if (File.Exists(path))
                FS = new FileStream(path, FileMode.Append);
            else
                FS = new FileStream(path, FileMode.Create);
            MS.WriteTo(FS);
            long DataLength = FS.Length;
            MS.Close();
            FS.Close();
            FS.Dispose();
            return DataLength;
        }
    }
}
