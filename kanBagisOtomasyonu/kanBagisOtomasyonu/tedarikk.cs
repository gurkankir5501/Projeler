using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kanBagisOtomasyonu
{
    class tedarikk
    {
        private string subeKodu;
        private string hastaneKodu;
        private string alinmaTarihi;
        private string kanGrubu;
        private int miktar;

        public void setSubeKodu(string subeKodu)
        {
            this.subeKodu = subeKodu;
        }
        public string getSubeKodu()
        {
            return subeKodu;
        }

        public void setHastaneKodu(string hastaneKodu)
        {
            this.hastaneKodu = hastaneKodu;
        }
        public string getHastaneKodu()
        {
            return hastaneKodu;

        }
        public void setAlinmaTarihi(string alinmaTarihi)
        {
            this.alinmaTarihi = alinmaTarihi;
        }
        public string getAlinmaTarihi()
        {
            return alinmaTarihi;
        }

        public void setKanGrubu(string kanGrubu)
        {
            this.kanGrubu = kanGrubu;
        }
        public string getKanGrubu()
        {
            return kanGrubu;
        }

        public void setMiktar(int miktar)
        {
            this.miktar = miktar;
        }
        public int getMiktar()
        {
            return miktar;
        }
    }
}
