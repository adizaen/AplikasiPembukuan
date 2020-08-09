﻿using System;
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
    public partial class FrmLaporan : Form
    {
        private List<Pembukuan> listOfBuku = new List<Pembukuan>();
        private PembukuanController controller;

        public FrmLaporan()
        {
            InitializeComponent();
            controller = new PembukuanController();
            InisiasiDatagrid();
        }

        private void FrmLaporan_Shown(object sender, EventArgs e)
        {
            dgvHarian.Size = new Size(900, 490);
            dgvBulanan.Size = new Size(900, 490);
            dgvBulanan.Location = new Point(28, 111);
            dgvBulanan.Visible = false;

            rdoTanggal.Checked = true;
            rdoBulan.Checked = false;
            rdoTanggal.Focus();
        }

        private void InisiasiDatagrid()
        {
            dgvHarian.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvHarian.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvHarian.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvHarian.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvHarian.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvHarian.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvHarian.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvHarian.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvBulanan.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvBulanan.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvBulanan.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvBulanan.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvBulanan.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvHarian.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvHarian.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            dgvHarian.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHarian.AllowUserToAddRows = false;
            dgvHarian.MultiSelect = false;
            dgvHarian.RowHeadersVisible = false;
            dgvHarian.ReadOnly = true;

            dgvBulanan.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvBulanan.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            dgvBulanan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBulanan.AllowUserToAddRows = false;
            dgvBulanan.MultiSelect = false;
            dgvBulanan.RowHeadersVisible = false;
            dgvBulanan.ReadOnly = true;
        }

        private void TampilDataByDate(DateTime tanggal)
        {
            int noUrut = 0;

            dgvHarian.Rows.Clear();
            listOfBuku = controller.ReadByDate(tanggal);

            if (listOfBuku.Count != 0)
            {
                foreach (var buku in listOfBuku)
                {
                    noUrut = noUrut + 1;

                    dgvHarian.Rows.Add(noUrut.ToString(), buku.Tanggal.ToString("dd MMMM yyyy"), buku.Item, buku.Debit, buku.Kredit, buku.Saldo,
                                buku.Laba, buku.Keterangan);
                }
            }
            else
            {
                MessageBox.Show("Tidak ada record data pembukuan pada tanggal " + dtTanggal.Value.ToString("dd MMMM yyyy"),
                                "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void TampilDataByMonth(int bulan, int tahun)
        {
            int noUrut = 0;

            dgvBulanan.Rows.Clear();
            listOfBuku = controller.ReadByMonth(bulan, tahun);

            if (listOfBuku.Count != 0)
            {
                foreach (var buku in listOfBuku)
                {
                    noUrut = noUrut + 1;

                    dgvBulanan.Rows.Add(noUrut.ToString(), buku.Keterangan, buku.Debit, buku.Kredit, buku.Saldo);
                }
            }
            else
            {
                MessageBox.Show("Tidak ada record data pembukuan pada bulan " + cmbBulan.Text + " " + cmbTahun.Text,
                                "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void rdoTanggal_CheckedChanged(object sender, EventArgs e)
        {
            dtTanggal.Value = DateTime.Today;

            if (rdoTanggal.Checked == true)
                dtTanggal.Enabled = true;
            else
                dtTanggal.Enabled = false;  
        }

        private void rdoBulan_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoBulan.Checked == true)
            {
                cmbBulan.Enabled = true;
                cmbTahun.Enabled = true;

                var namaBulan = new GeneralSetting();
                cmbBulan.Text = namaBulan.GetBulanIndonesia(DateTime.Today.Month);
                cmbTahun.Text = DateTime.Today.Year.ToString();
            }
            else
            {
                cmbBulan.Enabled = false;
                cmbTahun.Enabled = false;
                cmbBulan.SelectedIndex = -1;
                cmbTahun.SelectedIndex = -1;
            }
        }

        private void btnTampilkan_Click(object sender, EventArgs e)
        {
            if (rdoTanggal.Checked == true)
            {
                dgvHarian.Visible = true;
                dgvBulanan.Visible = false;

                var tanggal = dtTanggal.Value;
                TampilDataByDate(tanggal);
            }
            else
            {
                dgvHarian.Visible = false;
                dgvBulanan.Visible = true;

                var bulan = cmbBulan.SelectedIndex + 1;
                var tahun = int.Parse(cmbTahun.Text);
                TampilDataByMonth(bulan, tahun);
            }
        }
    }
}
