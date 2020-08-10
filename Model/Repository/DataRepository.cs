using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using AplikasiPembukuan.Model.Context;
using AplikasiPembukuan.Model.Entity;

namespace AplikasiPembukuan.Model.Repository
{
    public class DataRepository
    {
        private MySqlConnection _conn;

        public DataRepository(DbContext context)
        {
            _conn = context.Conn;
        }

        public int Create(Data data)
        {
            int result = 0;

            string sql = @"INSERT INTO Data (Tanggal, Lokasi) VALUES (@Tanggal, @Lokasi)";

            using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@Tanggal", data.Tanggal);
                cmd.Parameters.AddWithValue("@Lokasi", data.Lokasi);

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

        public Data ReadLastBackup()
        {
            var data = new Data();

            try
            {
                string sql = @"SELECT*FROM Data ORDER BY ID DESC LIMIT 1";

                using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
                {
                    using (MySqlDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {
                            data.ID = dtr["ID"].ToString();
                            data.Tanggal = DateTime.Parse(dtr["Tanggal"].ToString());
                            data.Lokasi = dtr["Lokasi"].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("ReadLastBackup error: {0}", ex.Message);
            }

            return data;
        }

        public int GetCountBackup()
        {
            int count = 0;

            try
            {
                string sql = @"SELECT COUNT(*) AS count FROM Data";

                using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
                {
                    using (MySqlDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {
                            count = int.Parse(dtr["count"].ToString()) + 1;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("GetCountBackup error: {0}", ex.Message);
            }

            return count;
        }

        public int BackupDB(string filePath)
        {
            int result = 0;

            try
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    using (MySqlBackup backup = new MySqlBackup(cmd))
                    {
                        cmd.Connection = _conn;
                        backup.ExportToFile(filePath);
                        result = 1;
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("BackupDB error: {0}", ex.Message);
            }

            return result;
        }

        public int RestoreDB(string filePath)
        {
            int result = 0, result1 = 0;

            try
            {
                string sql = @"CALL DropTables()";

                using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
                {
                    try
                    {
                        result = cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        System.Diagnostics.Debug.Print("Drop table error: {0}", ex.Message);
                    }
                }

                using (MySqlCommand cmd = new MySqlCommand())
                {
                    using (MySqlBackup backup = new MySqlBackup(cmd))
                    {
                        cmd.Connection = _conn;
                        backup.ImportFromFile(filePath);
                        result1 = 1;
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("RestoreDB error: {0}", ex.Message);
            }

            return result1;
        }
    }
}
