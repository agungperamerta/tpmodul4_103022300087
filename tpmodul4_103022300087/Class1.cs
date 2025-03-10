using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul4_103022300087
{
    class KodePos
    {
        private static string[] kelurahanList =
        {
        "Batununggal", "Kujangsari", "Mengger", "Wates", "Cijaura",
        "Jatisari", "Margasari", "Sekejati", "Kebonwaru", "Maleer", "Samoja"
    };

        private static string[] kodePosList =
        {
        "40266", "40287", "40267", "40256", "40287",
        "40286", "40286", "40286", "40272", "40274", "40273"
    };

        public static string GetKodePos(string kelurahan)
        {
            for (int i = 0; i < kelurahanList.Length; i++)
            {
                if (kelurahanList[i].Equals(kelurahan, StringComparison.OrdinalIgnoreCase))
                {
                    return kodePosList[i];
                }
            }
            return "Kode Pos tidak ditemukan!";
        }
    }

    class KodePosApp
    {
        static void Main()
        {
            Console.WriteLine("=== Program Kode Pos ===");
            Console.Write("Masukkan nama kelurahan: ");
            string kelurahan = Console.ReadLine();
            Console.WriteLine($"Kode Pos untuk {kelurahan}: {KodePos.GetKodePos(kelurahan)}");
        }
    }
}
