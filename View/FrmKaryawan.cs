using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AplikasiPembukuan.Controller;
using AplikasiPembukuan.Model.Entity;

namespace AplikasiPembukuan.View
{
    public partial class FrmKaryawan : Form
    {
        private List<Karyawan> listOfKaryawan = new List<Karyawan>();
        private List<Akun> listOfAkun = new List<Akun>();
        private KaryawanController controller;
        private AkunController controllerAkun;

        public FrmKaryawan()
        {
            InitializeComponent();
            controller = new KaryawanController();
            controllerAkun = new AkunController();
            InisiasiDatagrid();
            RefreshForm();
        }

        private void InisiasiDatagrid()
        {
            dgv.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgv.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.AllowUserToAddRows = false;
            dgv.MultiSelect = false;
            dgv.RowHeadersVisible = false;
            dgv.ReadOnly = true;
        }

        private void RefreshForm()
        {
            cmbKategori.SelectedIndex = 0;
            txtCari.Clear();
            txtCari.Focus();
            TampilData();
        }

        private void TampilData()
        {
            int noUrut = 0;

            dgv.Rows.Clear();
            listOfKaryawan = controller.ReadAll();

            foreach (var karyawan in listOfKaryawan)
            {
                noUrut = noUrut + 1;

                dgv.Rows.Add(noUrut.ToString(), karyawan.KodeKaryawan, karyawan.Nama,
                            karyawan.Gender, karyawan.Telepon, karyawan.HakAkses);
            }
        }

        private void PencarianData(int index)
        {
            int noUrut = 0;

            dgv.Rows.Clear();
            string cari = txtCari.Text;
            listOfKaryawan = controller.ReadCustom(cari, index);

            foreach (var karyawan in listOfKaryawan)
            {
                noUrut = noUrut + 1;

                dgv.Rows.Add(noUrut.ToString(), karyawan.KodeKaryawan, karyawan.Nama,
                            karyawan.Gender, karyawan.Telepon, karyawan.HakAkses);
            }
        }

        private void OnCreateEventHandler(Karyawan karyawan, Akun akun)
        {
            listOfKaryawan.Add(karyawan);
            listOfAkun.Add(akun);
            TampilData();
        }

        private void OnUpdateEventHandler(Karyawan karyawan, Akun akun)
        {
            int index = dgv.CurrentCell.RowIndex;

            DataGridViewRow row = (DataGridViewRow)dgv.Rows[index].Clone();

            row.Cells[1].Value = karyawan.KodeKaryawan;
            row.Cells[2].Value = karyawan.Nama;
            row.Cells[3].Value = karyawan.Gender;
            row.Cells[4].Value = karyawan.Telepon;
            row.Cells[5].Value = akun.HakAkses;

            TampilData();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            FrmInputKaryawan fInput = new FrmInputKaryawan("Tambah Data Karyawan", controller, controllerAkun);
            fInput.OnCreate += OnCreateEventHandler;
            fInput.ShowDialog();
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                Karyawan karyawan = listOfKaryawan[dgv.CurrentCell.RowIndex];

                FrmInputKaryawan fInput = new FrmInputKaryawan("Ubah Data Karyawan", karyawan, controller, controllerAkun);
                fInput.OnUpdate += OnUpdateEventHandler;
                fInput.ShowDialog();
            }
            else
            {
                MessageBox.Show("Data belum dipilih", "Peringatan", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                var konfirmasi = MessageBox.Show("INFO PENTING :" + "\n\n" + "Hapus data karyawan terpilih akan menghapus akun karyawan yang bersangkutan."
                                                + "\n\n" + "Apakah karyawan terpilih ingin dihapus?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (konfirmasi == DialogResult.Yes)
                {
                    Karyawan karyawan = listOfKaryawan[dgv.CurrentCell.RowIndex];

                    var result = controller.Delete(karyawan);

                    if (result > 0)
                        TampilData();
                }
            }
            else
            {
                MessageBox.Show("Data belum dipilih", "Peringatan", MessageBoxButtons.OK,
                       MessageBoxIcon.Exclamation);
            }
        }

        private void txtCari_TextChanged(object sender, EventArgs e)
        {
            if (cmbKategori.SelectedIndex == 0)
                PencarianData(0);
            else
                PencarianData(1);
        }

        private void cmbKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCari.Focus();
        }

        private void FrmKaryawan_Shown(object sender, EventArgs e)
        {
            cmbKategori.SelectedIndex = 0;
            txtCari.Focus();
        }
    }
}
