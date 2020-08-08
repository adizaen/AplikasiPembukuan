using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AplikasiPembukuan.Controller;

namespace AplikasiPembukuan.View
{
    public partial class FrmDashboard : Form
    {
        private int HakAkses;

        public FrmDashboard()
        {
            InitializeComponent();
        }

        public FrmDashboard(string kode, string nama, int hakAkses) : this()
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
            lblKodeUser.Text = kode;
            lblNamaUser.Text = nama;
            this.HakAkses = hakAkses;

            var lblPosisi = "";

            if (hakAkses == 1)
            {
                lblPosisi = "Admin";
            }
            else if (hakAkses == 2)
            {
                lblPosisi = "Kasir";
            }

            groupBoxAkun.Text = "Akun " + lblPosisi;

            var bulan = new GeneralSetting();
            lblDate.Text = DateTime.Now.Day.ToString() + " " + bulan.GetBulanIndonesia(DateTime.Now.Month)
                            + " " + DateTime.Now.Year.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var pesan = "Apakah anda yakin ingin mengakhiri sesi login anda dan logout aplikasi?";
            DialogResult = MessageBox.Show(pesan, "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (DialogResult == DialogResult.Yes)
            {
                FrmMain fMenu = (FrmMain)Application.OpenForms["FrmMain"];
                FrmLogin fLogin = new FrmLogin();
                fMenu.Close();
                fLogin.Visible = true;
            }
        }
    }
}
