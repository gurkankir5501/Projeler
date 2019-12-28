using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kanBagisOtomasyonu
{
    class Hasta
    {
        private string kimlikNo;
        private string adi;
        private string soyadi;
        private string kanGrubu;
        private string adresi;
        private string telNo;
        private string hastaneKodu;

        public void setKimlikNo(string kimlikNo)
        {
            this.kimlikNo = kimlikNo;
        }
        public string getKimlikNo()
        {
            return kimlikNo;
        }

        public void setAdi(string adi)
        {
            this.adi = adi;
        }
        public string getAdi()
        {
            return adi;
        }

        public void setSoyadi(string soyadi)
        {
            this.soyadi = soyadi;
        }
        public string getSoyadi()
        {
            return soyadi;
        }

        public void setKanGrubu(string kanGrubu)
        {
            this.kanGrubu = kanGrubu;
        }
        public string getKanGrubu()
        {
            return kanGrubu;
        }

        public void setAdresi(string adresi)
        {
            this.adresi = adresi;
        }

        public string getAdresi()
        {
            return adresi;
        }

        public void setTelNo(string telNo)
        {
            this.telNo = telNo;
        }
        public string getTelNo()
        {
            return telNo;
        }

        public void setHastaneKodu(string hastaneKodu)
        {
            this.hastaneKodu = hastaneKodu;
        }
        public string getHastaneKodu()
        {
            return hastaneKodu;
        }
    }
}
