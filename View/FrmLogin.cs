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
    public partial class FrmLogin : Form
    {
        private List<Akun> listOfAkun = new List<Akun>();
        private AkunController controller;

        public FrmLogin()
        {
            InitializeComponent();
            controller = new AkunController();
        }

        private void btnBatal_MouseHover(object sender, EventArgs e)
        {
            btnBatal.Font = new Font(btnBatal.Font.Name, btnBatal.Font.SizeInPoints, FontStyle.Underline);
        }

        private void btnBatal_MouseLeave(object sender, EventArgs e)
        {
            btnBatal.Font = new Font(btnBatal.Font.Name, btnBatal.Font.SizeInPoints, FontStyle.Regular);
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmLogin_Shown(object sender, EventArgs e)
        {
            txtUsername.Focus();
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtPassword.Focus();
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnLogin.PerformClick();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var result = 0;
            var akun = new Akun();
            var validAkun = new Akun();

            akun.Username = txtUsername.Text;
            akun.Password = txtPassword.Text;

            result = controller.LoginCek(akun);

            if (result > 0)
            {
                validAkun = controller.IsValidAkses(akun);

                if (!string.IsNullOrEmpty(validAkun.KodeKaryawan))
                {
                    this.Visible = false;

                    var fMenu = new FrmMain();

                    fMenu.txtKodeUser.Text = validAkun.KodeKaryawan;
                    fMenu.txtNamaUser.Text = validAkun.Username;
                    fMenu.txtHakAkses.Text = validAkun.HakAkses;

                    if (validAkun.HakAkses == "2")
                    {
                        fMenu.menuProfil.Location = new Point(fMenu.menuPembukuan.Left, fMenu.menuPembukuan.Top);
                        fMenu.menuPembukuan.Location = new Point(fMenu.menuKaryawan.Left, fMenu.menuKaryawan.Top);
                        fMenu.menuLaporan.Visible = false;
                    }

                    fMenu.Show();
                }
                else
                    MessageBox.Show("Login Gagal!" + "\n" + "Username/Password yang anda masukan salah!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
