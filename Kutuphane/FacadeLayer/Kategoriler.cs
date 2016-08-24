using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using EntityLayer;

namespace FacadeLayer
{
    public class Kategoriler
    {
        public static int Insert(Kategori kategori)
        {
            int etkilenen = 0;

            try
            {
                SqlCommand command = new SqlCommand("Kategori_Insert", Connection.Conn);

                command.CommandType = CommandType.StoredProcedure;

                if (command.Connection.State != ConnectionState.Open)
                    command.Connection.Open();

                command.Parameters.AddWithValue("ADI", kategori.ADI);

                etkilenen= command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                etkilenen = -1;
            }

            return etkilenen;

        }

        public static bool Update(Kategori kategori)
        {
            bool sonuc = false;

            try
            {
                SqlCommand command = new SqlCommand("Kategori_Update", Connection.Conn);

                command.CommandType = CommandType.StoredProcedure;

                if (command.Connection.State != ConnectionState.Open)
                    command.Connection.Open();

                command.Parameters.AddWithValue("ADI", kategori.ADI);
                command.Parameters.AddWithValue("ID", kategori.ID);

                sonuc = command.ExecuteNonQuery()>0;
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
                SqlCommand command = new SqlCommand("Kategori_Delete", Connection.Conn);

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

        public static Kategori Select(int id)
        {
            Kategori kategori = null;

            try
            {
                SqlCommand command = new SqlCommand("Kategori_Select", Connection.Conn);

                command.CommandType = CommandType.StoredProcedure;

                if (command.Connection.State != ConnectionState.Open)
                    command.Connection.Open();


                command.Parameters.AddWithValue("ID", id);

                SqlDataReader reader = command.ExecuteReader();

                if(reader.HasRows)
                    while (reader.Read())
                    {
                        kategori=new Kategori();
                        kategori.ID =Convert.ToInt32(reader["ID"]);
                        kategori.ADI = reader["ADI"].ToString();
                    }
                reader.Close();
            }
            catch (Exception)
            {
                kategori = null;
            }

            return kategori;

        }

        public static List<Kategori> SelectList()
        {
            List<Kategori> kategoriler = null;

            try
            {
                SqlCommand command = new SqlCommand("Kategori_SelectList", Connection.Conn);

                command.CommandType = CommandType.StoredProcedure;

                if (command.Connection.State != ConnectionState.Open)
                    command.Connection.Open();

                
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    kategoriler=new List<Kategori>();
                    while (reader.Read())
                    {
                        Kategori kategori = new Kategori();
                        kategori.ID = Convert.ToInt32(reader["ID"]);
                        kategori.ADI = reader["ADI"].ToString();
                        kategoriler.Add(kategori);
                    }

                    reader.Close();
                }
            }
            catch (Exception)
            {
                kategoriler = null;
            }

            return kategoriler;

        }
    }
}
