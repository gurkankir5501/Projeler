using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kanBagisOtomasyonu
{
    class Hastane
    {
        private string hastaneKodu;
        private string adi;
        private string adresi;

        public void setHastaneKodu(string hastaneKodu)
        {
            this.hastaneKodu = hastaneKodu;

        }
        public string getHastaneKodu()
        {
            return hastaneKodu;
        }

        public void setAdi(string adi)
        {
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
    }
}
