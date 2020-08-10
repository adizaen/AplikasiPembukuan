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

                lblTglBackup.Text = string.Format("{0} {1} {2}", data.Tanggal.Date.ToString("dd"), namaBulan.GetBulanIndonesia(data.Tanggal.Month),
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

        private void btnBackup_Click(object sender, EventArgs e)
        {
            string count = controller.GetCountBackup().ToString();

            pesanDialog.InitialDirectory = "C:";
            pesanDialog.Title = "Simpan File Backup";
            pesanDialog.FileName = "DbPembukuan " + count;
            pesanDialog.Filter = "SQL File (*.sql)|*.sql";

            if (pesanDialog.ShowDialog() != DialogResult.Cancel)
            {
                data.Tanggal = DateTime.Today;
                data.Lokasi = pesanDialog.FileName.Replace(@"\", @"\\");
                var result = controller.Create(data);

                if (result > 0)
                    TampilInfo();
            }
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            openDialog.InitialDirectory = "C:";
            openDialog.Title = "Pilih File";
            openDialog.FileName = "";
            openDialog.Filter = "SQL File (*.sql)|*.sql";

            if (openDialog.ShowDialog() != DialogResult.Cancel)
            {
                data.Lokasi = openDialog.FileName.Replace(@"\", @"\\");
                var result = controller.RestoreDB(data);

                if (result > 0)
                    TampilInfo();
            }
        }
    }
}
