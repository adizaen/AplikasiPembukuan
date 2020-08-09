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
using Guna.UI.WinForms;

namespace AplikasiPembukuan.View
{
    public partial class FrmInputPembukuan : Form
    {
        public delegate void CreateUpdateEventHandler(Pembukuan buku);
        public event CreateUpdateEventHandler OnCreate;
        public event CreateUpdateEventHandler OnUpdate;

        private PembukuanController controller;
        private Pembukuan buku;
        private bool isNewData = true;
        private DateTime tanggal;
        private string ID;
        private Pembukuan bukuAwal;
        private Pembukuan selisihBuku;

        public FrmInputPembukuan()
        {
            InitializeComponent();
        }

        public FrmInputPembukuan(string title, PembukuanController controller, DateTime tanggal) : this()
        {
            lblHeader.Text = title;
            this.controller = controller;
            this.tanggal = tanggal;
            selisihBuku = new Pembukuan();
        }

        public FrmInputPembukuan(string title, Pembukuan obj, PembukuanController controller, DateTime tanggal) : this()
        {
            lblHeader.Text = title;
            this.controller = controller;
            this.tanggal = tanggal;

            isNewData = false;
            buku = obj;

            bukuAwal = new Pembukuan();
            bukuAwal.Debit = buku.Debit;
            bukuAwal.Kredit = buku.Kredit;
            bukuAwal.Saldo = buku.Saldo;

            selisihBuku = new Pembukuan();

            this.ID = buku.ID;
            txtNamaItem.Text = buku.Item;

            if (buku.Kredit == 0 && buku.Debit == 0)
            {
                cmbJenisDana.SelectedIndex = 2;
                txtNominalDana.Text = buku.Saldo.ToString();
            }
            else if (buku.Debit == 0)
            {
                cmbJenisDana.SelectedIndex = 1;
                txtNominalDana.Text = buku.Kredit.ToString();
            }
            else if (buku.Kredit == 0)
            {
                cmbJenisDana.SelectedIndex = 0;
                txtNominalDana.Text = buku.Debit.ToString();
            }

            if (buku.Laba != 0)
                txtNominalLaba.Text = buku.Laba.ToString();

            if (buku.Keterangan != "-")
                txtKeterangan.Text = buku.Keterangan;
        }

        private void cmbJenisDana_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbJenisDana.SelectedIndex == 1)
                txtNominalLaba.Enabled = false;
            else
                txtNominalLaba.Enabled = true;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (isNewData)
            {
                buku = new Pembukuan();
                bukuAwal = new Pembukuan();
                buku.Saldo = controller.GetLastSaldo(tanggal);
            }

            buku.ID = ID;
            buku.Tanggal = tanggal;
            buku.Item = txtNamaItem.Text;

            if (cmbJenisDana.SelectedIndex == 0)
            {
                buku.Debit = double.Parse(txtNominalDana.Text);

                if (bukuAwal.Debit > buku.Debit)
                {
                    var selisih = bukuAwal.Debit - buku.Debit;
                    buku.Saldo -= selisih;
                }
                else
                {
                    var selisih = buku.Debit - bukuAwal.Debit;
                    buku.Saldo += selisih;
                }
            }  
            else if (cmbJenisDana.SelectedIndex == 1)
            {
                buku.Kredit = double.Parse(txtNominalDana.Text);

                if (bukuAwal.Kredit > buku.Kredit)
                {
                    var selisih = bukuAwal.Kredit - buku.Kredit;
                    buku.Saldo += selisih;
                }
                else
                {
                    var selisih = buku.Kredit - bukuAwal.Kredit;
                    buku.Saldo -= selisih;
                }
            }
            else
                buku.Saldo = double.Parse(txtNominalDana.Text);

            if (txtNominalLaba.Text != "")
                buku.Laba = double.Parse(txtNominalLaba.Text);
            
            buku.Keterangan = txtKeterangan.Text;

            selisihBuku.Tanggal = buku.Tanggal;
            selisihBuku.ID = buku.ID;
            selisihBuku.Saldo = bukuAwal.Saldo - buku.Saldo;
            selisihBuku.Debit = bukuAwal.Debit - buku.Debit;
            selisihBuku.Kredit = bukuAwal.Kredit - buku.Kredit;

            int result = 0;

            if (isNewData)
            {
                result = controller.Create(buku);

                if (result > 0)
                {
                    OnCreate(buku);

                    var reset = new GeneralSetting();
                    reset.ClearTxt(this);
                    cmbJenisDana.SelectedIndex = -1;
                    txtNamaItem.Focus();
                }
            }
            else
            {
                result = controller.Update(buku, selisihBuku);

                if (result > 0)
                {
                    OnUpdate(buku);
                    this.Close();
                }
            }
        }

        private void FrmInputPembukuan_KeyPress(object sender, KeyPressEventArgs e)
        {
            var esc = new GeneralSetting();

            if (esc.isEsc(e))
                this.Close();
        }

        private void FrmInputPembukuan_Shown(object sender, EventArgs e)
        {
            txtNamaItem.Focus();
        }

        private void txtNominalDana_KeyPress(object sender, KeyPressEventArgs e)
        {
            var validasi = new GeneralSetting();
            e.Handled = validasi.NumericOnly(e);
        }

        private void txtNominalLaba_KeyPress(object sender, KeyPressEventArgs e)
        {
            var validasi = new GeneralSetting();
            e.Handled = validasi.NumericOnly(e);
        }
    }
}
