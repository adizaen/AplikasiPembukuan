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
    public partial class FrmInputKaryawan : Form
    {
        public delegate void CreateUpdateEventHandler(Karyawan karyawan, Akun akun);
        public event CreateUpdateEventHandler OnCreate;
        public event CreateUpdateEventHandler OnUpdate;

        private KaryawanController controller;
        private AkunController controllerAkun;
        private Karyawan karyawan;
        private Akun akun;
        private bool isNewData = true;

        public FrmInputKaryawan()
        {
            InitializeComponent();
        }

        public FrmInputKaryawan(string title, KaryawanController controller, AkunController controllerAkun) : this()
        {
            lblHeader.Text = title;
            this.controller = controller;
            this.controllerAkun = controllerAkun;
            AutoKodeKaryawan();
        }

        public FrmInputKaryawan(string title, Karyawan obj, KaryawanController controller, AkunController controllerAkun) : this()
        {
            lblHeader.Text = title;
            this.controller = controller;
            this.controllerAkun = controllerAkun;

            isNewData = false;
            karyawan = obj;
            akun = new Akun();

            txtKodeKaryawan.Text = karyawan.KodeKaryawan;
            txtNamaKaryawan.Text = karyawan.Nama;

            if (karyawan.Gender == "L")
                rdoLaki.Checked = true;
            else
                rdoPerempuan.Checked = true;

            txtTelepon.Text = karyawan.Telepon;

            if (karyawan.HakAkses == "1")
                cmbHakAkses.SelectedIndex = 0;
            else
                cmbHakAkses.SelectedIndex = 1;
        }

        private void AutoKodeKaryawan()
        {
            string newID = controller.GetLastID();
            txtKodeKaryawan.Text = newID;
            txtNamaKaryawan.Focus();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (isNewData)
            {
                karyawan = new Karyawan();
                akun = new Akun();
            }

            karyawan.KodeKaryawan = txtKodeKaryawan.Text;
            karyawan.Nama = txtNamaKaryawan.Text;

            if (rdoLaki.Checked == true)
                karyawan.Gender = "L";
            else
                karyawan.Gender = "P";

            karyawan.Telepon = txtTelepon.Text;
            akun.KodeKaryawan = txtKodeKaryawan.Text;

            if (isNewData)
            {
                akun.Username = txtKodeKaryawan.Text;
                akun.Password = txtKodeKaryawan.Text;
            }

            if (cmbHakAkses.SelectedIndex == 0)
                akun.HakAkses = "1";
            else
                akun.HakAkses = "2";

            int result = 0;
            int result1 = 0;

            if (isNewData)
            {
                result = controller.Create(karyawan);
                result1 = controllerAkun.Create(akun);

                if (result > 0 && result1 > 0)
                {
                    OnCreate(karyawan, akun);

                    var reset = new GeneralSetting();
                    reset.ClearTxt(this);
                    AutoKodeKaryawan();

                    rdoLaki.Checked = false;
                    rdoPerempuan.Checked = false;
                    cmbHakAkses.SelectedIndex = -1;
                }
            }
            else
            {
                result = controller.Update(karyawan);
                result1 = controllerAkun.UpdateHakAkses(akun);

                if (result > 0 && result1 > 0)
                {
                    OnUpdate(karyawan, akun);
                    this.Close();
                }
            }
        }

        private void FrmInputKaryawan_KeyPress(object sender, KeyPressEventArgs e)
        {
            var esc = new GeneralSetting();

            if (esc.isEsc(e))
                this.Close();
        }

        private void FrmInputKaryawan_Shown(object sender, EventArgs e)
        {
            txtNamaKaryawan.Focus();
        }
    }
}
