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

            string sql = @"INSERT INTO Data VALUES (@Tanggal, @Lokasi)";

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
    }
}
