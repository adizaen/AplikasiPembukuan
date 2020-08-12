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
using Microsoft.Office.Interop.Excel;

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
            dgvHarian.Size = new Size(900, 414);
            dgvBulanan.Size = new Size(900, 414);
            dgvHarian.Location = new System.Drawing.Point(28, 177);
            dgvBulanan.Location = new System.Drawing.Point(28, 177);
            dgvBulanan.Visible = false;

            rdoTanggal.Checked = true;
            rdoBulan.Checked = false;
            rdoPeriodeTanggal.Checked = false;
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
            dgvBulanan.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvHarian.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvHarian.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, FontStyle.Bold);
            dgvHarian.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHarian.AllowUserToAddRows = false;
            dgvHarian.MultiSelect = false;
            dgvHarian.RowHeadersVisible = false;
            dgvHarian.ReadOnly = true;

            dgvBulanan.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvBulanan.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, FontStyle.Bold);
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

                    dgvBulanan.Rows.Add(noUrut.ToString(), buku.Keterangan, buku.Debit, buku.Kredit, buku.Saldo, buku.Laba);
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
                TampilDataByMonth(bulan, tahun);
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
        }

        private void SimpanExcel()
        {
            pesanDialog.InitialDirectory = "C:";
            pesanDialog.Title = "Simpan File Excel";

            if (rdoTanggal.Checked == true)
                pesanDialog.FileName = "Laporan Harian " + dtTanggal.Value.ToString("dd MMMM yyyy");
            else if (rdoBulan.Checked == true)
                pesanDialog.FileName = "Laporan Bulan " + cmbBulan.Text + " " + cmbTahun.Text;
            else if (rdoPeriodeTanggal.Checked == true)
                pesanDialog.FileName = "Laporan Periode Harian " + dtTanggalMulai.Value.ToString("dd MMMM yyyy") + " - " + dtTanggalAkhir.Value.ToString("dd MMMM yyyy");

            pesanDialog.Filter = "Excel Workbook (*.xlsx)|*.xlsx|Excel 97-2003 Workbook (*.xls)|*.xls";

            if (pesanDialog.ShowDialog() != DialogResult.Cancel)
            {
                if (rdoTanggal.Checked == true || rdoPeriodeTanggal.Checked == true)
                    ExportToExcelByTanggal();
                else
                    ExportToExcelByBulan();
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

        private void ExportToExcelByTanggal()
        {

            Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();

            Workbook wb1 = ExcelApp.Workbooks.Add(Type.Missing);
            Worksheet ws1 = (Worksheet)wb1.Worksheets[1];


            ws1.Cells[1, 1] = "LAPORAN DATA PEMBUKUAN";

            if (rdoTanggal.Checked == true)
                ws1.Cells[2, 1] = "Periode : " + dtTanggal.Value.ToString("dd MMMM yyyy");
            else if (rdoPeriodeTanggal.Checked == true)
                ws1.Cells[2, 1] = "Periode : " + dtTanggalMulai.Value.ToString("dd MMMM yyyy") + " - " +
                                    dtTanggalAkhir.Value.ToString("dd MMMM yyyy");

            for (int i = 1; i < dgvHarian.Columns.Count + 1; i++)
            {
                ws1.Cells[4, i] = dgvHarian.Columns[i - 1].HeaderText;
            }

            for (int i = 0; i < dgvHarian.Rows.Count; i++)
            {
                for (int j = 0; j < dgvHarian.Columns.Count; j++)
                {
                    ws1.Cells[i + 5, j + 1] = dgvHarian.Rows[i].Cells[j].Value.ToString();
                }
            }

            // Judul Laporan
            Range range = ws1.get_Range("A1", "H1");
            range.Font.Bold = true;
            range.Font.Size = 12;
            range.VerticalAlignment = XlVAlign.xlVAlignCenter;
            range.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            range.Merge();

            // Tanggal Periode
            Range range1 = ws1.get_Range("A2", "H2");
            range1.Font.Bold = false;
            range1.Font.Size = 12;
            range1.VerticalAlignment = XlVAlign.xlVAlignCenter;
            range1.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            range1.Merge();

            // Data baris
            var rowCount = (dgvHarian.Rows.Count + 4).ToString();

            Range range2 = ws1.get_Range("A4", "H" + rowCount);
            range2.Borders.LineStyle = XlLineStyle.xlContinuous;
            range2.Borders.Weight = XlBorderWeight.xlThin;
            range2.Rows.RowHeight = 16.50;
            range2.VerticalAlignment = XlVAlign.xlVAlignCenter;

            // Nama Kolom
            Range range3 = ws1.get_Range("A4", "H4");
            range3.Font.Bold = true;
            range3.Font.Size = 11;
            range3.Rows.RowHeight = 21;
            range3.VerticalAlignment = XlVAlign.xlVAlignCenter;
            range3.HorizontalAlignment = XlHAlign.xlHAlignCenter;

            // Set rata tengah kolom 1 dan 2
            Range range4 = ws1.get_Range("A5", "B" + rowCount);
            range4.HorizontalAlignment = XlHAlign.xlHAlignCenter;

            Range range5 = ws1.get_Range("A4", "A4");
            range5.ColumnWidth = 5.30;

            Range range6 = ws1.get_Range("B4", "B4");
            range6.ColumnWidth = 18;

            Range range7 = ws1.get_Range("C4", "H4");
            range7.ColumnWidth = 26.71;

            Range range8 = ws1.get_Range("D4", "G4");
            range8.ColumnWidth = 19;

            // Currency Format
            Range range9 = ws1.get_Range("D5", "G" + (dgvHarian.Rows.Count + 5).ToString());
            range9.NumberFormat = "Rp #,###,##0";

            Range range10 = ws1.get_Range("B5", "B" + rowCount);
            range10.NumberFormat = "[$-3809]dd mmmm yyyy";

            if (rdoTanggal.Checked == true)
            {
                var countDgv = (dgvHarian.Rows.Count + 5).ToString();

                Range range11 = ws1.get_Range("A" + countDgv, "H" + countDgv);
                range11.Borders.LineStyle = XlLineStyle.xlContinuous;
                range11.Borders.Weight = XlBorderWeight.xlThin;
                range11.Rows.RowHeight = 16.50;
                range11.VerticalAlignment = XlVAlign.xlVAlignCenter;

                Range range12 = ws1.get_Range("A" + countDgv, "C" + countDgv);
                range12.Merge();
                range12.Font.Bold = true;
                range12.HorizontalAlignment = XlHAlign.xlHAlignLeft;

                ws1.Cells[dgvHarian.Rows.Count + 5, 1] = "TOTAL";
                ws1.Cells[dgvHarian.Rows.Count + 5, 4].Formula = string.Format("=SUM(D5:D{0})", dgvHarian.Rows.Count + 4);
                ws1.Cells[dgvHarian.Rows.Count + 5, 5].Formula = string.Format("=SUM(E5:E{0})", dgvHarian.Rows.Count + 4);
                ws1.Cells[dgvHarian.Rows.Count + 5, 6].Formula = string.Format("=SUM(F5:F{0})", dgvHarian.Rows.Count + 4);
                ws1.Cells[dgvHarian.Rows.Count + 5, 7].Formula = string.Format("=SUM(G5:G{0})", dgvHarian.Rows.Count + 4);
            }


            ExcelApp.ActiveWorkbook.SaveCopyAs(pesanDialog.FileName.ToString());
            ExcelApp.ActiveWorkbook.Saved = true;
            ExcelApp.Quit();

            MessageBox.Show("Data berhasil diexport!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ExportToExcelByBulan()
        {
            Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();

            Workbook wb1 = ExcelApp.Workbooks.Add(Type.Missing);
            Worksheet ws1 = (Worksheet)wb1.Worksheets[1];


            ws1.Cells[1, 1] = "LAPORAN DATA PEMBUKUAN";

            if (rdoBulan.Checked == true)
                ws1.Cells[2, 1] = "Periode Bulan : " + cmbBulan.Text + " " + cmbTahun.Text;
            
            for (int i = 1; i < dgvBulanan.Columns.Count + 1; i++)
            {
                ws1.Cells[4, i] = dgvBulanan.Columns[i - 1].HeaderText;
            }

            for (int i = 0; i < dgvBulanan.Rows.Count; i++)
            {
                for (int j = 0; j < dgvBulanan.Columns.Count; j++)
                {
                    ws1.Cells[i + 5, j + 1] = dgvBulanan.Rows[i].Cells[j].Value.ToString();
                }
            }

            // Judul Laporan
            Range range = ws1.get_Range("A1", "F1");
            range.Font.Bold = true;
            range.Font.Size = 12;
            range.VerticalAlignment = XlVAlign.xlVAlignCenter;
            range.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            range.Merge();

            // Tanggal Periode
            Range range1 = ws1.get_Range("A2", "F2");
            range1.Font.Bold = false;
            range1.Font.Size = 12;
            range1.VerticalAlignment = XlVAlign.xlVAlignCenter;
            range1.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            range1.Merge();

            // Data baris
            var rowCount = (dgvBulanan.Rows.Count + 4).ToString();

            Range range2 = ws1.get_Range("A4", "F" + rowCount);
            range2.Borders.LineStyle = XlLineStyle.xlContinuous;
            range2.Borders.Weight = XlBorderWeight.xlThin;
            range2.Rows.RowHeight = 16.50;
            range2.VerticalAlignment = XlVAlign.xlVAlignCenter;

            // Nama Kolom
            Range range3 = ws1.get_Range("A4", "F4");
            range3.Font.Bold = true;
            range3.Font.Size = 11;
            range3.Rows.RowHeight = 21;
            range3.VerticalAlignment = XlVAlign.xlVAlignCenter;
            range3.HorizontalAlignment = XlHAlign.xlHAlignCenter;

            // Set rata tengah kolom 1 dan 2
            Range range4 = ws1.get_Range("A5", "B" + rowCount);
            range4.HorizontalAlignment = XlHAlign.xlHAlignCenter;

            Range range5 = ws1.get_Range("A4", "A4");
            range5.ColumnWidth = 5.30;

            Range range6 = ws1.get_Range("B4", "B4");
            range6.ColumnWidth = 21;

            Range range7 = ws1.get_Range("C4", "F4");
            range7.ColumnWidth = 20;

            // Currency Format
            Range range9 = ws1.get_Range("C5", "F" + rowCount);
            range9.NumberFormat = "Rp #,###,##0";

            ExcelApp.ActiveWorkbook.SaveCopyAs(pesanDialog.FileName.ToString());
            ExcelApp.ActiveWorkbook.Saved = true;
            ExcelApp.Quit();

            MessageBox.Show("Data berhasil diexport!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
