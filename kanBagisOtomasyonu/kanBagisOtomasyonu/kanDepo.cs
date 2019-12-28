using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kanBagisOtomasyonu
{
    class kanDepo
    {
        private string kanDeposuId;
        private string kanGrubu;
        private string verilisTarihi;
        private int miktar;
        private string subeKodu;

        public void setKanDeposuId(string kanDeposuId)
        {
            this.kanDeposuId = kanDeposuId;
        }
        public string getKanDeposuId()
        {
            return kanDeposuId;
        }

        public void setKanGrubu(string kanGrubu)
        {
            this.kanGrubu = kanGrubu;
        }
        public string getKanGrubu()
        {
            return kanGrubu;
        }

        public void setVerilisTarihi(string verilisTarihi)
        {
            this.verilisTarihi = verilisTarihi;
        }
        public string getVerilisTarihi()
        {
            return verilisTarihi;
        }

        public void setMiktar(int miktar)
        {
            this.miktar = miktar;
        }
        public int getMiktar()
        {
            return miktar;
        }

        public void setSubeKodu(string subeKodu)
        {
            this.subeKodu = subeKodu;
        }
        public string getSubeKodu()
        {
            return subeKodu;
        }
    }
}
