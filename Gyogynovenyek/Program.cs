using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Gyogynovenyek
{
    class Program
    {
        static List<Noveny> novenyek = new List<Noveny>();
        static Dictionary<string, int> reszek = new Dictionary<string, int>();
        static void Beolvasas()
        {
            StreamReader file = new StreamReader("noveny.csv");
            while (!file.EndOfStream)
            {
                novenyek.Add(new Noveny(file.ReadLine()));
            }
            file.Close();
        }
        static void ElsoFeladat()
        {
            Console.WriteLine("1. feladat: Növények száma {0}", novenyek.Count);

        }
        static void MasodikFeladat()
        {
            Console.WriteLine("\n2. feladat: Gyűjthető részek: ");
            foreach (var n in novenyek)
            {
                if (!reszek.ContainsKey(n.Resz))
                {
                    reszek.Add(n.Resz, 0);
                }
            }
            foreach (var n in novenyek)
            {
                reszek[n.Resz]++;
            }
            foreach (var r in reszek)
            {
                Console.WriteLine($"{r.Key}: {r.Value}");
            }
        }
        static void HarmadikFeladat()
        {
            int max = 0;
            foreach (var n in novenyek)
            {
                if (n.Idotartam> max)
                {
                    max = n.Idotartam;
                }
            }
            foreach (var n in novenyek)
            {
                if (n.Idotartam==max)
                {
                    Console.WriteLine("\n3. feladat\nLegtöbb idő amíg gyűjthető: {0} \nNövény:{1}", max, n.Nev);
                }

            }
        }
        static void NegyedikFeladat()
        {
            double szum = 0;
            double atlag;
            foreach (var n in novenyek)
            {
                szum += n.Idotartam;
            }
            atlag = szum / novenyek.Count;
            Console.WriteLine("\n4. feladat: Átlagos gyűjthető időtartam: {0}", atlag);
        }
        static void Main(string[] args)
        {
            var n = new Noveny("Acsalapu;levél;6;8");
            Beolvasas();
            ElsoFeladat();
            MasodikFeladat();
            HarmadikFeladat();
            NegyedikFeladat();
            Console.ReadKey();
        }
    }
}
