﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AplikasiPembukuan.View;
using Guna.UI.WinForms;

namespace AplikasiPembukuan.View
{
    public partial class FrmMain : Form
    {
        Form _frmDashboard, _frmKaryawan, _frmPembukuan, _frmLaporan, _frmProfil, _frmDatabase;

        List<Form> listOfForm;
        List<GunaAdvenceButton> listOfMenu;

        public FrmMain()
        {
            InitializeComponent();
            listOfForm = new List<Form>();
            listOfMenu = new List<GunaAdvenceButton>();
            AvailableMenu();
        }

        private void AvailableMenu()
        {
            listOfMenu.Add(menuDashboard);
            listOfMenu.Add(menuKaryawan);
            listOfMenu.Add(menuPembukuan);
            listOfMenu.Add(menuLaporan);
            listOfMenu.Add(menuProfil);
            listOfMenu.Add(menuDatabase);
        }

        private void menuDashboard_Click(object sender, EventArgs e)
        {
            var kode = txtKodeUser.Text;
            var nama = txtNamaUser.Text;
            var hakAkses = txtHakAkses.Text;

            FrmDashboard _frmDashboard = new FrmDashboard(kode, nama, hakAkses);
            this._frmDashboard = _frmDashboard;

            if (!OpenFormOnPanel(this._frmDashboard))
                listOfForm.Add(this._frmDashboard);

            CheckedButtonMenu(menuDashboard);
        }

        private void menuKaryawan_Click(object sender, EventArgs e)
        {
            FrmKaryawan _frmKaryawan = new FrmKaryawan();
            this._frmKaryawan = _frmKaryawan;

            if (!OpenFormOnPanel(this._frmKaryawan))
                listOfForm.Add(this._frmKaryawan);

            CheckedButtonMenu(menuKaryawan);
        }

        private void menuPembukuan_Click(object sender, EventArgs e)
        {
            var karyawan = txtKodeUser.Text + " - " + txtNamaUser.Text;

            FrmPembukuan _frmPembukuan = new FrmPembukuan(karyawan);
            this._frmPembukuan = _frmPembukuan;

            if (!OpenFormOnPanel(this._frmPembukuan))
                listOfForm.Add(this._frmPembukuan);

            CheckedButtonMenu(menuPembukuan);
        }

        private void FrmMain_Shown(object sender, EventArgs e)
        {
            menuDashboard_Click(this, e);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            var pesan = "Apakah anda yakin ingin keluar aplikasi?";
            DialogResult = MessageBox.Show(pesan, "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (DialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void menuDatabase_Click(object sender, EventArgs e)
        {
            FrmDatabase _frmDatabase = new FrmDatabase();
            this._frmDatabase = _frmDatabase;

            if (!OpenFormOnPanel(this._frmDatabase))
                listOfForm.Add(this._frmDatabase);

            CheckedButtonMenu(menuDatabase);
        }

        private void menuLaporan_Click(object sender, EventArgs e)
        {
            FrmLaporan _frmLaporan = new FrmLaporan();
            this._frmLaporan = _frmLaporan;

            if (!OpenFormOnPanel(this._frmLaporan))
                listOfForm.Add(this._frmLaporan);

            CheckedButtonMenu(menuLaporan);
        }

        private void menuProfil_Click(object sender, EventArgs e)
        {
            var kodeKaryawan = txtKodeUser.Text;
            var hakAkses = txtHakAkses.Text;

            FrmProfile _frmProfil = new FrmProfile(kodeKaryawan, hakAkses);
            this._frmProfil = _frmProfil;

            if (!OpenFormOnPanel(this._frmProfil))
                listOfForm.Add(this._frmProfil);

            CheckedButtonMenu(menuProfil);
        }

        private bool OpenFormOnPanel(Form frmObj)
        {
            bool isShow = true;

            if (!listOfForm.Contains(frmObj))
            {
                isShow = false;
            }

            listOfForm.Remove(frmObj);
            listOfForm.Add(frmObj);

            this.panelUtama.Controls.Clear();
            frmObj.TopLevel = false;
            this.panelUtama.Controls.Add(frmObj);
            frmObj.Show();

            this.lblHeader.Text = frmObj.Text;

            return isShow;
        }

        private void CheckedButtonMenu(GunaAdvenceButton btn)
        {
            foreach (var tombol in listOfMenu)
            {
                tombol.Checked = false;

                if (tombol == btn)
                    tombol.Checked = true;
            }
        }
    }
}
