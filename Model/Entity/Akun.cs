using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AplikasiPembukuan.Model.Entity
{
    public class Akun
    {
        public string KodeKaryawan { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string HakAkses { get; set; }
    }
}
