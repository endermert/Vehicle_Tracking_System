using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MySisEvo.Web.Classes
{
    public class Alarmlar
    {
        public int ALRM_ID { get; set; }
        public string ALRM_KUL { get; set; }
        public string ALRM_PLAKA { get; set; }
        public string ALRM_TUR { get; set; }
        public string ALRM_NOT { get; set; }
        public Boolean ALRM_OKUNDU { get; set; }
        public DateTime ALRM_TAR { get; set; }
    }
}