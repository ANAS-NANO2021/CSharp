using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HastaneOtomasyonu.DbLayer
{
    class DbCommands
    {
        SqlCommand cmd;
        SqlDataReader dr;
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();

        private string query;
        public int StaffLogin(string username, string password)
        {
            // -2 = id pw boş bırakıldı
            // -1 = id || pw yanlış
            // 0= personel
            // 1= doktor 
            //2= yonetici
            int usertype;

            if (username.Length == 0 && password.Length == 0)
            {
                return -2;
            }
            else
            {

                query = "SELECT * FROM PERSONEL where USERNAME=@P1 AND PASWORD=@P2";
                cmd = new SqlCommand(query, DbConnection.conn);
                cmd.Parameters.AddWithValue("@P1", username);
                cmd.Parameters.AddWithValue("@P2", password);
                DbConnection.Connect();
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    usertype = Int32.Parse(dr["GOREVI"].ToString());
                    DbConnection.Disconnect();
                    dr.Close();
                    return usertype;
                }
                else
                {
                    DbConnection.Disconnect();
                    dr.Close();
                    return -1;
                }

            }
        }
        public string hastabilgigetir(string tc,string bilgi)
        {

            query = "SELECT *FROM HASTA where TC_NO=@P1";
            cmd = new SqlCommand(query, DbConnection.conn);
            cmd.Parameters.AddWithValue("@P1", tc);
            DbConnection.Connect();
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                string output = dr[bilgi].ToString();
                DbConnection.Disconnect();
                dr.Close();
                return output;
            }
            else
            {
                DbConnection.Disconnect();
                dr.Close();
                return null;
            }

        }
        public bool hastakayıt(string ad,string soyad, string tc,string cinsiyet,string dtarihi,string tel,string dyeri)
        {
            try
            {
                DbConnection.Connect();
                query = "INSERT INTO HASTA (ADI,SOYADI,TC_NO,CINSIYET,DOGUM_TARIHI,TEL,DOGUM_YERI) VALUES(@1,@2,@3,@4,@5,@6,@7)";
                cmd = new SqlCommand(query, DbConnection.conn);
                cmd.Parameters.AddWithValue("@1", ad);
                cmd.Parameters.AddWithValue("@2", soyad);
                cmd.Parameters.AddWithValue("@3", tc);
                cmd.Parameters.AddWithValue("@4", cinsiyet);
                cmd.Parameters.AddWithValue("@5", dtarihi);
                cmd.Parameters.AddWithValue("@6", tel);
                cmd.Parameters.AddWithValue("@7", dyeri);

                cmd.ExecuteNonQuery();

                return true;
            }
            catch (SqlException ex)
            {
                int errorno = ex.Number;
                switch (errorno)
                {
                    case 2627:
                        MessageBox.Show("Hasta Zaten Kayıtlı");
                        return false;
                    case 8152:
                        MessageBox.Show("Bilgiler Çok Uzun! Ad Soyad Max 50 Karakter,Cinsiyet Max 10 Karakter");
                        return false;


                    default:
                        MessageBox.Show(ex.Message.ToString() + ex.Number.ToString());
                        return false;

                }
            }
        }
        public bool randevukayıt(string d_id, string h_id, string b_id, string tarih)
        {
            try
            {
                DbConnection.Connect();
                query = "INSERT INTO RANDEVU (HASTA_ID,DOKTOR_ID,BRANS_ID,TARIH,MUAYENE_OLDU) VALUES(@1,@2,@3,@4,@5)";
                cmd = new SqlCommand(query, DbConnection.conn);
                cmd.Parameters.AddWithValue("@1", h_id);
                cmd.Parameters.AddWithValue("@2", d_id);
                cmd.Parameters.AddWithValue("@3", b_id);
                cmd.Parameters.AddWithValue("@4", tarih);
                cmd.Parameters.AddWithValue("@5", 0);



                cmd.ExecuteNonQuery();

                return true;
            }
            catch (SqlException ex)
            {
                int errorno = ex.Number;
                switch (errorno)
                {
                    case 2627:
                        MessageBox.Show("Hasta Zaten Kayıtlı");
                        return false;
                    case 8152:
                        MessageBox.Show("Bilgiler Çok Uzun! Ad Soyad Max 50 Karakter,Cinsiyet Max 10 Karakter");
                        return false;


                    default:
                        MessageBox.Show(ex.Message.ToString() + ex.Number.ToString());
                        return false;

                }
            }
        }
        public int getuseridbymail(string mail)
        {

            query = "SELECT PERSONEL_ID FROM PERSONEL where EPOSTA=@P1";
            cmd = new SqlCommand(query, DbConnection.conn);
            cmd.Parameters.AddWithValue("@P1", mail);
            DbConnection.Connect();
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                int personel_id = Int32.Parse(dr[0].ToString());
                DbConnection.Disconnect();
                dr.Close();
                return personel_id;
            }
            else
            {
                DbConnection.Disconnect();
                dr.Close();
                return -1;
            }

        }
        public int getuseridbyusername(string username)
        {

            query = "SELECT PERSONEL_ID FROM PERSONEL where username=@P1";
            cmd = new SqlCommand(query, DbConnection.conn);
            cmd.Parameters.AddWithValue("@P1", username);
            DbConnection.Connect();
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                int personel_id = Int32.Parse(dr[0].ToString());
                DbConnection.Disconnect();
                dr.Close();
                return personel_id;
            }
            else
            {
                DbConnection.Disconnect();
                dr.Close();
                return -1;
            }

        }
        public bool updatePwByuserid(int userid, string pw)
        {

            try
            {
                DbConnection.Connect();
                query = "UPDATE PERSONEL SET PASWORD=@P2 WHERE PERSONEL_ID=@P1";
                cmd = new SqlCommand(query, DbConnection.conn);
                cmd.Parameters.AddWithValue("@P1", userid);
                cmd.Parameters.AddWithValue("@P2", pw);


                cmd.ExecuteNonQuery();

                return true;
            }
            catch (SqlException ex)
            {
                int errorno = ex.Number;
                switch (errorno)
                {
                    case 2628:
                        MessageBox.Show("Girilen Şifre Cok Uzun!");
                        break;

                    default:
                        MessageBox.Show(ex.Message.ToString());
                        break;
                }
                return false;
            }
        }
        public String getpersonelnamebyid(int id)
        {

            query = "SELECT ADI,SOYADI FROM PERSONEL where PERSONEL_ID=@P1";
            cmd = new SqlCommand(query, DbConnection.conn);
            cmd.Parameters.AddWithValue("@P1", id);
            DbConnection.Connect();
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                string personelAD = dr[0].ToString() + " " + dr[1].ToString();
                DbConnection.Disconnect();
                dr.Close();
                return personelAD;
            }
            else
            {
                DbConnection.Disconnect();
                dr.Close();
                return "null";
            }

        }
        public DataSet polikliniklistesi()
        {

            try
            {

                DbConnection.Connect();
                query = @"SELECT *FROM BRANSLAR";
                da = new SqlDataAdapter(query, DbConnection.conn);
                ds.Clear();
                da.Fill(ds, "branslar");
                DbConnection.Disconnect();
                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return ds;
            }
        }
        public DataSet poliklinigegoredoktorlistesi(int id )
        {

            try
            {

                DbConnection.Connect();
                query = @"SELECT PERSONEL_ID,ADI,SOYADI FROM Personel Where Brans=@P1";
                
                da = new SqlDataAdapter(query, DbConnection.conn);
                da.SelectCommand.Parameters.AddWithValue("@P1", id);
                ds.Clear();
                da.Fill(ds, "doktorlarr");
                DbConnection.Disconnect();
                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return ds;
            }
        }
        public void InsertAnamez(int RandevuID,string Sikayet,string MuayeneBulgusu,string TedaviSonuc,string Notlar)
        {

            query = string.Format("EXEC [AnamezKaydet] {0},'{1}','{2}','{3}','{4}'",RandevuID,Sikayet,MuayeneBulgusu,TedaviSonuc,Notlar);
            SqlCommand cmd = new SqlCommand(query, DbConnection.conn);
            DbConnection.Connect();
             dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                if (dr["Mesaj"].ToString() != "")
                {
                    MessageBox.Show(dr["Mesaj"].ToString());
                    DbConnection.Disconnect();
                    dr.Close();
                    return;
                }


                DbConnection.Disconnect();
                dr.Close();
            }
            else
            {
                DbConnection.Disconnect();
                dr.Close();
                return ;
            }

        }
        public void Muayeneldu(int RandevuID)
        {

            query = string.Format("UPDATE RANDEVU SET MUAYENE_OLDU = 1 WHERE RANDEVU_ID = {0}", RandevuID);
            SqlCommand cmd = new SqlCommand(query, DbConnection.conn);
            DbConnection.Connect();
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                DbConnection.Disconnect();
                dr.Close();
            }
            else
            {
                DbConnection.Disconnect();
                dr.Close();
                return;
            }

        }
        public DataSet getmuayeneolmayanhastalarım(int userid, DateTime tarih)
        {
            string sqlFormattedDate =tarih.Date.ToString("yyyy-MM-dd");
   
            try
            {
               
                DbConnection.Connect();
                query = @"SELECT
      H.ADI,H.SOYADI,
	  H.CINSIYET,
	  H.TEL,
	  YAS = DATEDIFF(YEAR,H.DOGUM_TARIHI,GETDATE()) -CASE WHEN DATEADD(YY,DATEDIFF(YEAR,H.DOGUM_TARIHI,GETDATE()),H.DOGUM_TARIHI)>GETDATE() THEN 1 ELSE 0 END,R.RANDEVU_ID
	  FROM RANDEVU R,
	  HASTA H
	  WHERE R.HASTA_ID = H.HASTA_ID AND R.MUAYENE_OLDU = 0 AND R.DOKTOR_ID = @P1 AND R.TARIH = @P2";
                da = new SqlDataAdapter(query, DbConnection.conn);
                ds.Clear();
                da.SelectCommand.Parameters.AddWithValue("@P1", userid);
                da.SelectCommand.Parameters.AddWithValue("@P2", sqlFormattedDate);
                da.Fill(ds, "Muayene Olmayanlar");
                DbConnection.Disconnect();
                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return ds;
            }
        }
        public DataSet getmuayeneolanastalarım(int userid, DateTime tarih)
        {
            string sqlFormattedDate = tarih.Date.ToString("yyyy-MM-dd");

            try
            {

                DbConnection.Connect();
                query = @"SELECT
      H.ADI,H.SOYADI,
	  H.CINSIYET,
	  H.TEL,
	  YAS = DATEDIFF(YEAR,H.DOGUM_TARIHI,GETDATE()) -CASE WHEN DATEADD(YY,DATEDIFF(YEAR,H.DOGUM_TARIHI,GETDATE()),H.DOGUM_TARIHI)>GETDATE() THEN 1 ELSE 0 END,R.RANDEVU_ID
	  FROM RANDEVU R,
	  HASTA H
	  WHERE R.HASTA_ID = H.HASTA_ID AND R.MUAYENE_OLDU = 1 AND R.DOKTOR_ID =@P1 AND R.TARIH = @P2";
                da = new SqlDataAdapter(query, DbConnection.conn);
                ds.Clear();
                da.SelectCommand.Parameters.AddWithValue("@P1", userid);
                da.SelectCommand.Parameters.AddWithValue("@P2", sqlFormattedDate);
                da.Fill(ds, "Muayene Olanlar");
                DbConnection.Disconnect();
                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return ds;
            }
        }
        public String randevusikayetgetir(int randevuid)
        {

            query = "SELECT SIKAYET FROM ANAMEZ where RANDEVU_ID=@P1";
            cmd = new SqlCommand(query, DbConnection.conn);
            cmd.Parameters.AddWithValue("@P1", randevuid);
            DbConnection.Connect();
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                string sikayet = dr[0].ToString();
                DbConnection.Disconnect();
                dr.Close();
                return sikayet;
            }
            else
            {
                DbConnection.Disconnect();
                dr.Close();
                return "";
            }

        }
        public String randevumuayenebulgusugetir(int randevuid)
        {

            query = "SELECT MUAYENE_BULGU FROM ANAMEZ where RANDEVU_ID=@P1";
            cmd = new SqlCommand(query, DbConnection.conn);
            cmd.Parameters.AddWithValue("@P1", randevuid);
            DbConnection.Connect();
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                string bulgu = dr[0].ToString();
                DbConnection.Disconnect();
                dr.Close();
                return bulgu;
            }
            else
            {
                DbConnection.Disconnect();
                dr.Close();
                return "";
            }

        }
        public String randevunotugetirr(int randevuid)
        {

            query = "SELECT NOTLAR FROM ANAMEZ where RANDEVU_ID=@P1";
            cmd = new SqlCommand(query, DbConnection.conn);
            cmd.Parameters.AddWithValue("@P1", randevuid);
            DbConnection.Connect();
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                string not = dr[0].ToString();
                DbConnection.Disconnect();
                dr.Close();
                return not;
            }
            else
            {
                DbConnection.Disconnect();
                dr.Close();
                return "";
            }

        }
        public DataSet randevuilacgetir(int randevuid)
        {
        

            try
            {
                ds.Clear();
                DbConnection.Connect();
                query = @"SELECT I.ADI, RC.ACIKLAMA , I.ID
                    FROM     RANDEVU AS R INNER JOIN
                  RANDEVU_RECETE AS RC LEFT OUTER JOIN
                  ILACLAR AS I ON I.ID = RC.ILAC_ID ON R.RANDEVU_ID = RC.RANDEVU_ID
                    WHERE  (R.RANDEVU_ID = @P1)";
                da = new SqlDataAdapter(query, DbConnection.conn);
                
                da.SelectCommand.Parameters.AddWithValue("@P1", randevuid);
                da.Fill(ds, "ilaclar");
                DbConnection.Disconnect();
                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return ds;
            }
        }
        public DataSet Ilacgetir()
        {


            try
            {
                ds.Clear();
                DbConnection.Connect();
                query = @"SELECT ID,ADI,BARKOD FROM ILACLAR";
                da = new SqlDataAdapter(query, DbConnection.conn);
                da.Fill(ds, "ilaclar");
                DbConnection.Disconnect();
                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return ds;
            }
        }
        public DataSet tanigetir()
        {


            try
            {
                ds.Clear();
                DbConnection.Connect();
                query = @"SELECT *FROM TANILAR";
                da = new SqlDataAdapter(query, DbConnection.conn);
                da.Fill(ds, "tanılar");
                DbConnection.Disconnect();
                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return ds;
            }
        }
        public DataSet randevutanigetir(int randevuid)
        {


            try
            {
                ds.Clear();
                DbConnection.Connect();
                query = @"SELECT T.ADI,T.KOD,T.ID FROM RANDEVU R ,
              RANDEVU_TANI RT
			  LEFT OUTER JOIN TANILAR T
			  ON T.ID = RT.TANI_ID
			  WHERE RT.RANDEVU_ID = R.RANDEVU_ID AND R.RANDEVU_ID = @P1";
                da = new SqlDataAdapter(query, DbConnection.conn);
              
                da.SelectCommand.Parameters.AddWithValue("@P1", randevuid);
                da.Fill(ds, "tanilar");
                DbConnection.Disconnect();
                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return ds;
            }
        }
        public string randevumuayenesonucgetir(int randevuid)
        {

            query = "SELECT TEDAVI_SONUC FROM ANAMEZ where RANDEVU_ID=@P1";
            cmd = new SqlCommand(query, DbConnection.conn);
            cmd.Parameters.AddWithValue("@P1", randevuid);
            DbConnection.Connect();
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                string muayenesonuc = dr[0].ToString();
                DbConnection.Disconnect();
                dr.Close();
                return muayenesonuc;
            }
            else
            {
                DbConnection.Disconnect();
                dr.Close();
                return "";
            }
        }
        public bool taniekle(int randevuid, int taniid)
        {
            try
            {
                DbConnection.Connect();
                query = string.Format("INSERT INTO  RANDEVU_TANI (RANDEVU_ID,TANI_ID) VALUES({0},{1})", randevuid, taniid);
                cmd = new SqlCommand(query, DbConnection.conn);

                cmd.ExecuteNonQuery();

                return true;
            }
            catch (SqlException ex)
            {
                int errorno = ex.Number;
                switch (errorno)
                {
                    case 2627:
                        MessageBox.Show("Tanı Zaten eklenmiş");
                        return false;
                       

                    default:
                        MessageBox.Show(ex.Message.ToString()+ex.Number.ToString());
                        return false;
                       
                }
            }
        }
        public bool tanisil (int randevuid,int taniid)
        {
            try
            {
                DbConnection.Connect();
                query = "DELETE RANDEVU_TANI WHERE RANDEVU_ID=@P1 AND TANI_ID=@P2";
                cmd = new SqlCommand(query, DbConnection.conn);
                cmd.Parameters.AddWithValue("@P1", randevuid);
                cmd.Parameters.AddWithValue("@P2", taniid);

                cmd.ExecuteNonQuery();

                return true;
            }
            catch (SqlException ex)
            {
                int errorno = ex.Number;
                switch (errorno)
                {


                    default:
                        MessageBox.Show(ex.Message.ToString());
                        break;
                }
                return false;
            }
        }
        public bool ilacsil(int randevuid, int ilacid)
        {
            try
            {
                DbConnection.Connect();
                query = "DELETE RANDEVU_RECETE WHERE RANDEVU_ID=@P1 AND ILAC_ID=@P2";
                cmd = new SqlCommand(query, DbConnection.conn);
                cmd.Parameters.AddWithValue("@P1", randevuid);
                cmd.Parameters.AddWithValue("@P2", ilacid);

                cmd.ExecuteNonQuery();

                return true;
            }
            catch (SqlException ex)
            {
                int errorno = ex.Number;
                switch (errorno)
                {


                    default:
                        MessageBox.Show(ex.Message.ToString());
                        break;
                }
                return false;
            }
        }
        public bool ilacEkle(int randevuid, int ilacid,string Aciklama)
        {
            try
            {
                DbConnection.Connect();
                query = string.Format("INSERT INTO  RANDEVU_RECETE (RANDEVU_ID,ACIKLAMA,ILAC_ID) VALUES({0},'{1}',{2})",randevuid,Aciklama,ilacid);
                cmd = new SqlCommand(query, DbConnection.conn);

                cmd.ExecuteNonQuery();

                return true;
            }
            catch (SqlException ex)
            {
                int errorno = ex.Number;
                switch (errorno)
                {


                    default:
                        MessageBox.Show(ex.Message.ToString());
                        break;
                }
                return false;
            }
        }
        public int countHasta()
        {
            query = "SELECT COUNT(*) FROM HASTA";
            DbConnection.Connect();
            cmd = new SqlCommand(query, DbConnection.conn);
            Int32 count = (Int32)cmd.ExecuteScalar();
            DbConnection.Disconnect();
            return count;
        }
        public int countPersonel()
        {
            query = "SELECT COUNT(*) FROM PERSONEL";
            DbConnection.Connect();
            cmd = new SqlCommand(query, DbConnection.conn);
            Int32 count = (Int32)cmd.ExecuteScalar();
            DbConnection.Disconnect();
            return count;
        }
        public int countRandevu()
        {
            query = "SELECT COUNT(*) FROM RANDEVU";
            DbConnection.Connect();
            cmd = new SqlCommand(query, DbConnection.conn);
            Int32 count = (Int32)cmd.ExecuteScalar();
            DbConnection.Disconnect();
            return count;
        }
        public DataSet bransgetir()
        {


            try
            {
                ds.Clear();
                DbConnection.Connect();
                query = @"SELECT *FROM BRANSLAR";
                da = new SqlDataAdapter(query, DbConnection.conn);
                da.Fill(ds, "brans");
                DbConnection.Disconnect();
                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return ds;
            }
        }
        public bool personelkayıt(string ad, string soyad, string tc, string tel,DateTime dtarihi,int doktor,int gorev,int brans,string uid,string pw,string eposta)
        {
            string sqlFormattedDate = dtarihi.Date.ToString("yyyy-MM-dd");
            try
            {
                DbConnection.Connect();
                query = "INSERT INTO PERSONEL (ADI,SOYADI,TC_NO,TEL,DOGUM_TARIHI,DOKTOR,GOREVI,BRANS,USERNAME,PASWORD,EPOSTA) VALUES(@1,@2,@3,@4,@5,@6,@7,@8,@9,@10,@11)";
                cmd = new SqlCommand(query, DbConnection.conn);
                cmd.Parameters.AddWithValue("@1", ad);
                cmd.Parameters.AddWithValue("@2", soyad);
                cmd.Parameters.AddWithValue("@3", tc);
                cmd.Parameters.AddWithValue("@4", tel);
                cmd.Parameters.AddWithValue("@5", sqlFormattedDate);
                cmd.Parameters.AddWithValue("@6", doktor);
                cmd.Parameters.AddWithValue("@7", gorev);
                cmd.Parameters.AddWithValue("@8", brans);
                cmd.Parameters.AddWithValue("@9", uid);
                cmd.Parameters.AddWithValue("@10", pw);
                cmd.Parameters.AddWithValue("@11", eposta);



                cmd.ExecuteNonQuery();

                return true;
            }
            catch (SqlException ex)
            {
                int errorno = ex.Number;
                switch (errorno)
                {
                    case 2627:
                        MessageBox.Show("tc no e posta kullanıcı adı benzersiz olmalıdır");
                        return false;

                    default:
                        MessageBox.Show(ex.Message.ToString() + ex.Number.ToString());
                        return false;

                }
            }
        }
        public DataSet tumhastalar()
        {


            try
            {
                ds.Clear();
                DbConnection.Connect();
                query = @"SELECT ADI,SOYADI,CINSIYET,TC_NO AS 'TC KİMLİK NO',DOGUM_TARIHI AS 'DOGUM TARİHİ',TEL AS 'TELEFON' FROM HASTA";
                da = new SqlDataAdapter(query, DbConnection.conn);
                da.Fill(ds, "HASTA");
                DbConnection.Disconnect();
                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return ds;
            }
        }
        public DataSet tumpersoneller()
        {


            try
            {
                ds.Clear();
                DbConnection.Connect();
                query = @"SELECT PERSONEL_ID AS 'P.NO',ADI,SOYADI,TC_NO AS 'TC',TEL AS 'GSM',DOGUM_TARIHI AS 'DOGUM TARIHI',USERNAME AS 'K.ADI',PASWORD AS 'ŞİFRE',EPOSTA FROM PERSONEL";
                da = new SqlDataAdapter(query, DbConnection.conn);
                da.Fill(ds, "PERSONEL");
                DbConnection.Disconnect();
                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return ds;
            }
        }
        public bool personelsil(int personelid)
        {
            try
            {
                DbConnection.Connect();
                query = "DELETE PERSONEL WHERE PERSONEL_ID=@P1";
                cmd = new SqlCommand(query, DbConnection.conn);
                cmd.Parameters.AddWithValue("@P1", personelid);

                cmd.ExecuteNonQuery();

                return true;
            }
            catch (SqlException ex)
            {
                int errorno = ex.Number;
                switch (errorno)
                {


                    default:
                        MessageBox.Show(ex.Message.ToString());
                        break;
                }
                return false;
            }
        }

    }


    }

