using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ülesanne_2._1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Esialgne versioon! Probleem on nimedega kui kirjutada koos mingi liitega.


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

            nimed2.Add("kaur");
            nimed2.Add("mattias");
            nimed2.Add("kristel");
            nimed2.Add("heleri");
            nimed2.Add("trevor");
            nimed2.Add("kristjan");
            nimed2.Add("kelli");
            nimed2.Add("kevin");
            nimed2.Add("maarika");
            nimed2.Add("laura");

            foreach (var nimi_nimekirjas in nimekiri2)
            {
                nimi_nimekirjas.Replace(" ", string.Empty);
                nimekiri3.Insert(nimekiri3.Count, nimi_nimekirjas);
            }

            for (int i = 0; i < nimekiri.Length; i++)
            {
                if (nimekiri3[i] == nimed2[0])
                {
                    nimekiri[i] = nimed[0];
                }
                if (nimekiri3[i] == nimed2[1])
                {
                    nimekiri[i] = nimed[1];
                }
                if (nimekiri3[i] == nimed2[2])
                {
                    nimekiri[i] = nimed[2];
                }
                if (nimekiri3[i] == nimed2[3])
                {
                    nimekiri[i] = nimed[3];
                }
                if (nimekiri3[i] == nimed2[4])
                {
                    nimekiri[i] = nimed[4];
                }
                if (nimekiri3[i] == nimed2[5])
                {
                    nimekiri[i] = nimed[5];
                }
                if (nimekiri3[i] == nimed2[6])
                {
                    nimekiri[i] = nimed[6];
                }
                if (nimekiri3[i] == nimed2[7])
                {
                    nimekiri[i] = nimed[7];
                }
                if (nimekiri3[i] == nimed2[8])
                {
                    nimekiri[i] = nimed[8];
                }
                if (nimekiri3[i] == nimed2[9])
                {
                    nimekiri[i] = nimed[9];
                }
                
            }
            string lõplik_vastus = string.Join(" ", nimekiri);
            Console.WriteLine(lõplik_vastus);
            Console.ReadLine();
        }
    }
}
