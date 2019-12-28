using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kanBagisOtomasyonu
{
    class ilanlarr
    {
        public string ilanKodu;
        public string ilanMetini;
        public string yoneticiKodu;

        public void setilanKodu(string ilanKodu)
        {
            this.ilanKodu = ilanKodu;
        }
        public string getilanKodu()
        {
            return ilanKodu;
        }

        public void setilanMetini(string ilanMetini)
        {
            this.ilanMetini = ilanMetini;
        }
        public string getilanMetini()
        {
            return ilanMetini;
        }

        public void setYoneticiKodu(string yoneticiKodu)
        {
            this.yoneticiKodu = yoneticiKodu;
        }
        public string getYoneticiKodu()
        {
            return yoneticiKodu;
        }
    }
}
