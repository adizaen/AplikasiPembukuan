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
    public class PembukuanController
    {
        private PembukuanRepository _repository;

        public int Create(Pembukuan buku)
        {
            int result = 0;

            if (string.IsNullOrEmpty(buku.Tanggal.ToString()))
            {
                MessageBox.Show("Tanggal harus diisi !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(buku.Item))
            {
                MessageBox.Show("Nama item harus diisi !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            using (DbContext context = new DbContext())
            {
                _repository = new PembukuanRepository(context);
                result = _repository.Create(buku);
            }

            if (result > 0)
                MessageBox.Show("Data item berhasil ditambahkan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Data item gagal ditambahkan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return result;
        }

        public int Update(Pembukuan buku)
        {
            int result = 0;

            if (string.IsNullOrEmpty(buku.ID))
            {
                MessageBox.Show("ID harus diisi !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(buku.Tanggal.ToString()))
            {
                MessageBox.Show("Tanggal harus diisi !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(buku.Item))
            {
                MessageBox.Show("Nama item harus diisi !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            using (DbContext context = new DbContext())
            {
                _repository = new PembukuanRepository(context);
                result = _repository.Update(buku);
            }

            if (result > 0)
                MessageBox.Show("Data item berhasil diupdate!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Data item gagal diupdate!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return result;
        }

        public int Delete(Pembukuan buku)
        {
            int result = 0;

            if (string.IsNullOrEmpty(buku.ID))
            {
                MessageBox.Show("ID harus diisi !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(buku.Tanggal.ToString()))
            {
                MessageBox.Show("Tanggal harus diisi !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(buku.Item))
            {
                MessageBox.Show("Nama item harus diisi !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            using (DbContext context = new DbContext())
            {
                _repository = new PembukuanRepository(context);
                result = _repository.Delete(buku);
            }

            if (result > 0)
                MessageBox.Show("Data item berhasil dihapus!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Data item gagal dihapus!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return result;
        }

        public List<Pembukuan> ReadAll()
        {
            List<Pembukuan> listOfBuku = new List<Pembukuan>();

            using (DbContext context = new DbContext())
            {
                _repository = new PembukuanRepository(context);
                listOfBuku = _repository.ReadAll();
            }

            return listOfBuku;
        }

        public List<Pembukuan> ReadByDate(Pembukuan buku)
        {
            List<Pembukuan> listOfBuku = new List<Pembukuan>();

            using (DbContext context = new DbContext())
            {
                _repository = new PembukuanRepository(context);
                listOfBuku = _repository.ReadByDate(buku);
            }

            return listOfBuku;
        }

        public List<Pembukuan> ReadByMonth(int bulan)
        {
            List<Pembukuan> listOfBuku = new List<Pembukuan>();

            using (DbContext context = new DbContext())
            {
                _repository = new PembukuanRepository(context);
                listOfBuku = _repository.ReadByMonth(bulan);
            }

            return listOfBuku;
        }
    }
}
