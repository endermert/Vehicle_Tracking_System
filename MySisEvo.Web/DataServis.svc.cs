using System;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using MySisEvo.Web.Classes;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace MySisEvo.Web
{
    [ServiceContract(Namespace = "")]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class DataServis
    {
        AraclarPro AraclarPro = new AraclarPro();
        DatasPro DataPro = new DatasPro();
        AlarmlarPro apro = new AlarmlarPro();
        AlarmTPro Ater = new AlarmTPro();
        Kullanici kul = new Kullanici();
        KullaniciPro kulPro = new KullaniciPro();

        [OperationContract]
        public Datas getData(int serino)
        {
            Datas data1 = new Datas();
            data1 = DataPro.getData(serino);

            return data1;
        }

        [OperationContract]
        public ObservableCollection<Datas> getDatas(List<String> serinolar)
        {
            ObservableCollection<Datas> data1 = new ObservableCollection<Datas>();
            data1 = DataPro.getData(serinolar);
            return data1;
        }

        [OperationContract]
        public ObservableCollection<Datas> getDataList(int serino, DateTime basTar, DateTime bitTar)
        {
            ObservableCollection<Datas> data1 = new ObservableCollection<Datas>();
            data1 = DataPro.getData(serino, basTar, bitTar);
            return data1;
        }
        [OperationContract]
        public ObservableCollection<Datas> getDataListXml(int serino, DateTime basTar, DateTime bitTar)
        {
            ObservableCollection<Datas> data1 = new ObservableCollection<Datas>();
            data1 = DataPro.getDataXml(serino, basTar, bitTar);
            return data1;
        }

        
        [OperationContract]
        public ObservableCollection<Alarmlar> getAlarmlar(String kul)
        {
            return apro.getAlarmList(kul);
        }
        
        [OperationContract]
        public void setAlarmTanim(String Serinolar, AlarmT AlarmTan)
        {
            Ater.setAlarmTanim(Serinolar, AlarmTan);
            return;
        }

        
        [OperationContract]
        public ObservableCollection<Araclar> getAraclar(string kulAd)
        {
            ObservableCollection<Araclar> arcList = new ObservableCollection<Araclar>();
            arcList = AraclarPro.getAraclarList(kulAd);
            return arcList;
        }

        [OperationContract]
        public void updateArac(Araclar arac)
        {
            AraclarPro.updateArac(arac);
        }

        [OperationContract]
        public Kullanici getKullanici(string kulAd, string kulSifre)
        {
            kul = kulPro.getKullanici(kulAd, kulSifre);
            return kul;
        }

    }
}

