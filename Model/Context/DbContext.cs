using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;

namespace AplikasiPembukuan.Model.Context
{
    public class DbContext : IDisposable
    {
        private MySqlConnection _conn;

        public MySqlConnection Conn
        {
            get { return _conn ?? (_conn = GetOpenConnection()); }

        }

        private MySqlConnection GetOpenConnection()
        {
            MySqlConnection conn = null;

            try
            {
                string connectionString = string.Format("server=localhost; Database=DbPembukuan; uid=root;");
                conn = new MySqlConnection(connectionString);
                conn.Open();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("Open Connection Error: {0}", ex.Message);
            }

            return conn;
        }

        public void Dispose()
        {
            if (_conn != null)
            {
                try
                {
                    if (_conn.State != ConnectionState.Closed) _conn.Close();
                }
                finally
                {
                    _conn.Dispose();
                }
            }

            GC.SuppressFinalize(this);
        }
    }
}
