using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using AplikasiPembukuan.Model.Context;
using AplikasiPembukuan.Model.Entity;
using Dapper;

namespace AplikasiPembukuan.Model.Repository
{
    public class KaryawanRepository
    {
        private MySqlConnection _conn;

        public KaryawanRepository(DbContext context)
        {
            _conn = context.Conn;
        }

        public int Create(Karyawan karyawan)
        {
            int result = 0;

            string sql = @"INSERT INTO Karyawan VALUES (@KodeKaryawan, @Nama, @Gender, @Telepon)";

            using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@KodeKaryawan", karyawan.KodeKaryawan);
                cmd.Parameters.AddWithValue("@Nama", karyawan.Nama);
                cmd.Parameters.AddWithValue("@Gender", karyawan.Gender);
                cmd.Parameters.AddWithValue("@Telepon", karyawan.Telepon);

                try
                {
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Create error: {0}", ex.Message);
                }
            }

            return result;
        }

        public int Update(Karyawan karyawan)
        {
            int result = 0;

            string sql = @"UPDATE Karyawan SET Nama = @Nama, Gender = @Gender, Telepon = @Telepon 
                        WHERE KodeKaryawan = @KodeKaryawan";

            using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@Nama", karyawan.Nama);
                cmd.Parameters.AddWithValue("@Gender", karyawan.Gender);
                cmd.Parameters.AddWithValue("@Telepon", karyawan.Telepon);
                cmd.Parameters.AddWithValue("@KodeKaryawan", karyawan.KodeKaryawan);

                try
                {
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Update error: {0}", ex.Message);
                }
            }

            return result;
        }

        public int Delete(Karyawan karyawan)
        {
            int result = 0;

            string sql = @"DELETE FROM Karyawan WHERE KodeKaryawan = @kodeKaryawan";

            using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@KodeKaryawan", karyawan.KodeKaryawan);

                try
                {
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Delete error: {0}", ex.Message);
                }
            }

            return result;
        }

        public List<Karyawan> ReadAll()
        {
            List<Karyawan> listOfKaryawan = new List<Karyawan>();

            try
            {
                string sql = @"SELECT K.KodeKaryawan, K.Nama, K.Gender, K.Telepon, A.HakAkses
                                FROM Karyawan K INNER JOIN Akun A ON K.KodeKaryawan = A.KodeKaryawan
                                ORDER BY K.KodeKaryawan ASC";

                using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
                {
                    using (MySqlDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {
                            var karyawan = new Karyawan();

                            karyawan.KodeKaryawan = dtr["KodeKaryawan"].ToString();
                            karyawan.Nama = dtr["Nama"].ToString();
                            karyawan.Gender = dtr["Gender"].ToString();
                            karyawan.Telepon = dtr["Telepon"].ToString();
                            karyawan.HakAkses = dtr["HakAkses"].ToString();

                            listOfKaryawan.Add(karyawan);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("ReadAll error: {0}", ex.Message);
            }

            return listOfKaryawan;
        }

        public List<Karyawan> ReadCustom(string cari, int index)
        {
            List<Karyawan> listOfKaryawan = new List<Karyawan>();

            try
            {
                string sql;

                if (index == 0)
                {
                    sql = @"SELECT K.KodeKaryawan, K.Nama, K.Gender, K.Telepon, A.HakAkses
                                FROM Karyawan K INNER JOIN Akun A ON K.KodeKaryawan = A.KodeKaryawan
                                WHERE K.Nama LIKE @Nama ORDER BY K.KodeKaryawan ASC";
                } 
                else
                {
                    sql = @"SELECT K.KodeKaryawan, K.Nama, K.Gender, K.Telepon, A.HakAkses
                                FROM Karyawan K INNER JOIN Akun A ON K.KodeKaryawan = A.KodeKaryawan
                                WHERE K.KodeKaryawan LIKE @KodeKaryawan ORDER BY K.KodeKaryawan ASC";
                }

                using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
                {
                    if (index == 0)
                        cmd.Parameters.AddWithValue("@Nama", "%" + cari + "%");
                    else
                        cmd.Parameters.AddWithValue("@KodeKaryawan", "%" + cari + "%");

                    using (MySqlDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {
                            var karyawan = new Karyawan();

                            karyawan.KodeKaryawan = dtr["KodeKaryawan"].ToString();
                            karyawan.Nama = dtr["Nama"].ToString();
                            karyawan.Gender = dtr["Gender"].ToString();
                            karyawan.Telepon = dtr["Telepon"].ToString();
                            karyawan.HakAkses = dtr["HakAkses"].ToString();

                            listOfKaryawan.Add(karyawan);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("ReadCustom error: {0}", ex.Message);
            }

            return listOfKaryawan;
        }

        public string GetLastID()
        {
            string lastID = "0";

            try
            {
                string sql = @"SELECT RIGHT(KodeKaryawan, 3) AS lastID FROM Karyawan ORDER BY KodeKaryawan DESC LIMIT 1";

                using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
                {
                    using (MySqlDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {
                            lastID = "KR" + (int.Parse(dtr["lastID"].ToString()) + 1).ToString("D3");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("GetLastID error: {0}", ex.Message);
            }

            return lastID;
        }
    }
}
