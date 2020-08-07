using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AplikasiPembukuan.Model.Entity
{
    public class Pembukuan
    {
        public string ID { get; set; }
        public DateTime Tanggal { get; set; }
        public string Item { get; set; }
        public double Debit { get; set; }
        public double Kredit { get; set; }
        public double Saldo { get; set; }
        public double Laba { get; set; }
        public string Keterangan { get; set; }
    }
}
