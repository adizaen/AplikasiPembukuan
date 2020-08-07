﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using AplikasiPembukuan.Model.Context;
using AplikasiPembukuan.Model.Entity;

namespace AplikasiPembukuan.Model.Repository
{
    public class AkunRepository
    {
        private MySqlConnection _conn;

        public AkunRepository(DbContext context)
        {
            _conn = context.Conn;
        }

        public int Create(Akun akun)
        {
            int result = 0;

            string sql = @"INSERT INTO Akun VALUES (@KodeKaryawan, @Username, @Password, @HakAkses)";

            using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@KodeKaryawan", akun.KodeKaryawan);
                cmd.Parameters.AddWithValue("@Username", akun.Username);
                cmd.Parameters.AddWithValue("@Password", akun.Password);
                cmd.Parameters.AddWithValue("@HakAkses", akun.HakAkses);

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

        public int Update(Akun akun)
        {
            int result = 0;

            string sql = @"UPDATE Akun SET Username = @Username, Password = @Password, HakAkses = @HakAkses
                        WHERE KodeKaryawan = @KodeKaryawan";

            using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@Username", akun.Username);
                cmd.Parameters.AddWithValue("@Password", akun.Password);
                cmd.Parameters.AddWithValue("@HakAkses", akun.HakAkses);
                cmd.Parameters.AddWithValue("@KodeKaryawan", akun.KodeKaryawan);

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

        public Akun IsValidAccess(Akun akunLogin)
        {
            var akun = new Akun();

            try
            {
                string sql = @"SELECT KodeKaryawan, Username, Password, HakAkses FROM Akun
                            WHERE Username LIKE BINARY @Username AND Password LIKE BINARY @Password";

                using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
                {
                    cmd.Parameters.AddWithValue("@Username", akunLogin.Username);
                    cmd.Parameters.AddWithValue("@Password", akunLogin.Password);

                    using (MySqlDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {
                            akun.Username = dtr["Username"].ToString();
                            akun.Password = dtr["Password"].ToString();
                            akun.HakAkses = dtr["HakAkses"].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("IsValidAccess error: {0}", ex.Message);
            }

            return akun;
        }
    }
}