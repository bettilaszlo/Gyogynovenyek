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
        static void Beolvasas()
        {
            StreamReader file = new StreamReader("noveny.csv");
            while (!file.EndOfStream)
            {
                string[] adatok = file.ReadLine().Split(';');
            }
            file.Close();
        }
        static void Main(string[] args)
        {
            Beolvasas();
           
            Console.ReadKey();
        }
    }
}
