using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace MySisEvo.Web.Classes
{
    public class AlarmTPro
    {
        public void setAlarmTanim(String Serinolar,AlarmT AlarmTan)
        {
            String[] seriNo;
            seriNo= Serinolar.Split(';');
            string sorgu = "";

            for (int i = 0; i < seriNo.Length-1; i++)
            {
                sorgu = "DELETE FROM ATS_ALARMTAN1M WHERE TNM_ARC='"+seriNo[i]+"';";
                SqlHelper.ExecuteNonQuery(SqlHelper.ConnStr,System.Data.CommandType.Text,sorgu);

                sorgu = "INSERT INTO ATS_ALARMTAN1M (TNM_KUL,TNM_ARC,TNM_GSM,TNM_EPOSTA,TNM_HZLMT,TNM_MESA1,TNM_ROLANT,TNM_DURAKLAMA) VALUES(@P0,@P1,@P2,@P3,@P4,@P5,@P6,@P7);";
                SqlParameter[] prm = new SqlParameter[8];
                prm[0] = new SqlParameter("P0", AlarmTan.TNM_KUL);
                prm[1] = new SqlParameter("P1", seriNo[i].Trim());
                prm[2] = new SqlParameter("P2", AlarmTan.TNM_GSM);
                prm[3] = new SqlParameter("P3", AlarmTan.TNM_EPOSTA);
                prm[4] = new SqlParameter("P4", AlarmTan.TNM_HZLMT);
                prm[5] = new SqlParameter("P5", AlarmTan.TNM_MESA1);
                prm[6] = new SqlParameter("P6", AlarmTan.TNM_ROLANT);
                prm[7] = new SqlParameter("P7", AlarmTan.TNM_DURAKLAMA);
                SqlHelper.ExecuteNonQuery(SqlHelper.ConnStr, CommandType.Text, sorgu, prm);
            }
        }
    }
}