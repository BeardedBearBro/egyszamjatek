using Ca201904091;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egyszamjatek
{
    class Program
    {
        static List<Jatekos> jatekosok;
        static int FSorszam;
        static void Main(string[] args)
        {
            F02();
            F03();
            F04();
            F05();
            Console.ReadKey();
        }

        private static void F05()
        {
            Console.Write("5.Feladat");
            int sum = 0;

            foreach (var j in jatekosok)
            {
                sum += j.tippek[FSorszam - 1];
            }
            Console.Write("A forduló tippjeinek az átlaga: {0:0.00}",(float)sum/jatekosok.Count);
        }

        private static void F04()
        {
            Console.Write("4.Feladat");

            Console.Write("Kérem a forduló sorszámmát : ");
            FSorszam = int.Parse(Console.ReadLine());


        }

        private static void F03()
        {
            Console.Write("3.Feladat");
            Console.WriteLine($"Játkosok száma: {jatekosok.Count} fő" );
        }

        private static void F02()
        {
            jatekosok = new List<Jatekos>();
            var sr = new StreamReader("egyszamjatek.txt", Encoding.UTF8);

            while (!sr.EndOfStream)
            {
                jatekosok.Add(new Jatekos(sr.ReadLine()));
            }
            sr.Close();
        }
    }
}
