using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _2023_10_25_feladat
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            List<Bolygok> bolygok = new List<Bolygok>();
            StreamReader sr = new StreamReader(@"..\..\src\solsys.txt");
            while (!sr.EndOfStream)
            {
                bolygok.Add(new Bolygok(sr.ReadLine()));
            }

            Console.WriteLine("3. feladat:");
            Console.WriteLine($"\t3.1: {bolygok.Count} van a naprendszerben");
            double bolygohold = 0;
            double maxterfogat = 0;
            string maxbolygo = "";
            for (int i = 0; i < bolygok.Count; i++)
            {
                if (bolygok[i].Arany >maxterfogat)
                {
                    maxterfogat = bolygok[i].Arany;
                    maxbolygo = bolygok[i].Bolygo;
                }
                bolygohold += bolygok[i].HoldakSzama;
            }
            double bolygoholdatlag = bolygohold / bolygok.Count;
            Console.WriteLine($"\t3.2: a naprendszerben egy bolygónak átlagosan {bolygoholdatlag} holdja van");
            Console.WriteLine($"\t3.3: a legnagyobb trfogatú bolygó: {maxbolygo}");
            Console.Write("\t3.4: Írd be a keresett bolygó nevét: ");
            string bolygoinput = Console.ReadLine();
            string vannincs="";
            for (int i = 0; i < bolygok.Count; i++)
            {
                if (bolygok[i].Bolygo==bolygoinput)
                {
                    vannincs = "Van ilyen bolygó";
                    break;
                }
                else
                {
                    vannincs = "sajnos nincs ilyen bolygó a naprendszerben";
                }
            }
            Console.WriteLine($"\t\t{vannincs}");
            Console.Write("\t3.5 Írj be egy egész számot: ");
            int holdszam = Convert.ToInt32(Console.ReadLine());
            List<string> y = new List<string>();
            string x = "[";
            for (int i = 0; i < bolygok.Count; i++)
            {
                if (bolygok[i].HoldakSzama>holdszam)
                {
                    x += $"'{bolygok[i].Bolygo}',";
                }
            }
            x += "]";
            Console.WriteLine($"\t\ta következő bolygóknak van {holdszam}-nál/nél több holdja: ");
            Console.WriteLine($"\t\t{x}");



            Console.ReadKey();

            
        }
    }
}
