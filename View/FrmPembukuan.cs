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
using AplikasiPembukuan.View;
using Guna.UI.WinForms;

namespace AplikasiPembukuan
{
    public partial class FrmPembukuan : Form
    {
        private List<Pembukuan> listOfBuku = new List<Pembukuan>();
        private PembukuanController controller;

        private double totalDebit = 0;
        private double totalKredit = 0;

        public FrmPembukuan()
        {
            InitializeComponent();
            controller = new PembukuanController();
            InisiasiDatagrid();
            TampilData();
        }

        private void InisiasiDatagrid()
        {
            dgv.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgv.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.AllowUserToAddRows = false;
            dgv.MultiSelect = false;
            dgv.RowHeadersVisible = false;
            dgv.ReadOnly = true;
        }

        private void TampilData()
        {
            int noUrut = 0;
            string debit = "";
            string kredit = "";
            totalDebit = 0;
            totalKredit = 0;

            dgv.Rows.Clear();
            var tanggal = dtTanggal.Value;
            listOfBuku = controller.ReadByDate(tanggal);

            foreach (var buku in listOfBuku)
            {
                noUrut = noUrut + 1;

                if (buku.Keterangan == "")
                    buku.Keterangan = "-";

                if (buku.Debit == 0)
                    debit = "";
                else
                    debit = buku.Debit.ToString();

                if (buku.Kredit == 0)
                    kredit = "";
                else
                    kredit = buku.Kredit.ToString();

                totalDebit += buku.Debit;
                totalKredit += buku.Kredit;

                dgv.Rows.Add(noUrut.ToString(), buku.ID, buku.Item, debit, kredit, buku.Saldo,
                                buku.Laba, buku.Keterangan);
            }

            if (totalDebit > 0)
                txtTotalDebit.Text = totalDebit.ToString();
            else
                txtTotalDebit.Text = "0";

            if (totalKredit > 0)
                txtTotalKredit.Text = totalKredit.ToString();
            else
                txtTotalKredit.Text = "0";
        }

        private void OnCreateEventHandler(Pembukuan buku)
        {
            listOfBuku.Add(buku);
            TampilData();
        }

        private void OnUpdateEventHandler(Pembukuan buku)
        {
            int index = dgv.CurrentCell.RowIndex;

            DataGridViewRow row = (DataGridViewRow)dgv.Rows[index].Clone();

            row.Cells[1].Value = buku.ID;
            row.Cells[2].Value = buku.Item;
            row.Cells[3].Value = buku.Debit;
            row.Cells[4].Value = buku.Kredit;
            row.Cells[5].Value = buku.Saldo;
            row.Cells[6].Value = buku.Laba;
            row.Cells[7].Value = buku.Keterangan;

            TampilData();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            FrmInputPembukuan fInput = new FrmInputPembukuan("Tambah Data", controller, dtTanggal.Value);
            fInput.OnCreate += OnCreateEventHandler;
            fInput.ShowDialog();
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                Pembukuan buku = listOfBuku[dgv.CurrentCell.RowIndex];

                FrmInputPembukuan fInput = new FrmInputPembukuan("Tambah Data", buku, controller, dtTanggal.Value);
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
                var konfirmasi = MessageBox.Show("Apakah data terpilih ingin dihapus?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (konfirmasi == DialogResult.Yes)
                {
                    Pembukuan buku = listOfBuku[dgv.CurrentCell.RowIndex];

                    var result = controller.Delete(buku);

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

        private void dtTanggal_ValueChanged(object sender, EventArgs e)
        {
            TampilData();
        }

        private void txtTotalKredit_TextChanged(object sender, EventArgs e)
        {
            if (txtTotalKredit.Text != "0")
            {
                var validasi = new GeneralSetting();
                validasi.SetThousandSeparator((GunaTextBox)sender);
            }
        }

        private void txtTotalDebit_TextChanged(object sender, EventArgs e)
        {
            if (txtTotalDebit.Text != "0")
            {
                var validasi = new GeneralSetting();
                validasi.SetThousandSeparator((GunaTextBox)sender);
            }
        }
    }
}
