using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman2618
{
    class Program
    {
        static void Main(string[] args)
        {
            Karyawan karyawan = new Karyawan("Yoga",192618 , 500000);
            Karyawan karyawan2 = new Karyawan("Wahyu",192619, 400000);
            Karyawan karyawan3 = new Karyawan("Tama", 192620, 350000);

            Console.WriteLine("NIK \t Nama \t Gaji");
            Console.WriteLine("--------------------------");
            karyawan.lihatKaryawan();
            Console.WriteLine();
            karyawan2.lihatKaryawan();
            Console.WriteLine();
            karyawan3.lihatKaryawan();

            Console.WriteLine("\n\n Asikkk kenaikan gaji cuy");

            Console.WriteLine("NIK \t Nama \t Gaji");
            Console.WriteLine("--------------------------");
            karyawan.NaikGaji();
            Console.WriteLine();
            karyawan2.NaikGaji();
            Console.WriteLine();
            karyawan3.NaikGaji();

            Console.ReadKey();
        }
    }
}