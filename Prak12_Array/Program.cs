using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // membuat array sekaligus inisialisasi nilai
            string[] arrNama = { "Noey", "Sone", "Zero" };

            int[] arrNim = { 1989, 1990, 1991 };

            int[] arrNil = new int[3];
            arrNil[0] = 95;
            arrNil[1] = 90;
            arrNil[2] = 85;

            Console.WriteLine("=============================");
            Console.WriteLine(" No.   NIM     Nama    Nilai ");
            Console.WriteLine("=============================");
            for (int i = 0; i < arrNama.Length; i++)
            {
                Console.WriteLine(" " + (i + 1) + ".   " + arrNim[i] + "     " + arrNama[i] + "     " + arrNil[i]);
            }

            Console.ReadKey();
        }
    }
}
