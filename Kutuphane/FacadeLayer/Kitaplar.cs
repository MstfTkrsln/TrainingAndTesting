using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using EntityLayer;

namespace FacadeLayer
{
    public class Kitaplar
    {
        public static int Insert(Kitap kitap)
        {
            int etkilenen = 0;

            try
            {
                SqlCommand command = new SqlCommand("Kitap_Insert", Connection.Conn);

                command.CommandType = CommandType.StoredProcedure;

                if (command.Connection.State != ConnectionState.Open)
                    command.Connection.Open();

                command.Parameters.AddWithValue("ADI", kitap.ADI);
                command.Parameters.AddWithValue("YAZAR", kitap.YAZAR);
                command.Parameters.AddWithValue("SAYFASAYISI", kitap.SAYFASAYISI);
                command.Parameters.AddWithValue("KATEGORIID", kitap.KATEGORIID);

                etkilenen = command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                etkilenen = -1;
            }

            return etkilenen;

        }

        public static bool Update(Kitap kitap)
        {
            bool sonuc = false;

            try
            {
                SqlCommand command = new SqlCommand("Kitap_Update", Connection.Conn);

                command.CommandType = CommandType.StoredProcedure;

                if (command.Connection.State != ConnectionState.Open)
                    command.Connection.Open();

                command.Parameters.AddWithValue("ID", kitap.ID);
                command.Parameters.AddWithValue("ADI", kitap.ADI);
                command.Parameters.AddWithValue("YAZAR", kitap.YAZAR);
                command.Parameters.AddWithValue("SAYFASAYISI", kitap.SAYFASAYISI);
                command.Parameters.AddWithValue("KATEGORIID", kitap.KATEGORIID);

                sonuc = command.ExecuteNonQuery() > 0;
            }
            catch (Exception)
            {
                sonuc = false;
            }

            return sonuc;

        }

        public static bool Delete(int id)
        {
            bool sonuc = false;

            try
            {
                SqlCommand command = new SqlCommand("Kitap_Delete", Connection.Conn);

                command.CommandType = CommandType.StoredProcedure;

                if (command.Connection.State != ConnectionState.Open)
                    command.Connection.Open();


                command.Parameters.AddWithValue("ID", id);

                sonuc = command.ExecuteNonQuery() > 0;
            }
            catch (Exception)
            {
                sonuc = false;
            }

            return sonuc;

        }

        public static Kitap Select(int id)
        {
            Kitap kitap = null;

            try
            {
                SqlCommand command = new SqlCommand("Kitap_Select", Connection.Conn);

                command.CommandType = CommandType.StoredProcedure;

                if (command.Connection.State != ConnectionState.Open)
                    command.Connection.Open();


                command.Parameters.AddWithValue("ID", id);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                    while (reader.Read())
                    {
                        kitap = new Kitap();
                        kitap.ID = Convert.ToInt32(reader["ID"]);
                        kitap.ADI = reader["ADI"].ToString();
                        kitap.GMT = Convert.ToDateTime(reader["GMT"]); 
                        kitap.HOSTNAME = reader["HOSTNAME"].ToString();
                        kitap.KATEGORIID =Convert.ToInt32(reader["KATEGORIID"]);
                        kitap.SAYFASAYISI =Convert.ToInt16(reader["SAYFASAYISI"]);
                    }

                reader.Close();
            }
            catch (Exception)
            {
                kitap = null;
            }

            return kitap;

        }

        public static List<Kitap> SelectList()
        {
            List<Kitap> kitaplar = null;

            try
            {
                SqlCommand command = new SqlCommand("Kitap_SelectList", Connection.Conn);

                command.CommandType = CommandType.StoredProcedure;

                if (command.Connection.State != ConnectionState.Open)
                    command.Connection.Open();


                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    kitaplar = new List<Kitap>();
                    while (reader.Read())
                    {
                        Kitap kitap = new Kitap();
                        kitap.ID = Convert.ToInt32(reader["ID"]);
                        kitap.ADI = reader["ADI"].ToString();
                        kitap.YAZAR = reader["YAZAR"].ToString();
                        kitap.GMT = Convert.ToDateTime(reader["GMT"]);
                        kitap.HOSTNAME = reader["HOSTNAME"].ToString();
                        kitap.KATEGORIID = Convert.ToInt32(reader["KATEGORIID"]);
                        kitap.SAYFASAYISI = Convert.ToInt16(reader["SAYFASAYISI"]);
                        kitap.KATEGORIADI = reader["KATEGORIADI"].ToString();
                        kitaplar.Add(kitap);
                    }
                    reader.Close();
                }
            }
            catch (Exception)
            {
                kitaplar = null;
            }

            return kitaplar;

        }
    }
}
