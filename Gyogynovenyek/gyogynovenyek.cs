using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.IO;

namespace Gyogynovenyek
{
    class Noveny
    {
        public string Nev { get; private set; }
        public string Resz { get; private set; }
        public int Kezd { get; private set; }
        public int Veg { get; private set; }
        public int Idotartam { get; private set; }
        static List<Noveny> lista = new List<Noveny>();
        public Noveny(string adat)
        {
            adat = "Acsalapu;levél;6;8";
        }
        static void Beolvasas(List<string> l)
        {
            StreamReader file = new StreamReader("noveny.csv");
            while (!file.EndOfStream)
            {
                string[] adatok = file.ReadLine().Split(';');
                l.Add(file.ReadLine());
            }
            file.Close();
        }
    }
}