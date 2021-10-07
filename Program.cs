using System;
using System.Collections.Generic;
using System.IO;

namespace Kangelased
{
    class Program
    {

        static List<Kangelased> kangelased = new List<Kangelased>();

        static void LaeKangelased(string failinimi) {
            var kangelasedFailis = File.ReadAllLines(failinimi);
            foreach (var kangelasKirje in kangelasedFailis) {
                var nimiAsukoht = kangelasKirje.Split(" / ");
                // Console.WriteLine(nimiAsukoht[0]);
                if (!nimiAsukoht[0].EndsWith('*')) {
                    kangelased.Add(new Kangelased(nimiAsukoht[0], nimiAsukoht[1]));
                } else {
                    kangelased.Add(new SuperKangelane(nimiAsukoht[0].Substring(0, nimiAsukoht[0].Length-1), nimiAsukoht[1]));
                    }
                }
            }
            static void Main(string[] args) {
            /*
            Kangelased superman = new Kangelased("Superman", "Smallville");
            int sajast = superman.Päästa(100);
            int poolsajast = superman.Päästa(50);
            Console.WriteLine(superman);
            Console.WriteLine($"sajast:{sajast}");
            Console.WriteLine($"viiekümnest:{poolsajast}");
            */
            LaeKangelased("kangelaste_andmed.txt");
            foreach(var kangelane in kangelased)
            {
                int päästetuid = 30;
                int ohus = new Random().Next(0, 31);
                Console.WriteLine(kangelane);
                Console.WriteLine($"{kangelane.GetNimi()} suutis päästa: {ohus}/{päästetuid}.");
            }
        }
    }
}
