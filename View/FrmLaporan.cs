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
            dgvHarian.Size = new Size(900, 388);
            dgvBulanan.Size = new Size(900, 388);
            dgvHarian.Location = new Point(28, 207);
            dgvBulanan.Location = new Point(28, 207);
            dgvBulanan.Visible = false;

            rdoTanggal.Checked = true;
            rdoBulan.Checked = false;
            rdoPeriodeTanggal.Checked = false;
            rdoPeriodeBulan.Checked = false;
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

        private void TampilDataByDate(DateTime tanggalAwal, DateTime tanggalAkhir)
        {
            int noUrut = 0;

            dgvHarian.Rows.Clear();
            listOfBuku = controller.ReadByDate(tanggalAwal, tanggalAkhir);

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
                MessageBox.Show("Tidak ada record data pembukuan",  "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void TampilDataByMonth(int bulanAwal, int tahunAwal, int bulanAkhir, int tahunAkhir)
        {
            int noUrut = 0;

            dgvBulanan.Rows.Clear();
            listOfBuku = controller.ReadByMonth(bulanAwal, tahunAwal, bulanAkhir, tahunAkhir);

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
                MessageBox.Show("Tidak ada record data pembukuan", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void rdoPeriodeTanggal_CheckedChanged(object sender, EventArgs e)
        {
            dtTanggalMulai.Value = DateTime.Today;
            dtTanggalAkhir.Value = DateTime.Today;

            if (rdoPeriodeTanggal.Checked == true)
            {
                dtTanggalMulai.Enabled = true;
                dtTanggalAkhir.Enabled = true;
            }
            else
            {
                dtTanggalMulai.Enabled = false;
                dtTanggalAkhir.Enabled = false;
            }
        }

        private void rdoPeriodeBulan_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoPeriodeBulan.Checked == true)
            {
                cmbBulanAwal.Enabled = true;
                cmbBulanAkhir.Enabled = true;
                cmbTahunAwal.Enabled = true;
                cmbTahunAkhir.Enabled = true;

                var namaBulan = new GeneralSetting();
                cmbBulanAwal.Text = namaBulan.GetBulanIndonesia(DateTime.Today.Month);
                cmbTahunAwal.Text = DateTime.Today.Year.ToString();
                cmbBulanAkhir.Text = namaBulan.GetBulanIndonesia(DateTime.Today.Month);
                cmbTahunAkhir.Text = DateTime.Today.Year.ToString();
            }
            else
            {
                cmbBulanAwal.Enabled =false;
                cmbBulanAkhir.Enabled = false;
                cmbTahunAwal.Enabled = false;
                cmbTahunAkhir.Enabled = false;

                cmbBulanAwal.SelectedIndex = -1;
                cmbTahunAwal.SelectedIndex = -1;
                cmbBulanAkhir.SelectedIndex = -1;
                cmbTahunAkhir.SelectedIndex = -1;
            }
        }

        private void btnTampilkan_Click(object sender, EventArgs e)
        {
            if (rdoTanggal.Checked == true)
            {
                dgvHarian.Visible = true;
                dgvBulanan.Visible = false;

                var tanggal = dtTanggal.Value;
                TampilDataByDate(tanggal, tanggal);
            }
            else if (rdoBulan.Checked == true)
            {
                dgvHarian.Visible = false;
                dgvBulanan.Visible = true;

                var bulan = cmbBulan.SelectedIndex + 1;
                var tahun = int.Parse(cmbTahun.Text);
                TampilDataByMonth(bulan, tahun, bulan, tahun);
            }
            else if (rdoPeriodeTanggal.Checked == true)
            {
                dgvHarian.Visible = true;
                dgvBulanan.Visible = false;

                var tanggalAwal = dtTanggalMulai.Value;
                var tanggalAkhir = dtTanggalAkhir.Value;

                if (tanggalAwal < tanggalAkhir)
                    TampilDataByDate(tanggalAwal, tanggalAkhir);
                else
                    MessageBox.Show("Tanggal awal tidak boleh melebihi tanggal akhir!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (rdoPeriodeBulan.Checked == true)
            {
                dgvHarian.Visible = false;
                dgvBulanan.Visible = true;

                var bulanAwal = cmbBulanAwal.SelectedIndex + 1;
                var tahunAwal = int.Parse(cmbTahunAwal.Text);
                var bulanAkhir = cmbBulanAkhir.SelectedIndex + 1;
                var tahunAkhir = int.Parse(cmbTahunAkhir.Text);

                if (tahunAwal == tahunAkhir)
                {
                    if (bulanAwal < bulanAkhir)
                        TampilDataByMonth(bulanAwal, tahunAwal, bulanAkhir, tahunAkhir);
                    else
                        MessageBox.Show("Bulan awal tidak boleh melebihi bulan akhir!", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    if (tahunAwal < tahunAkhir)
                        TampilDataByMonth(bulanAwal, tahunAwal, bulanAkhir, tahunAkhir);
                    else
                        MessageBox.Show("Tahun awal tidak boleh melebihi tahun akhir!", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void SimpanExcel()
        {
            saveFileDialog1.InitialDirectory = "C:";
            saveFileDialog1.Title = "Simpan File Excel";

            if (rdoTanggal.Checked == true)
                saveFileDialog1.FileName = "Laporan Harian " + dtTanggal.Value.ToString("dd MMMM yyyy");
            else if (rdoBulan.Checked == true)
                saveFileDialog1.FileName = "Laporan Bulan " + cmbBulan.Text + " " + cmbTahun.Text;
            else if (rdoPeriodeTanggal.Checked == true)
                saveFileDialog1.FileName = "Laporan Periode Harian " + dtTanggalMulai.Value.ToString("dd MMMM yyyy") + " - " + dtTanggalAkhir.Value.ToString("dd MMMM yyyy");
            else
                saveFileDialog1.FileName = "Laporan Periode Bulan " + cmbBulanAwal.Text + " " + cmbTahunAwal.Text + " - " + cmbBulanAkhir.Text + " " + cmbTahunAkhir.Text;

            saveFileDialog1.Filter = "Excel Workbook (*.xlsx)|*.xlsx|Excel 97-2003 Workbook (*.xls)|*.xls";

            if (saveFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
                ExcelApp.Application.Workbooks.Add(Type.Missing);

                ExcelApp.Cells[1, 1] = "LAPORAN DATA PEMBUKUAN";
                ExcelApp.Cells[2, 1] = "Periode : " + dtTanggal.Value.ToString("dd MMMM yyyy");

                for (int i = 1; i < dgvHarian.Columns.Count + 1; i++)
                {
                    ExcelApp.Cells[4, i] = dgvHarian.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < dgvHarian.Rows.Count; i++)
                {
                    for (int j = 0; j < dgvHarian.Columns.Count; j++)
                    {
                        ExcelApp.Cells[i + 5, j + 1] = dgvHarian.Rows[i].Cells[j].Value.ToString();
                    }
                }

                ExcelApp.ActiveWorkbook.SaveCopyAs(saveFileDialog1.FileName.ToString());
                ExcelApp.ActiveWorkbook.Saved = true;
                ExcelApp.Quit();

                MessageBox.Show("Data berhasil diexport!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            if (rdoTanggal.Checked == true || rdoPeriodeTanggal.Checked == true)
            {
                if (dgvHarian.Rows.Count != 0)
                    SimpanExcel();
                else
                    MessageBox.Show("Tidak ada record data pada tabel!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (dgvBulanan.Rows.Count != 0)
                    SimpanExcel();
                else
                    MessageBox.Show("Tidak ada record data pada tabel!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
