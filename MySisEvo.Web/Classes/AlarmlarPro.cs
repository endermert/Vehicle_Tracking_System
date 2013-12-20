using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections.ObjectModel;
using MySisEvo.Web.Classes;
using System.Data;

namespace MySisEvo.Web.Classes
{
    public class AlarmlarPro
    {
        ObservableCollection<Alarmlar> alarmList = null;
        DataSet Eds = new DataSet();
        public ObservableCollection<Alarmlar> getAlarmList(String kul)
        {
            string sorgu = "SELECT * FROM ATS_ALARMLAR WHERE ALRM_KUL='"+ kul +"' ORDER BY ALRM_TAR DESC;";
            //string sorgu = "SELECT * FROM ATS_ARACLAR WHERE FRM_1D=" + frmId.ToString();
            Eds = SqlHelper.DataBasePro(sorgu);
            return getAlarmList(Eds);
        }

        public ObservableCollection<Alarmlar> getAlarmList(DataSet ds)
        {
            Alarmlar myAlarm = new Alarmlar();
            alarmList = new ObservableCollection<Alarmlar>();
            if (ds.Tables.Count>0)
            for (int i = 0; i < ds.Tables.Count; i++)
            {
                if (ds.Tables[0].Rows.Count > 0)
                {
                    myAlarm = new Alarmlar();
                    myAlarm.ALRM_ID = int.Parse(ds.Tables[0].Rows[i]["ALRM_1D"].ToString());
                    myAlarm.ALRM_KUL = ds.Tables[0].Rows[i]["ALRM_KUL"].ToString();
                    myAlarm.ALRM_NOT = ds.Tables[0].Rows[i]["ALRM_NOT"].ToString();
                    myAlarm.ALRM_OKUNDU = Boolean.Parse(ds.Tables[0].Rows[i]["ALRM_OKUNDU"].ToString());
                    myAlarm.ALRM_PLAKA = ds.Tables[0].Rows[i]["ALRM_PLAKA"].ToString();
                    myAlarm.ALRM_TUR = ds.Tables[0].Rows[i]["ALRM_TUR"].ToString();
                    myAlarm.ALRM_TAR = DateTime.Parse(ds.Tables[0].Rows[i]["ALRM_TAR"].ToString());
                    alarmList.Add(myAlarm);
                }

            }
            return alarmList;
        }
    }
}