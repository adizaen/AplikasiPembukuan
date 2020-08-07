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
    public class AkunController
    {
        private AkunRepository _repository;

        public int Create(Akun akun)
        {
            int result = 0;

            if (string.IsNullOrEmpty(akun.KodeKaryawan))
            {
                MessageBox.Show("Kode karyawan harus diisi !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(akun.Username))
            {
                MessageBox.Show("Username harus diisi !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(akun.Password))
            {
                MessageBox.Show("Password harus diisi !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            using (DbContext context = new DbContext())
            {
                _repository = new AkunRepository(context);
                result = _repository.Create(akun);
            }

            return result;
        }

        public int Update(Akun akun)
        {
            int result = 0;

            if (string.IsNullOrEmpty(akun.KodeKaryawan))
            {
                MessageBox.Show("Kode karyawan harus diisi !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(akun.Username))
            {
                MessageBox.Show("Username harus diisi !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(akun.Password))
            {
                MessageBox.Show("Password harus diisi !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            using (DbContext context = new DbContext())
            {
                _repository = new AkunRepository(context);
                result = _repository.Update(akun);
            }

            if (result > 0)
                MessageBox.Show("Data akun berhasil diupdate!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Data akun gagal diupdate!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return result;
        }
    }
}