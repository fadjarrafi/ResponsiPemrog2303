using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace utspemrog
{
    class Program
    {
        static void Main(string[] args)
        {
            Karyawan krysatu = new Karyawan();

            krysatu.Nik = "212121";
            krysatu.Nama = "Dwi";
            krysatu.GajiBulanan = 1000000;

            if (krysatu.GajiBulanan < 0)
            {
                krysatu.GajiBulanan = 0;
            }
            else
            {
                krysatu.GajiBulanan = krysatu.GajiBulanan;
            }

            Karyawan krydua = new Karyawan();

            krydua.Nik = "121212";
            krydua.Nama = "Yoga";
            krydua.GajiBulanan = 500000;

            if (krydua.GajiBulanan < 0)
            {
                krydua.GajiBulanan = 0;
            }
            else
            {
                krydua.GajiBulanan = krydua.GajiBulanan;
            }

            Console.WriteLine("No. \tNIK/nama\t\tGaji Bulanan");
            Console.WriteLine("------------------------------");
            Console.WriteLine("1. \t{0} {1}\t\t{2}", krysatu.Nik, krysatu.Nama, krysatu.GajiBulanan);
            Console.WriteLine("1. \t{0} {1}\t\t{2}", krydua.Nik, krydua.Nama, krydua.GajiBulanan);
            Console.WriteLine("\n\n");
            Console.WriteLine("Aseeekkkk kenaikan gaji 10% !!");
            Console.WriteLine("\n");
            Console.WriteLine("No. \tNIK/nama\t\tGaji Bulanan");
            Console.WriteLine("------------------------------");
            Console.WriteLine("1. \t{0} {1}\t\t{2}", krysatu.Nik, krysatu.Nama, krysatu.GajiBulanan + (krysatu.GajiBulanan * 0.10));
            Console.WriteLine("1. \t{0} {1}\t\t{2}", krydua.Nik, krydua.Nama, krydua.GajiBulanan + (krysatu.GajiBulanan * 0.10));
            Console.ReadKey();
        }
    }
}
