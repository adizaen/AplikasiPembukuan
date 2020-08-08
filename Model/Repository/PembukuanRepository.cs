using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using AplikasiPembukuan.Model.Context;
using AplikasiPembukuan.Model.Entity;

namespace AplikasiPembukuan.Model.Repository
{
    public class PembukuanRepository
    {
        private MySqlConnection _conn;

        public PembukuanRepository(DbContext context)
        {
            _conn = context.Conn;
        }

        public int Create(Pembukuan buku)
        {
            int result = 0;

            string sql = @"INSERT INTO Pembukuan (Tanggal, Item, Debit, Kredit, Saldo, Laba, Keterangan)
                        VALUES (@Tanggal, @Item, @Debit, @Kredit, @Saldo, @Laba, @Keterangan)";

            using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@Tanggal", buku.Tanggal);
                cmd.Parameters.AddWithValue("@Item", buku.Item);
                cmd.Parameters.AddWithValue("@Debit", buku.Debit);
                cmd.Parameters.AddWithValue("@Kredit", buku.Kredit);
                cmd.Parameters.AddWithValue("@Saldo", buku.Saldo);
                cmd.Parameters.AddWithValue("@Laba", buku.Laba);
                cmd.Parameters.AddWithValue("@Keterangan", buku.Keterangan);

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

        public int Update(Pembukuan buku)
        {
            int result = 0;

            string sql = @"UPDATE Pembukuan SET Tanggal = @Tanggal, Item = @Item, Debit = @Debit, Kredit = @Kredit,
                            Saldo = @Saldo, Laba = @Laba, Keterangan = @Keterangan WHERE ID = @ID";

            using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@Tanggal", buku.Tanggal);
                cmd.Parameters.AddWithValue("@Item", buku.Item);
                cmd.Parameters.AddWithValue("@Debit", buku.Debit);
                cmd.Parameters.AddWithValue("@Kredit", buku.Kredit);
                cmd.Parameters.AddWithValue("@Saldo", buku.Saldo);
                cmd.Parameters.AddWithValue("@Laba", buku.Laba);
                cmd.Parameters.AddWithValue("@Keterangan", buku.Keterangan);
                cmd.Parameters.AddWithValue("@ID", buku.ID);

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

        public int Delete(Pembukuan buku)
        {
            int result = 0, result1 = 0;
            string tanggal = buku.Tanggal.ToString("yyyyMMdd");

            string sql = @"CALL UpdateSaldo(@Tanggal, @ID, @Saldo, @Kredit, @Debit)";
            string sql1 = @"DELETE FROM Pembukuan WHERE ID = @ID";

            using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@Tanggal", tanggal);
                cmd.Parameters.AddWithValue("@ID", buku.ID);
                cmd.Parameters.AddWithValue("@Saldo", buku.Saldo);
                cmd.Parameters.AddWithValue("@Kredit", buku.Kredit);
                cmd.Parameters.AddWithValue("@Debit", buku.Debit);

                try
                {
                    result = cmd.ExecuteNonQuery();

                    using (MySqlCommand cmd1 = new MySqlCommand(sql1, _conn))
                    {
                        cmd1.Parameters.AddWithValue("@ID", buku.ID);

                        try
                        {
                            result1 = cmd1.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.Debug.Print("Delete error: {0}", ex.Message);
                        }
                    }
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Update saldo error: {0}", ex.Message);
                }
            }

            if (result > 0 && result1 > 0)
                return result;
            else
                return 0;
        }

        public List<Pembukuan> ReadAll()
        {
            List<Pembukuan> listOfBuku = new List<Pembukuan>();

            try
            {
                string sql = @"SELECT*FROM Pembukuan ORDER BY Tanggal ASC";

                using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
                {
                    using (MySqlDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {
                            var buku = new Pembukuan();

                            buku.ID = dtr["ID"].ToString();
                            buku.Tanggal = DateTime.Parse(dtr["Tanggal"].ToString());
                            buku.Item = dtr["Item"].ToString();
                            buku.Debit = double.Parse(dtr["Debit"].ToString());
                            buku.Kredit = double.Parse(dtr["Kredit"].ToString());
                            buku.Saldo = double.Parse(dtr["Saldo"].ToString());
                            buku.Laba = double.Parse(dtr["Laba"].ToString());
                            buku.Keterangan = dtr["Keterangan"].ToString();

                            listOfBuku.Add(buku);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("ReadAll error: {0}", ex.Message);
            }

            return listOfBuku;
        }

        public List<Pembukuan> ReadByDate(DateTime tanggal)
        {
            var formatTanggal = tanggal.ToString("yyyy-MM-dd");

            List<Pembukuan> listOfBuku = new List<Pembukuan>();

            try
            {
                string sql = @"SELECT*FROM Pembukuan WHERE Tanggal = @Tanggal";

                using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
                {
                    cmd.Parameters.AddWithValue("@Tanggal", formatTanggal);

                    using (MySqlDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {
                            var buku = new Pembukuan();

                            buku.ID = dtr["ID"].ToString();
                            buku.Tanggal = DateTime.Parse(dtr["Tanggal"].ToString());
                            buku.Item = dtr["Item"].ToString();
                            buku.Debit = double.Parse(dtr["Debit"].ToString());
                            buku.Kredit = double.Parse(dtr["Kredit"].ToString());
                            buku.Saldo = double.Parse(dtr["Saldo"].ToString());
                            buku.Laba = double.Parse(dtr["Laba"].ToString());
                            buku.Keterangan = dtr["Keterangan"].ToString();

                            listOfBuku.Add(buku);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("ReadByDate error: {0}", ex.Message);
            }

            return listOfBuku;
        }

        public List<Pembukuan> ReadByMonth(int bulan)
        {
            List<Pembukuan> listOfBuku = new List<Pembukuan>();

            try
            {
                string sql = @"SELECT SUM(Debit) AS totalDebit, SUM(Kredit) AS totalKredit, SUM(SALDO) AS totalSaldo
                            FROM Pembukuan WHERE MONTH(Tanggal) = @Bulan";

                using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
                {
                    cmd.Parameters.AddWithValue("@Bulan", bulan);

                    using (MySqlDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {
                            var buku = new Pembukuan();

                            buku.Debit = double.Parse(dtr["totalDebit"].ToString());
                            buku.Kredit = double.Parse(dtr["totalKredit"].ToString());
                            buku.Saldo = double.Parse(dtr["totalSaldo"].ToString());

                            listOfBuku.Add(buku);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("ReadByMonth error: {0}", ex.Message);
            }

            return listOfBuku;
        }

        public double GetLastSaldo(DateTime tanggal)
        {
            double saldo = 0;
            var formatTanggal = tanggal.ToString("yyyy-MM-dd");

            try
            {
                string sql = @"SELECT Saldo FROM Pembukuan WHERE Tanggal = @Tanggal ORDER BY ID DESC LIMIT 1";

                using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
                {
                    cmd.Parameters.AddWithValue("@Tanggal", formatTanggal);

                    using (MySqlDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {
                            saldo = double.Parse(dtr["Saldo"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("ReadLastSaldo error: {0}", ex.Message);
            }

            return saldo;
        }
    }
}