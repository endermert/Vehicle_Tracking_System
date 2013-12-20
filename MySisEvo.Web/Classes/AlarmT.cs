using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MySisEvo.Web.Classes
{
    public class AlarmT
    {
        public int TNM_ID { get; set; }
        public string TNM_KUL { get; set; }
        public string TNM_ARC { get; set; }
        public string TNM_GSM { get; set; }
        public string TNM_EPOSTA { get; set; }
        public Byte TNM_HZLMT { get; set; }
        public string TNM_MESA1 { get; set; }
        public DateTime TNM_ROLANT { get; set; }
        public DateTime TNM_DURAKLAMA { get; set; }
    }
}