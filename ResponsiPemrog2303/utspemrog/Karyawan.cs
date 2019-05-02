using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace utspemrog
{
    public class Karyawan
    {
        public Karyawan()
        {

        }

        public Karyawan(string nik, string nama, int gajibulanan)
        {
            Nik = nik;
            Nama = nama;
            GajiBulanan = gajibulanan;
        }

        public string Nik { get; set; }
        public string Nama { get; set; }
        public int GajiBulanan { get; set; }
    }
}
