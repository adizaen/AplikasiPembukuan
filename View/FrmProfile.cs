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
    public partial class FrmProfile : Form
    {
        private List<Karyawan> listOfKaryawan = new List<Karyawan>();
        private KaryawanController controller;
        private AkunController controller1;
        private string kodeKaryawan;
        private string hakAkses;

        public FrmProfile()
        {
            InitializeComponent();
            controller = new KaryawanController();
            controller1 = new AkunController();
            RefreshForm(false);
        }

        public FrmProfile(string kodeKaryawan, string hakAkses) : this()
        {
            this.kodeKaryawan = kodeKaryawan;
            this.hakAkses = hakAkses;
            TampilData();
        }

        private void RefreshForm(bool status)
        {
            txtKode.ReadOnly = true;
            txtNama.ReadOnly = !status;
            txtTelepon.ReadOnly = !status;
            cboGender.Enabled = status;
            btnSimpanProfile.Enabled = status;
            btnUbahProfile.Enabled = !status;
        }

        private void TampilData()
        {
            listOfKaryawan = controller.ReadCustom(kodeKaryawan, 1);

            foreach (var karyawan in listOfKaryawan)
            {
                txtKode.Text = karyawan.KodeKaryawan;
                txtNama.Text = karyawan.Nama;
                txtTelepon.Text = karyawan.Telepon;

                if (karyawan.Gender == "L")
                    cboGender.SelectedIndex = 0;
                else
                    cboGender.SelectedIndex = 1;
            }
        }

        private void btnUbahProfile_Click(object sender, EventArgs e)
        {
            btnUbahProfile.Enabled = false;
            RefreshForm(true);
        }

        private void btnSimpanProfile_Click(object sender, EventArgs e)
        {
            int result = 0;

            var karyawan = new Karyawan();
            karyawan.KodeKaryawan = txtKode.Text;
            karyawan.Nama = txtNama.Text;
            karyawan.Telepon = txtTelepon.Text;

            if (cboGender.SelectedIndex == 0)
                karyawan.Gender = "L";
            else
                karyawan.Gender = "P";

            result = controller.Update(karyawan);
            
            if (result > 0)
                RefreshForm(false);
        }

        private void cboLihatPass_CheckedChanged(object sender, EventArgs e)
        {
            txtPassBaru.UseSystemPasswordChar = true;
            txtKonfirmasi.UseSystemPasswordChar = true;

            if (cboLihatPass.Checked == true)
            {
                txtPassBaru.UseSystemPasswordChar = false;
                txtKonfirmasi.UseSystemPasswordChar = false;
            }
        }

        private void FrmProfile_Shown(object sender, EventArgs e)
        {
            cboLihatPass.Checked = false;
            txtUserBaru.Focus();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            int result = 0;

            if (txtKonfirmasi.Text == "")
            {
                MessageBox.Show("Konfirmasi password harap diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtKonfirmasi.Focus();
            }
            else if (txtPassBaru.TextLength < 5 || txtUserBaru.TextLength < 5)
            {
                MessageBox.Show("Panjang username & password minimal 5 karakter!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPassBaru.Focus();
            }
            else if (txtPassBaru.Text != txtKonfirmasi.Text)
            {
                MessageBox.Show("Konfirmasi password salah!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtKonfirmasi.Focus();
            }
            else
            {
                var konfirmasi = MessageBox.Show("Anda akan otomatis logout setelah update akun!" + "\n" +
                    "Yakin ingin update akun?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (konfirmasi == DialogResult.Yes)
                {
                    var akun = new Akun();
                    akun.KodeKaryawan = txtKode.Text;
                    akun.Username = txtUserBaru.Text;
                    akun.Password = txtPassBaru.Text;
                    akun.HakAkses = hakAkses;

                    result = controller1.Update(akun);

                    if (result > 0)
                    {
                        FrmMain fMenu = (FrmMain)Application.OpenForms["FrmMain"];
                        FrmLogin fLogin = new FrmLogin();
                        fMenu.Close();
                        fLogin.Visible = true;
                    }
                }
            }
        }
    }
}
