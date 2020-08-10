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

namespace AplikasiPembukuan.View
{
    public partial class FrmDatabase : Form
    {
        private Data data = new Data();
        private DataController controller;

        public FrmDatabase()
        {
            InitializeComponent();
            controller = new DataController();
            TampilInfo();
        }

        private void TampilInfo()
        {
            data = controller.ReadLastBackup();

            if (!string.IsNullOrEmpty(data.Lokasi))
            {
                var namaBulan = new GeneralSetting();

                lblTglBackup.Text = string.Format("{0} {1} {2}", data.Tanggal.Date.ToString(), namaBulan.GetBulanIndonesia(data.Tanggal.Month),
                                    data.Tanggal.Year.ToString());
                lblLokasi.Text = data.Lokasi;

                lblTglBackup.ForeColor = Color.Black;
                lblLokasi.ForeColor = Color.Black;
            }
            else
            {
                lblTglBackup.Text = "- ( Belum pernah dibackup )";
                lblLokasi.Text = "- ( Belum pernah dibackup )";

                lblTglBackup.ForeColor = Color.Red;
                lblLokasi.ForeColor = Color.Red;
            }
        }
    }
}
