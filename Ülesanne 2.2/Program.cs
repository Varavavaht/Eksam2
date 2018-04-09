using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ülesanne_2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kasutaja! Sisesta enda poolt soovitu ja arvuti parandab sobivad nimed õigeks!");
            Console.WriteLine("Pea meeles! Ära sisesta kirjavahemärke nimedega kokku!");
            //märkus komade kohta, ei tohi olla seotud nimedega.
            string sisestus = Console.ReadLine();
            var nimekiri = sisestus.Split(' ');
            string sisestus2 = sisestus.ToLower();
            var nimekiri2 = sisestus2.Split(' ');
            //Tee lause sõnadeks ja pane arraysse. Tee kõik lower case'iks ja pane array2'te, kontrolli nimesid ja vajadusel tee vahetus array 1's. Tee array 1 stringiks
            var nimed = new List<string>();
            var nimed2 = new List<string>();
            var nimekiri3 = new List<string>();
            //nimed.InsertRange(nimed.Count - 1, new string[] { "Kaur", "Mattias", "Kristel", "Heleri", "Trevor", "Kristjan", "Kelli", "Kevin", "Maarika", "Laura" });
            //nimed2.InsertRange(nimed.Count - 1, new string[] { "kaur", "mattias", "kristel", "heleri", "trevor", "kristjan", "kelli", "kevin", "maarika", "laura" });

            nimed.Add("Kaur");
            nimed.Add("Mattias");
            nimed.Add("Kristel");
            nimed.Add("Heleri");
            nimed.Add("Trevor");
            nimed.Add("Kristjan");
            nimed.Add("Kelli");
            nimed.Add("Kevin");
            nimed.Add("Maarika");
            nimed.Add("Laura");

            foreach (var nimi in nimekiri2)
            {
                string esimene_täht = char.ToUpper(nimi[0]) + nimi.Substring(1);
                if (nimed.Any(esimene_täht.Contains))
                {
                    Console.Write(esimene_täht + " ");
                }
                else
                {
                    Console.Write(nimi + " ");
                }
            }
            Console.ReadLine();
        }
    }
}
