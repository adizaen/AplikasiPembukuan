using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Guna.UI.WinForms;

namespace AplikasiPembukuan.Controller
{
    public class GeneralSetting
    {
        // Fungsi agar textbox hanya bisa diisi angka
        public bool NumericOnly(KeyPressEventArgs e)
        {
            string strValid = "0123456789.";

            if (strValid.IndexOf(e.KeyChar) < 0 && !(e.KeyChar == Convert.ToChar(Keys.Back)))
                return true;
            else
                return false;
        }

        // Fungsi untuk memisah angka ribuan pada textbox
        public void SetThousandSeparator(GunaTextBox txt)
        {
            if (txt.TextLength > 0)
            {
                try
                {
                    string s = txt.Text.Replace(",", "");

                    int i = int.Parse(s);
                    txt.Text = string.Format("{0:###,###,###}", i);

                    txt.SelectionStart = txt.Text.Length;
                }
                catch
                {
                }
            }
        }

        // Fungsi untuk mendeteksi user tekan tombol enter
        public bool isEnter(KeyPressEventArgs e)
        {
            return (e.KeyChar == (char)Keys.Return);
        }

        // Fungsi untuk mendeteksi user tekan tombol escape (esc)
        public bool isEsc(KeyPressEventArgs e)
        {
            return (e.KeyChar == (char)Keys.Escape);
        }

        // Fungsi untuk clear textbox
        public void ClearTxt(Control con)
        {
            foreach (Control c in con.Controls)
            {
                if (c is TextBox)
                    ((TextBox)c).Clear();
                else
                    ClearTxt(c);
            }
        }

        public string GetBulanIndonesia(int bulan)
        {
            string namaBulan = "";

            if (bulan == 1)
                namaBulan = "JANUARI";
            else if (bulan == 2)
                namaBulan = "FEBRUARI";
            else if (bulan == 3)
                namaBulan = "MARET";
            else if (bulan == 4)
                namaBulan = "APRIL";
            else if (bulan == 5)
                namaBulan = "MEI";
            else if (bulan == 6)
                namaBulan = "JUNI";
            else if (bulan == 7)
                namaBulan = "JULI";
            else if (bulan == 8)
                namaBulan = "AGUSTUS";
            else if (bulan == 9)
                namaBulan = "SEPTEMBER";
            else if (bulan == 10)
                namaBulan = "OKTOBER";
            else if (bulan == 11)
                namaBulan = "NOVEMBER";
            else
                namaBulan = "DESEMBER";

            return namaBulan;
        }
    }
}
