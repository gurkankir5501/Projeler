using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kanBagisOtomasyonu
{
    class KanBagisMerkezi
    {
        private string subeKodu;
        private string adi;
        private string adresi;
        private string acilisTarihi;

        public void setSubeKodu(string subeKodu) {

            this.subeKodu = subeKodu;
        }
        public string getSubeKodu()
        {
            return subeKodu;

        }

        public void setAdi(string adi){

            this.adi = adi;
        }
        public string getAdi()
        {

            return adi;
        }

        public void setAdresi(string adresi)
        {
            this.adresi = adresi;

        }
        public string getAdresi()
        {
            return adresi;
        }

        public void setAcilisTarihi(string acilisTarihi)
        {
            this.acilisTarihi = acilisTarihi;
        }
        public string getAcilisTarihi()
        {

            return acilisTarihi;
        }
    

    }
}
