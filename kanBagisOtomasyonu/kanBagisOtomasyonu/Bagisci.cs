using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kanBagisOtomasyonu
{
    class Bagisci
    {
        private string tcKimlikNo;
        private string ad;
        private string soyad;
        private string kanGrubu;
        private string telNo;
        private string adres;
        

        public void setTcKimlikNo(string tcKimlikNo)
        {
                this.tcKimlikNo = tcKimlikNo;
           
        }
        public string getTcKimlikNo()
        {
            return tcKimlikNo;
        }

        public void setAd(string ad)
        {
            this.ad = ad;
        }
        public string getAd()
        {
            return ad;
        }

        public void setSoyad(string soyad)
        {
            this.soyad = soyad;
        }
        public string getSoyad()
        {
            return soyad;
        }

        public void setKanGrubu(string kanGrubu)
        {
            this.kanGrubu = kanGrubu;
        }
        public string getKanGrubu()
        {
            return kanGrubu;
        }


        public void setTelNo(string telNo)
        {

            this.telNo = telNo;
        }
        public string getTelNo()
        {
            return telNo;
        }


        public void setAdres(string adres)
        {
            this.adres = adres;
        }
        public string getAdres()
        {
            return adres;
        }


    }
}
