using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kanBagisOtomasyonu
{
    class Bagis
    {
        private string kimlikNo;
        private string subeNo;
        private string verilisTarihi;

        public void setKimlikNo(String kimlikNo)
        {
            this.kimlikNo = kimlikNo;
        }
        public String getKimlikNo()
        {
            return kimlikNo;
        }

        public void setSubeNo(String subeNo)
        {
            this.subeNo = subeNo;
        }
        public String getSubeNo()
        {
            return subeNo;
        }

        public void setVerilisTarihi(String verilisTarihi)
        {
            this.verilisTarihi = verilisTarihi;
        }
        public String getVerilisTarihi()
        {
            return verilisTarihi;
        }
    }
}
