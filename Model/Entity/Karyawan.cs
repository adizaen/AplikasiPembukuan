using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AplikasiPembukuan.Model.Entity
{
    public class Karyawan : Akun
    {
        public string Nama { get; set; }
        public string Gender { get; set; }
        public string Telepon { get; set; }
    }
}
