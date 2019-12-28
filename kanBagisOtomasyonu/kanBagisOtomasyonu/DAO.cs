using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace kanBagisOtomasyonu
{
    class DAO
    {
        


        public static SqlConnection openConnection()
        {
            SqlConnection sqlbaglanti = new SqlConnection("server=gk\\mssqlserver01;Database=kanBagisOtomasyon;Trusted_Connection=true");
            try
            {
                sqlbaglanti.Open();
                return sqlbaglanti;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public static void connectionClose(SqlConnection sqlbaglanti)
        {
            sqlbaglanti.Close();
        }

        public static bool girisKontrol(Yonetici yonetici)
        {

            SqlConnection sqlbaglanti = openConnection();
            try
            {

                SqlCommand veriOku = new SqlCommand("select * from Yonetici where yoneticiKodu=@yKodu " +
                                                    "and parola=@pass and gorevKodu=@gKodu", sqlbaglanti);

                veriOku.Parameters.AddWithValue("@yKodu", yonetici.getYoneticiKodu());
                veriOku.Parameters.AddWithValue("@pass", yonetici.getYoneticiParola());
                veriOku.Parameters.AddWithValue("@gKodu", yonetici.getGorevKodu());

                SqlDataReader rdr = veriOku.ExecuteReader();
                rdr.Read();
                if (rdr.HasRows)
                    return true;
                else
                    return false;

            }
            catch (Exception)
            {


                throw;

            }
            finally
            {
                connectionClose(sqlbaglanti);
            }

        }

        public static bool bagisciArama(Bagisci bagisci)
        {

            SqlConnection sqlbaglanti = openConnection();
            try
            {

                SqlCommand veriOku = new SqlCommand("select * from bagisci where kimlikNo=@tcNo", sqlbaglanti);

                veriOku.Parameters.AddWithValue("@tcNo", bagisci.getTcKimlikNo());


                SqlDataReader rdr = veriOku.ExecuteReader();
                rdr.Read();

                if (rdr.HasRows)
                {

                    return true;


                }
                else
                {
                    return false;
                }


            }
            catch (Exception)
            {


                throw;

            }
            finally
            {
                connectionClose(sqlbaglanti);
            }

        }

        public static void bagisciEkle(Bagisci bagisci)
        {

            SqlConnection sqlbaglanti = openConnection();
            SqlCommand veriOku = new SqlCommand("INSERT INTO bagisci (kimlikNo,adi,soyadi,kanGrubu,adresi,telefonNumarasi) VALUES (@kimlikNo,@adi,@soyadi," +
                                                    "@kanGrubu,@adres,@telefonNumarasi)", sqlbaglanti);

            veriOku.Parameters.AddWithValue("@kimlikNo", bagisci.getTcKimlikNo());
            veriOku.Parameters.AddWithValue("@adi", bagisci.getAd());
            veriOku.Parameters.AddWithValue("@soyadi", bagisci.getSoyad());
            veriOku.Parameters.AddWithValue("@kanGrubu", bagisci.getKanGrubu());
            veriOku.Parameters.AddWithValue("@adres", bagisci.getAdres());
            veriOku.Parameters.AddWithValue("@telefonNumarasi", bagisci.getTelNo());
            try
            {

                veriOku.ExecuteNonQuery();

            }
            catch (Exception)
            {


                
                MessageBox.Show("alanları doğru giriniz lütfen!!!");
          
            }
            finally
            {
                connectionClose(sqlbaglanti);
            }

        }

        public static void bagisciSil(Bagisci bagisci)
        {
            SqlConnection sqlbaglanti = openConnection();
            
            SqlCommand veriOku = new SqlCommand("DELETE FROM bagisci where kimlikNo=@tcNo",sqlbaglanti);
            
             veriOku.Parameters.AddWithValue("@tcNo",bagisci.getTcKimlikNo());
             veriOku.ExecuteNonQuery();
             connectionClose(sqlbaglanti);
            

        }

        public static void bagisciGuncelle(Bagisci bagisci)
        {

            SqlConnection sqlbaglanti = openConnection();
            SqlCommand veriOku = new SqlCommand("UPDATE bagisci SET adi=@adi,soyadi=@soyadi,kanGrubu=@kanGrubu," +
                                                "adresi=@adres,telefonNumarasi=@telefonNumarasi where kimlikNo=@kimlikNo", sqlbaglanti);

            veriOku.Parameters.AddWithValue("@kimlikNo", bagisci.getTcKimlikNo());
            veriOku.Parameters.AddWithValue("@adi", bagisci.getAd());
            veriOku.Parameters.AddWithValue("@soyadi", bagisci.getSoyad());
            veriOku.Parameters.AddWithValue("@kanGrubu", bagisci.getKanGrubu());
            veriOku.Parameters.AddWithValue("@adres", bagisci.getAdres());
            veriOku.Parameters.AddWithValue("@telefonNumarasi", bagisci.getTelNo());
            try
            {

                veriOku.ExecuteNonQuery();

            }
            catch (Exception)
            {



                throw;

            }
            finally
            {
                connectionClose(sqlbaglanti);
            }
        }

        public static bool bagisArama(Bagis bagis)
        {

            SqlConnection sqlbaglanti = openConnection();
            try
            {

                SqlCommand veriOku = new SqlCommand("select * from bagis where kimlikNo=@tcNo AND subeKodu=@subeNo", sqlbaglanti);

                veriOku.Parameters.AddWithValue("@tcNo", bagis.getKimlikNo());
                veriOku.Parameters.AddWithValue("@subeNo", bagis.getSubeNo());

                SqlDataReader rdr = veriOku.ExecuteReader();
                rdr.Read();

                if (rdr.HasRows)
                {

                    return true;


                }
                else
                {
                    return false;
                }


            }
            catch (Exception)
            {


                throw;

            }
            finally
            {
                connectionClose(sqlbaglanti);
            }

        }
        public static void bagisEkle(Bagis bagis)
        {
            SqlConnection sqlbaglanti = openConnection();
            SqlCommand veriOku = new SqlCommand("INSERT INTO bagis (subeKodu,kimlikNo,verilenTarih) VALUES" +
                "                               (@subeNo,@kimlikNo,@verilisTarihi)", sqlbaglanti);

            veriOku.Parameters.AddWithValue("@kimlikNo", bagis.getKimlikNo());
            veriOku.Parameters.AddWithValue("@subeNo", bagis.getSubeNo());
            veriOku.Parameters.AddWithValue("@verilisTarihi", bagis.getVerilisTarihi());
            
            try
            {

                veriOku.ExecuteNonQuery();

            }
            catch (Exception)
            {



                MessageBox.Show("alanları doğru giriniz lütfen!!!");

            }
            finally
            {
                connectionClose(sqlbaglanti);
            }
        }

        public static void bagisSil(Bagis bagis)
        {
            SqlConnection sqlbaglanti = openConnection();

            SqlCommand veriOku = new SqlCommand("DELETE FROM bagis where kimlikNo=@tcNo", sqlbaglanti);

            veriOku.Parameters.AddWithValue("@tcNo", bagis.getKimlikNo());

            try
            {

                veriOku.ExecuteNonQuery();

            }
            catch (Exception)
            {



                throw;

            }
            finally
            {
                connectionClose(sqlbaglanti);
            }


        }

        public static bool bagisciBagisMerkeziArama(Bagis bagis)
        {

            SqlConnection sqlbaglanti = openConnection();
            try
            {

                SqlCommand veriOku = new SqlCommand("select subeKodu,kimlikNo from kanBagisMerkezi,bagisci " +
                                                    "where subeKodu=@subeNo and kimlikNo=@tcKimlikNo ", sqlbaglanti);

                veriOku.Parameters.AddWithValue("@subeNo", bagis.getSubeNo());
                veriOku.Parameters.AddWithValue("@tcKimlikNo", bagis.getKimlikNo());


                SqlDataReader rdr = veriOku.ExecuteReader();
                rdr.Read();

                if (rdr.HasRows)
                {

                    return true;


                }
                else
                {
                    return false;
                }


            }
            catch (Exception)
            {


                throw;

            }
            finally
            {
                connectionClose(sqlbaglanti);
            }

        }

        public static void bagisGuncelle(Bagis bagis)
        {

            SqlConnection sqlbaglanti = openConnection();
            SqlCommand veriOku = new SqlCommand("UPDATE bagis SET subeKodu=@subeNo,kimlikNo=@kimlikNo,verilenTarih=@verilisTarihi", sqlbaglanti);

            veriOku.Parameters.AddWithValue("@subeNo", bagis.getSubeNo());
            veriOku.Parameters.AddWithValue("@kimlikNo", bagis.getKimlikNo());
            veriOku.Parameters.AddWithValue("@verilisTarihi", bagis.getVerilisTarihi());

            try
            {

                veriOku.ExecuteNonQuery();

            }
            catch (Exception)
            {



                throw;

            }
            finally
            {
                connectionClose(sqlbaglanti);
            }
        }

        public static bool bagisMerkeziArama(KanBagisMerkezi kanbagismerkezi)
        {

            SqlConnection sqlbaglanti = openConnection();
            try
            {

                SqlCommand veriOku = new SqlCommand("select * from kanBagisMerkezi where subeKodu=@subeNo", sqlbaglanti);

                veriOku.Parameters.AddWithValue("@subeNo", kanbagismerkezi.getSubeKodu());


                SqlDataReader rdr = veriOku.ExecuteReader();
                rdr.Read();

                if (rdr.HasRows)
                {

                    return true;


                }
                else
                {
                    return false;
                }


            }
            catch (Exception)
            {


                throw;

            }
            finally
            {
                connectionClose(sqlbaglanti);
            }

        }

        public static void bagisMerkeziekle(KanBagisMerkezi kanbagismerkezi)
        {

            SqlConnection sqlbaglanti = openConnection();
            SqlCommand veriOku = new SqlCommand("INSERT INTO kanBagisMerkezi (subeKodu,adi,adresi,acilisTarihi) VALUES (@subeNo,@adi,@adres,@acilisTarihi)", sqlbaglanti);

            veriOku.Parameters.AddWithValue("@subeNo", kanbagismerkezi.getSubeKodu());
            veriOku.Parameters.AddWithValue("@adi", kanbagismerkezi.getAdi());
            veriOku.Parameters.AddWithValue("@adres", kanbagismerkezi.getAdresi());
            veriOku.Parameters.AddWithValue("@acilisTarihi", kanbagismerkezi.getAcilisTarihi());
        
            
            try
            {

                veriOku.ExecuteNonQuery();

            }
            catch (Exception)
            {


            }
            finally
            {
                connectionClose(sqlbaglanti);
            }

        }

        public static void bagisMerkeziSil(KanBagisMerkezi kanbagismerkezi)
        {

            SqlConnection sqlbaglanti = openConnection();
            SqlCommand veriOku = new SqlCommand("DELETE FROM kanBagisMerkezi WHERE subeKodu=@subeNo",sqlbaglanti);

            veriOku.Parameters.AddWithValue("@subeNo", kanbagismerkezi.getSubeKodu());
            


            try
            {

                veriOku.ExecuteNonQuery();

            }
            catch (Exception)
            {


            }
            finally
            {
                connectionClose(sqlbaglanti);
            }

        }

        public static void bagisMerkeziGuncelle(KanBagisMerkezi kanbagismerkezi)
        {

            SqlConnection sqlbaglanti = openConnection();
            SqlCommand veriOku = new SqlCommand("UPDATE kanBagisMerkezi SET adi=@adi,adresi=@adres,acilisTarihi=@acilisTarihi where subeKodu=@subeNo",sqlbaglanti);

            veriOku.Parameters.AddWithValue("@subeNo", kanbagismerkezi.getSubeKodu());
            veriOku.Parameters.AddWithValue("@adi", kanbagismerkezi.getAdi());
            veriOku.Parameters.AddWithValue("@adres", kanbagismerkezi.getAdresi());
            veriOku.Parameters.AddWithValue("@acilisTarihi", kanbagismerkezi.getAcilisTarihi());


            try
            {

                veriOku.ExecuteNonQuery();

            }
            catch (Exception)
            {


            }
            finally
            {
                connectionClose(sqlbaglanti);
            }

        }

        public static bool bagisMerkeziyoneticiArama(Yonetici yonetici)
        {

            SqlConnection sqlbaglanti = openConnection();
            try
            {

                SqlCommand veriOku = new SqlCommand("select * from Yonetici where yoneticiKodu=@yKodu " +
                                                    "and adi=@adi and soyadi=@soyadi and gorevKodu='111111'", sqlbaglanti);

                veriOku.Parameters.AddWithValue("@yKodu", yonetici.getYoneticiKodu());
                veriOku.Parameters.AddWithValue("@adi", yonetici.getYoneticiAdi());
                veriOku.Parameters.AddWithValue("@soyadi", yonetici.getYoneticiSoyadi());

                SqlDataReader rdr = veriOku.ExecuteReader();
                rdr.Read();
                if (rdr.HasRows)
                    return true;
                else
                    return false;

            }
            catch (Exception)
            {


                throw;

            }
            finally
            {
                connectionClose(sqlbaglanti);
            }

        }

        public static void bagisMerkeziYoneticiekle(Yonetici yonetici)
        {

            SqlConnection sqlbaglanti = openConnection();
            SqlCommand veriOku = new SqlCommand("INSERT INTO Yonetici (yoneticiKodu,adi,soyadi,parola,gorevKodu) VALUES (@yoneticiKodu,@adi,@soyadi,@parola,@gorevKodu)", sqlbaglanti);

            veriOku.Parameters.AddWithValue("@yoneticiKodu", yonetici.getYoneticiKodu());
            veriOku.Parameters.AddWithValue("@adi", yonetici.getYoneticiAdi());
            veriOku.Parameters.AddWithValue("@soyadi", yonetici.getYoneticiSoyadi());
            veriOku.Parameters.AddWithValue("@parola", yonetici.getYoneticiParola());
            veriOku.Parameters.AddWithValue("@gorevKodu", yonetici.getGorevKodu());


            try
            {

                veriOku.ExecuteNonQuery();

            }
            catch (Exception)
            {


            }
            finally
            {
                connectionClose(sqlbaglanti);
            }

        }

        public static void bagisMerkeziYoneticiSil(Yonetici yonetici)
        {

            SqlConnection sqlbaglanti = openConnection();
            SqlCommand veriOku = new SqlCommand("DELETE FROM Yonetici WHERE yoneticiKodu=@yoneticiKodu", sqlbaglanti);

            veriOku.Parameters.AddWithValue("@yoneticiKodu", yonetici.getYoneticiKodu());



            try
            {

                veriOku.ExecuteNonQuery();

            }
            catch (Exception)
            {


            }
            finally
            {
                connectionClose(sqlbaglanti);
            }

        }

        public static void bagisMerkeziYoneticiGuncelle(Yonetici yonetici)
        {

            SqlConnection sqlbaglanti = openConnection();
            SqlCommand veriOku = new SqlCommand("UPDATE Yonetici SET adi=@adi,soyadi=@soyadi,parola=@parola where yoneticiKodu=@yoneticiKodu", sqlbaglanti);

            veriOku.Parameters.AddWithValue("@yoneticiKodu", yonetici.getYoneticiKodu());
            veriOku.Parameters.AddWithValue("@adi", yonetici.getYoneticiAdi());
            veriOku.Parameters.AddWithValue("@soyadi", yonetici.getYoneticiSoyadi());
            veriOku.Parameters.AddWithValue("@parola", yonetici.getYoneticiParola());


            try
            {

                veriOku.ExecuteNonQuery();

            }
            catch (Exception)
            {


            }
            finally
            {
                connectionClose(sqlbaglanti);
            }

        }

        public static bool bagisKanDeposuMerkeziArama(kanDepo kanDepo)
        {

            SqlConnection sqlbaglanti = openConnection();
            try
            {

                SqlCommand veriOku = new SqlCommand("select * from kanBagisMerkezi where subeKodu=@subeNo", sqlbaglanti);

                veriOku.Parameters.AddWithValue("@subeNo", kanDepo.getSubeKodu());


                SqlDataReader rdr = veriOku.ExecuteReader();
                rdr.Read();

                if (rdr.HasRows)
                {

                    return true;


                }
                else
                {
                    return false;
                }


            }
            catch (Exception)
            {


                throw;

            }
            finally
            {
                connectionClose(sqlbaglanti);
            }

        }

        public static bool bagisKanDeposuIdArama(kanDepo kanDepo)
        {

            SqlConnection sqlbaglanti = openConnection();
            try
            {

                SqlCommand veriOku = new SqlCommand("select * from kanDeposu where kanDeposuId=@kanDeposuId", sqlbaglanti);

                veriOku.Parameters.AddWithValue("@kanDeposuId", kanDepo.getKanDeposuId());


                SqlDataReader rdr = veriOku.ExecuteReader();
                rdr.Read();

                if (rdr.HasRows)
                {

                    return true;


                }
                else
                {
                    return false;
                }


            }
            catch (Exception)
            {


                throw;

            }
            finally
            {
                connectionClose(sqlbaglanti);
            }

        }

        public static void bagisKanDeposuMerkeziEkle(kanDepo kandepo)
        {

            SqlConnection sqlbaglanti = openConnection();
            SqlCommand veriOku = new SqlCommand("INSERT INTO kanDeposu (kanDeposuId,kanGrubu,verilisTarihi,miktar,subeKodu) VALUES (@kanDeposuId,@kanGrubu,@verilisTarihi,@miktar,@subeKodu)", sqlbaglanti);

            veriOku.Parameters.AddWithValue("@kanDeposuId", kandepo.getKanDeposuId());
            veriOku.Parameters.AddWithValue("@kanGrubu", kandepo.getKanGrubu());
            veriOku.Parameters.AddWithValue("@verilisTarihi", kandepo.getVerilisTarihi());
            veriOku.Parameters.AddWithValue("@miktar", kandepo.getMiktar());
            veriOku.Parameters.AddWithValue("@subeKodu", kandepo.getSubeKodu());


            try
            {

                veriOku.ExecuteNonQuery();

            }
            catch (Exception)
            {


            }
            finally
            {
                connectionClose(sqlbaglanti);
            }

        }

        public static void bagisKanDeposuMerkeziSil(kanDepo kandepo)
        {

            SqlConnection sqlbaglanti = openConnection();
            SqlCommand veriOku = new SqlCommand("DELETE FROM kanDeposu WHERE kanDeposuId=@kanDeposuId", sqlbaglanti);

            veriOku.Parameters.AddWithValue("@kanDeposuId", kandepo.getKanDeposuId());



            try
            {

                veriOku.ExecuteNonQuery();

            }
            catch (Exception)
            {


            }
            finally
            {
                connectionClose(sqlbaglanti);
            }

        }

        public static void bagisKanDeposuMerkeziGuncelle(kanDepo kandepo)
        {

            SqlConnection sqlbaglanti = openConnection();
            SqlCommand veriOku = new SqlCommand("UPDATE kanDeposu SET kanGrubu=@kanGrubu,verilisTarihi=@verilisTarihi,miktar=@miktar,subeKodu=@subeKodu where kanDeposuId=@kanDeposuId", sqlbaglanti);

            veriOku.Parameters.AddWithValue("@kanDeposuId", kandepo.getKanDeposuId());
            veriOku.Parameters.AddWithValue("@kanGrubu", kandepo.getKanGrubu());
            veriOku.Parameters.AddWithValue("@verilisTarihi", kandepo.getVerilisTarihi());
            veriOku.Parameters.AddWithValue("@miktar", kandepo.getMiktar());
            veriOku.Parameters.AddWithValue("@subeKodu", kandepo.getSubeKodu());


            try
            {

                veriOku.ExecuteNonQuery();

            }
            catch (Exception)
            {


            }
            finally
            {
                connectionClose(sqlbaglanti);
            }

        }

        public static bool tedarikBagisMerkeziHastaneArama(tedarikk tedarikk)
        {

            SqlConnection sqlbaglanti = openConnection();
            try
            {

                SqlCommand veriOku = new SqlCommand("select subeKodu,hastaneKodu from kanBagisMerkezi,hastane where subeKodu=@subeNo and hastaneKodu=@hastaneKodu ", sqlbaglanti);

                veriOku.Parameters.AddWithValue("@subeNo", tedarikk.getSubeKodu());
                veriOku.Parameters.AddWithValue("@hastaneKodu", tedarikk.getHastaneKodu());


                SqlDataReader rdr = veriOku.ExecuteReader();
                rdr.Read();

                if (rdr.HasRows)
                {

                    return true;


                }
                else
                {
                    return false;
                }


            }
            catch (Exception)
            {


                throw;

            }
            finally
            {
                connectionClose(sqlbaglanti);
            }

        }

        public static void tedarikEkle(tedarikk tedarikk)
        {

            SqlConnection sqlbaglanti = openConnection();
            SqlCommand veriOku = new SqlCommand("INSERT INTO tedarik (subeKodu,hastaneKodu,alinmaTarihi,kanGrubu,miktar) VALUES (@subeKodu,@hastaneKodu,@alinmaTarihi,@kanGrubu,@miktar)", sqlbaglanti);

            veriOku.Parameters.AddWithValue("@subeKodu", tedarikk.getSubeKodu());
            veriOku.Parameters.AddWithValue("@hastaneKodu", tedarikk.getHastaneKodu());
            veriOku.Parameters.AddWithValue("@kanGrubu", tedarikk.getKanGrubu());
            veriOku.Parameters.AddWithValue("@alinmaTarihi", tedarikk.getAlinmaTarihi());
            veriOku.Parameters.AddWithValue("@miktar", tedarikk.getMiktar());
            


            try
            {

                veriOku.ExecuteNonQuery();

            }
            catch (Exception)
            {


            }
            finally
            {
                connectionClose(sqlbaglanti);
            }

        }

        public static void tedarikSil(tedarikk tedarikk)
        {

            SqlConnection sqlbaglanti = openConnection();
            SqlCommand veriOku = new SqlCommand("DELETE FROM tedarik WHERE subeKodu=@subeKodu and hastaneKodu=@hastaneKodu and kanGrubu=@kanGrubu and alinmaTarihi=@alinmaTarihi and miktar=@miktar", sqlbaglanti);

            veriOku.Parameters.AddWithValue("@subeKodu", tedarikk.getSubeKodu());
            veriOku.Parameters.AddWithValue("@hastaneKodu", tedarikk.getHastaneKodu());
            veriOku.Parameters.AddWithValue("@kanGrubu", tedarikk.getKanGrubu());
            veriOku.Parameters.AddWithValue("@alinmaTarihi", tedarikk.getAlinmaTarihi());
            veriOku.Parameters.AddWithValue("@miktar", tedarikk.getMiktar());



            try
            {

                veriOku.ExecuteNonQuery();

            }
            catch (Exception)
            {


            }
            finally
            {
                connectionClose(sqlbaglanti);
            }

        }

        public static void tedarikGuncelle(tedarikk tedarikk)
        {

            SqlConnection sqlbaglanti = openConnection();
            SqlCommand veriOku = new SqlCommand("UPDATE tedarik SET alinmaTarihi=@alinmaTarihi,kanGrubu=@kanGrubu,miktar=@miktar where subeKodu=@subeKodu and hastaneKodu=@hastaneKodu", sqlbaglanti);

            veriOku.Parameters.AddWithValue("@subeKodu", tedarikk.getSubeKodu());
            veriOku.Parameters.AddWithValue("@hastaneKodu", tedarikk.getHastaneKodu());
            veriOku.Parameters.AddWithValue("@alinmaTarihi", tedarikk.getAlinmaTarihi());
            veriOku.Parameters.AddWithValue("@kanGrubu", tedarikk.getKanGrubu());
            veriOku.Parameters.AddWithValue("@miktar", tedarikk.getMiktar());
            


            try
            {

                veriOku.ExecuteNonQuery();

            }
            catch (Exception)
            {


            }
            finally
            {
                connectionClose(sqlbaglanti);
            }

        }


        public static bool hastaneArama(Hasta hasta)
        {

            SqlConnection sqlbaglanti = openConnection();
            try
            {

                SqlCommand veriOku = new SqlCommand("select hastaneKodu from hastane where hastaneKodu=@hastaneKodu", sqlbaglanti);

                veriOku.Parameters.AddWithValue("@hastaneKodu", hasta.getHastaneKodu());
               


                SqlDataReader rdr = veriOku.ExecuteReader();
                rdr.Read();

                if (rdr.HasRows)
                {

                    return true;


                }
                else
                {
                    return false;
                }


            }
            catch (Exception)
            {


                throw;

            }
            finally
            {
                connectionClose(sqlbaglanti);
            }

        }

        public static bool hastaArama(Hasta hasta)
        {

            SqlConnection sqlbaglanti = openConnection();
            try
            {

                SqlCommand veriOku = new SqlCommand("select kimlikNo from hasta where kimlikNo=@kimlikNo", sqlbaglanti);

                veriOku.Parameters.AddWithValue("@kimlikNo", hasta.getKimlikNo());



                SqlDataReader rdr = veriOku.ExecuteReader();
                rdr.Read();

                if (rdr.HasRows)
                {

                    return true;


                }
                else
                {
                    return false;
                }


            }
            catch (Exception)
            {


                throw;

            }
            finally
            {
                connectionClose(sqlbaglanti);
            }

        }

        public static void hastaEkle(Hasta hasta)
        {

            SqlConnection sqlbaglanti = openConnection();
            SqlCommand veriOku = new SqlCommand("INSERT INTO hasta (kimlikNo,adi,soyadi,kanGrubu,adresi,telefonNumarasi,hastaneKodu) VALUES (@kimlikNo,@adi,@soyadi," +
                                                    "@kanGrubu,@adresi,@telefonNumarasi,@hastaneKodu)", sqlbaglanti);

            veriOku.Parameters.AddWithValue("@kimlikNo", hasta.getKimlikNo());
            veriOku.Parameters.AddWithValue("@adi", hasta.getAdi());
            veriOku.Parameters.AddWithValue("@soyadi", hasta.getSoyadi());
            veriOku.Parameters.AddWithValue("@kanGrubu", hasta.getKanGrubu());
            veriOku.Parameters.AddWithValue("@adresi", hasta.getAdresi());
            veriOku.Parameters.AddWithValue("@telefonNumarasi", hasta.getTelNo());
            veriOku.Parameters.AddWithValue("@hastaneKodu", hasta.getHastaneKodu());

            try
            {

                veriOku.ExecuteNonQuery();

            }
            catch (Exception)
            {



                MessageBox.Show("alanları doğru giriniz lütfen!!!");

            }
            finally
            {
                connectionClose(sqlbaglanti);
            }

        }

        public static void hastaSil(Hasta hasta)
        {
            SqlConnection sqlbaglanti = openConnection();

            SqlCommand veriOku = new SqlCommand("DELETE FROM hasta where kimlikNo=@tcNo", sqlbaglanti);

            veriOku.Parameters.AddWithValue("@tcNo", hasta.getKimlikNo());
            veriOku.ExecuteNonQuery();
            connectionClose(sqlbaglanti);


        }

        public static void hastaGuncelle(Hasta hasta)
        {

            SqlConnection sqlbaglanti = openConnection();
            SqlCommand veriOku = new SqlCommand("UPDATE hasta SET adi=@adi,soyadi=@soyadi,kanGrubu=@kanGrubu," +
                                                "adresi=@adres,telefonNumarasi=@telefonNumarasi,hastaneKodu=@hastaneKodu where kimlikNo=@kimlikNo", sqlbaglanti);

            veriOku.Parameters.AddWithValue("@kimlikNo", hasta.getKimlikNo());
            veriOku.Parameters.AddWithValue("@adi", hasta.getAdi());
            veriOku.Parameters.AddWithValue("@soyadi", hasta.getSoyadi());
            veriOku.Parameters.AddWithValue("@kanGrubu", hasta.getKanGrubu());
            veriOku.Parameters.AddWithValue("@adres", hasta.getAdresi());
            veriOku.Parameters.AddWithValue("@telefonNumarasi", hasta.getTelNo());
            veriOku.Parameters.AddWithValue("@hastaneKodu", hasta.getHastaneKodu());

            try
            {

                veriOku.ExecuteNonQuery();

            }
            catch (Exception)
            {



                throw;

            }
            finally
            {
                connectionClose(sqlbaglanti);
            }
        }

        public static bool hastaneeArama(Hastane hastane)
        {

            SqlConnection sqlbaglanti = openConnection();
            try
            {

                SqlCommand veriOku = new SqlCommand("select hastaneKodu from hastane where hastaneKodu=@hastaneKodu", sqlbaglanti);

                veriOku.Parameters.AddWithValue("@hastaneKodu", hastane.getHastaneKodu());



                SqlDataReader rdr = veriOku.ExecuteReader();
                rdr.Read();

                if (rdr.HasRows)
                {

                    return true;


                }
                else
                {
                    return false;
                }


            }
            catch (Exception)
            {


                throw;

            }
            finally
            {
                connectionClose(sqlbaglanti);
            }

        }

        public static void hastaneEkle(Hastane hastane)
        {

            SqlConnection sqlbaglanti = openConnection();
            SqlCommand veriOku = new SqlCommand("INSERT INTO hastane (hastaneKodu,adi,adresi) VALUES (@hastaneKodu,@adi,@adresi)", sqlbaglanti);

            veriOku.Parameters.AddWithValue("@hastaneKodu", hastane.getHastaneKodu());
            veriOku.Parameters.AddWithValue("@adi", hastane.getAdi());
            veriOku.Parameters.AddWithValue("@adresi", hastane.getAdresi());
        
            try
            {

                veriOku.ExecuteNonQuery();

            }
            catch (Exception)
            {



              

            }
            finally
            {
                connectionClose(sqlbaglanti);
            }

        }

        public static void hastaneSil(Hastane hastane)
        {
            SqlConnection sqlbaglanti = openConnection();

            SqlCommand veriOku = new SqlCommand("DELETE FROM hastane where hastaneKodu=@hastaneKodu", sqlbaglanti);

            veriOku.Parameters.AddWithValue("@hastaneKodu", hastane.getHastaneKodu());
            veriOku.ExecuteNonQuery();
            connectionClose(sqlbaglanti);


        }

        public static void hastaneGuncelle(Hastane hastane)
        {

            SqlConnection sqlbaglanti = openConnection();
            SqlCommand veriOku = new SqlCommand("UPDATE hastane SET adi=@adi,adresi=@adres where hastaneKodu=@hastaneKodu", sqlbaglanti);

            veriOku.Parameters.AddWithValue("@hastaneKodu", hastane.getHastaneKodu());
            veriOku.Parameters.AddWithValue("@adi", hastane.getAdi());
            veriOku.Parameters.AddWithValue("@adres", hastane.getAdresi());
           
            

            try
            {

                veriOku.ExecuteNonQuery();

            }
            catch (Exception)
            {



                throw;

            }
            finally
            {
                connectionClose(sqlbaglanti);
            }
        }

        public static bool hastaneYoneticiArama(Yonetici yonetici)
        {

            SqlConnection sqlbaglanti = openConnection();
            try
            {

                SqlCommand veriOku = new SqlCommand("select * from Yonetici where yoneticiKodu=@yKodu " +
                                                    "and adi=@adi and soyadi=@soyadi and gorevKodu='222222'", sqlbaglanti);

                veriOku.Parameters.AddWithValue("@yKodu", yonetici.getYoneticiKodu());
                veriOku.Parameters.AddWithValue("@adi", yonetici.getYoneticiAdi());
                veriOku.Parameters.AddWithValue("@soyadi", yonetici.getYoneticiSoyadi());

                SqlDataReader rdr = veriOku.ExecuteReader();
                rdr.Read();
                if (rdr.HasRows)
                    return true;
                else
                    return false;

            }
            catch (Exception)
            {


                throw;

            }
            finally
            {
                connectionClose(sqlbaglanti);
            }

        }

        public static void hastaneYoneticiekle(Yonetici yonetici)
        {

            SqlConnection sqlbaglanti = openConnection();
            SqlCommand veriOku = new SqlCommand("INSERT INTO Yonetici (yoneticiKodu,adi,soyadi,parola,gorevKodu) VALUES (@yoneticiKodu,@adi,@soyadi,@parola,@gorevKodu)", sqlbaglanti);

            veriOku.Parameters.AddWithValue("@yoneticiKodu", yonetici.getYoneticiKodu());
            veriOku.Parameters.AddWithValue("@adi", yonetici.getYoneticiAdi());
            veriOku.Parameters.AddWithValue("@soyadi", yonetici.getYoneticiSoyadi());
            veriOku.Parameters.AddWithValue("@parola", yonetici.getYoneticiParola());
            veriOku.Parameters.AddWithValue("@gorevKodu", yonetici.getGorevKodu());


            try
            {

                veriOku.ExecuteNonQuery();

            }
            catch (Exception)
            {


            }
            finally
            {
                connectionClose(sqlbaglanti);
            }

        }

        public static void hastaneYoneticiSil(Yonetici yonetici)
        {

            SqlConnection sqlbaglanti = openConnection();
            SqlCommand veriOku = new SqlCommand("DELETE FROM Yonetici WHERE yoneticiKodu=@yoneticiKodu", sqlbaglanti);

            veriOku.Parameters.AddWithValue("@yoneticiKodu", yonetici.getYoneticiKodu());



            try
            {

                veriOku.ExecuteNonQuery();

            }
            catch (Exception)
            {


            }
            finally
            {
                connectionClose(sqlbaglanti);
            }

        }

        public static void hastaneYoneticiGuncelle(Yonetici yonetici)
        {

            SqlConnection sqlbaglanti = openConnection();
            SqlCommand veriOku = new SqlCommand("UPDATE Yonetici SET adi=@adi,soyadi=@soyadi,parola=@parola where yoneticiKodu=@yoneticiKodu", sqlbaglanti);

            veriOku.Parameters.AddWithValue("@yoneticiKodu", yonetici.getYoneticiKodu());
            veriOku.Parameters.AddWithValue("@adi", yonetici.getYoneticiAdi());
            veriOku.Parameters.AddWithValue("@soyadi", yonetici.getYoneticiSoyadi());
            veriOku.Parameters.AddWithValue("@parola", yonetici.getYoneticiParola());


            try
            {

                veriOku.ExecuteNonQuery();

            }
            catch (Exception)
            {


            }
            finally
            {
                connectionClose(sqlbaglanti);
            }

        }

        public static bool ilanArama(ilanlarr ilanlarr)
        {

            SqlConnection sqlbaglanti = openConnection();
            try
            {

                SqlCommand veriOku = new SqlCommand("select * from ilan where ilanKodu=@ilanKodu ", sqlbaglanti);

                veriOku.Parameters.AddWithValue("@ilanKodu", ilanlarr.getilanKodu());

                SqlDataReader rdr = veriOku.ExecuteReader();
                rdr.Read();
                if (rdr.HasRows)
                    return true;
                else
                    return false;

            }
            catch (Exception)
            {


                throw;

            }
            finally
            {
                connectionClose(sqlbaglanti);
            }

        }

        public static void ilanEkle(ilanlarr ilanlarr)
        {

            SqlConnection sqlbaglanti = openConnection();
            SqlCommand veriOku = new SqlCommand("INSERT INTO ilan (ilanKodu,ilanMetni,yoneticiKodu) VALUES (@ilanKodu,@ilanMetni,@yoneticiKodu)", sqlbaglanti);

            veriOku.Parameters.AddWithValue("@ilanKodu", ilanlarr.getYoneticiKodu());
            veriOku.Parameters.AddWithValue("@ilanMetni", ilanlarr.getilanMetini());
            veriOku.Parameters.AddWithValue("@yoneticiKodu", ilanlarr.getYoneticiKodu());


            try
            {

                veriOku.ExecuteNonQuery();

            }
            catch (Exception)
            {


            }
            finally
            {
                connectionClose(sqlbaglanti);
            }

        }

        public static void ilanSil(ilanlarr ilanlarr)
        {

            SqlConnection sqlbaglanti = openConnection();
            SqlCommand veriOku = new SqlCommand("DELETE FROM ilan WHERE ilanKodu=@ilanKodu", sqlbaglanti);

            veriOku.Parameters.AddWithValue("@ilanKodu", ilanlarr.getilanKodu());



            try
            {

                veriOku.ExecuteNonQuery();

            }
            catch (Exception)
            {


            }
            finally
            {
                connectionClose(sqlbaglanti);
            }

        }

        public static void ilanGuncelle(ilanlarr ilanlarr)
        {

            SqlConnection sqlbaglanti = openConnection();
            SqlCommand veriOku = new SqlCommand("UPDATE ilan SET ilanMetni=@ilanMetni,yoneticiKodu=@yoneticiKodu where ilanKodu=@ilanKodu", sqlbaglanti);

            veriOku.Parameters.AddWithValue("@yoneticiKodu", ilanlarr.getYoneticiKodu());
            veriOku.Parameters.AddWithValue("@ilanMetni", ilanlarr.getilanMetini());
            veriOku.Parameters.AddWithValue("@ilanKodu", ilanlarr.getilanKodu());


            try
            {

                veriOku.ExecuteNonQuery();

            }
            catch (Exception)
            {


            }
            finally
            {
                connectionClose(sqlbaglanti);
            }

        }
    }
}
