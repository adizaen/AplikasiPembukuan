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
    public class KaryawanController
    {
        private KaryawanRepository _repository;

        public int Create(Karyawan karyawan)
        {
            int result = 0;

            if (string.IsNullOrEmpty(karyawan.KodeKaryawan))
            {
                MessageBox.Show("Kode karyawan harus diisi !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(karyawan.Nama))
            {
                MessageBox.Show("Nama karyawan harus diisi !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(karyawan.Gender))
            {
                MessageBox.Show("Jenis kelamin karyawan harus diisi !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            using (DbContext context = new DbContext())
            {
                _repository = new KaryawanRepository(context);
                result = _repository.Create(karyawan);
            }

            if (result > 0)
                MessageBox.Show("Data karyawan berhasil disimpan dan akun baru berhasil dibuat!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Data karyawan gagal disimpan dan akun baru gagal dibuat!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return result;
        }

        public int Update(Karyawan karyawan)
        {
            int result = 0;

            if (string.IsNullOrEmpty(karyawan.KodeKaryawan))
            {
                MessageBox.Show("Kode karyawan harus diisi !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(karyawan.Nama))
            {
                MessageBox.Show("Nama karyawan harus diisi !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(karyawan.Gender))
            {
                MessageBox.Show("Jenis kelamin karyawan harus diisi !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            using (DbContext context = new DbContext())
            {
                _repository = new KaryawanRepository(context);
                result = _repository.Update(karyawan);
            }

            if (result > 0)
                MessageBox.Show("Data karyawan berhasil diupdate!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Data karyawan gagal diupdate!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return result;
        }

        public int Delete(Karyawan karyawan)
        {
            int result = 0;

            if (string.IsNullOrEmpty(karyawan.KodeKaryawan))
            {
                MessageBox.Show("Kode karyawan harus diisi !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            using (DbContext context = new DbContext())
            {
                _repository = new KaryawanRepository(context);
                result = _repository.Delete(karyawan);
            }

            if (result > 0)
                MessageBox.Show("Data karyawan berhasil dihapus!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Data karyawan gagal dihapus!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return result;
        }

        public List<Karyawan> ReadAll()
        {
            List<Karyawan> listOfKaryawan = new List<Karyawan>();

            using (DbContext context = new DbContext())
            {
                _repository = new KaryawanRepository(context);
                listOfKaryawan = _repository.ReadAll();
            }

            return listOfKaryawan;
        }

        public List<Karyawan> ReadCustom(string cari, int index)
        {
            List<Karyawan> listOfKaryawan = new List<Karyawan>();

            using (DbContext context = new DbContext())
            {
                _repository = new KaryawanRepository(context);
                listOfKaryawan = _repository.ReadCustom(cari, index);
            }

            return listOfKaryawan;
        }

        public string GetLastID()
        {
            string lastRow = "0";

            using (DbContext context = new DbContext())
            {
                _repository = new KaryawanRepository(context);
                lastRow = _repository.GetLastID();
            }

            return lastRow;
        }

    }
}
