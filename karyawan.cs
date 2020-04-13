using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman2618
{
    class Karyawan
    {
        public string Name { get; set; }
        public int NIK { get; set; }
        public int GajiBulanan { get; set; }

        public Karyawan(string name, int nik, int gajibulanan)
        {
            this.Name = name;
            this.NIK = nik;

            if (gajibulanan < 0)
            {
                this.GajiBulanan = 0;
            }
            else
            {
                this.GajiBulanan = gajibulanan;
            }
        }

        public void lihatKaryawan()
        {
            Console.WriteLine("{0} \t {1} \t {2}", NIK, Name, GajiBulanan);
        }

        public void NaikGaji()
        {
            double tmp = 0;
            tmp = 0.1 * GajiBulanan;
            GajiBulanan += Convert.ToInt32(tmp);
            Console.WriteLine("{0} \t {1} \t {2} ", NIK, Name, GajiBulanan);
        }
    }
}