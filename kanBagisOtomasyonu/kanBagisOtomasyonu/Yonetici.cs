using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kanBagisOtomasyonu
{
    class Yonetici
    {
        private string yoneticiKodu;
        private string yoneticiAdi;
        private string yoneticiSoyadi;
        private string yoneticiParola;
        private string gorevKodu;
        private string gorevAdi;

        

        public void setYoneticiKodu(String yoneticiKodu)
        {
            this.yoneticiKodu = yoneticiKodu;
        }
        public string getYoneticiKodu()
        {
            return yoneticiKodu;
        }
        public void setYoneticiAdi(String yoneticiAdi)
        {
            this.yoneticiAdi = yoneticiAdi;
        }
        public string getYoneticiAdi()
        {
            return yoneticiAdi;
        }
        public void setYoneticiSoyadi(String yoneticiSoyadi)
        {
            this.yoneticiSoyadi = yoneticiSoyadi;
        }
        public string getYoneticiSoyadi()
        {
            return yoneticiSoyadi;
        }
        public void setYoneticiParola(String yoneticiParola)
        {
            this.yoneticiParola = yoneticiParola;
        }
        public string getYoneticiParola()
        {
            return yoneticiParola;
        }

        public void setGorevKodu(String gorevKodu)
        {
            this.gorevKodu = gorevKodu;
        }
        public string getGorevKodu()
        {
            return gorevKodu;
        }
        public void setGorevAdi(string gorevAdi)
        {
            this.gorevAdi = gorevAdi;
        }
        public string getGorevAdi()
        {
            return this.gorevAdi;
        }
    }
}
