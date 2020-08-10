using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AplikasiPembukuan.Model.Context;
using AplikasiPembukuan.Model.Entity;
using AplikasiPembukuan.Model.Repository;

namespace AplikasiPembukuan.Controller
{
    public class DataController
    {
        private DataRepository _repository;

        public int Create(Data data)
        {
            int result = 0, result1 = 0;

            if (string.IsNullOrEmpty(data.Tanggal.ToString()))
            {
                MessageBox.Show("Tanggal backup harus diisi !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(data.Lokasi))
            {
                MessageBox.Show("Lokasi backup harus diisi !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            using (DbContext context = new DbContext())
            {
                _repository = new DataRepository(context);
                result = _repository.Create(data);
                result1 = _repository.BackupDB(data.Lokasi);
            }

            if (result > 0 && result1 > 0)
                MessageBox.Show("Database berhasil di backup!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Database gagal di backup!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return result;
        }

        public int RestoreDB(Data data)
        {
            int result = 0;

            if (string.IsNullOrEmpty(data.Lokasi))
            {
                MessageBox.Show("Lokasi backup harus diisi !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            using (DbContext context = new DbContext())
            {
                _repository = new DataRepository(context);
                result = _repository.RestoreDB(data.Lokasi);
            }

            if (result > 0)
                MessageBox.Show("Database berhasil di restore!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Database gagal di restore!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return result;
        }

        public Data ReadLastBackup()
        {
            var data = new Data();

            using (DbContext context = new DbContext())
            {
                _repository = new DataRepository(context);
                data = _repository.ReadLastBackup();
            }

            return data;
        }

        public int GetCountBackup()
        {
            int count = 0;

            using (DbContext context = new DbContext())
            {
                _repository = new DataRepository(context);
                count = _repository.GetCountBackup();
            }

            return count;
        }
    }
}
