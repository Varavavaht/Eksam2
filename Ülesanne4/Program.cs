using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ülesanne4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nimekiri = { "10.05.1975","20.08.2009","28.02.1942","05.10.1944","12.08.1999","30.08.1994","13.11.1947","19.03.1981","24.07.2004",
                "26.10.1971","07.04.1989","02.01.1952","01.08.1994","05.08.2007","26.07.1950","17.01.1941","23.06.1970","12.07.1943","29.11.1989","11.03.1995",
                "23.02.1947","21.09.1941","17.12.2005","27.03.1999","07.04.1950","25.02.1993","09.02.1972","26.07.1991","08.01.1988","13.03.1989"};
            var nimekiri2 = new List<DateTime>();
            var vastus = new DateTime();


            for (int i = 0; i < nimekiri.Length; i++)
            {

                vastus = DateTime.Parse(nimekiri[i]);
                nimekiri2.Add(vastus);

            }
            var maksimaalne_väärtus = new DateTime();
            var minimaalne_väärtus = new DateTime();
            minimaalne_väärtus = DateTime.Now;
            //maksimaalne_vanus = list1.Min(c => c.price);

            foreach (DateTime kuupäev in nimekiri2)
            {
                if (kuupäev < minimaalne_väärtus)
                    minimaalne_väärtus = kuupäev;
                if (kuupäev > maksimaalne_väärtus)
                    maksimaalne_väärtus = kuupäev;
            }
            Console.WriteLine("Väiksem kuupäev on " + minimaalne_väärtus);
            Console.WriteLine("Suurim kuupäev on " + maksimaalne_väärtus);
            Console.WriteLine();

            var vanus1 = new TimeSpan();
            var vanus2 = new TimeSpan();
            vanus1 = DateTime.Now - minimaalne_väärtus;
            vanus2 = DateTime.Now - maksimaalne_väärtus;

            var vastus1 = new DateTime();
            var vastus2 = new DateTime();
            vastus1 = vastus1 + vanus1;
            vastus2 = vastus2 + vanus2;

            Console.WriteLine("Noorim isik on vana: " + vastus2.Year + " aastat.");
            Console.WriteLine("Vanim isik on vana: " + vastus1.Year + " aastat.");
            Console.WriteLine();

            var keskmine = new TimeSpan();

            //foreach (DateTime kuupäev in nimekiri2)
            //{

            //    keskmine = (int)kuupäev.TotalMinutes;
            //}
            //for (int i = 0; i < nimekiri.Length; i++)
            //{

            //    vastus = DateTime.Parse(nimekiri[i]);
            //    nimekiri2.Add(vastus);

            //}

            //var keskmine = new DateTime((long)nimekiri2.Select(d => d.Ticks).Average());
            //Console.WriteLine("Keskmine on: " + keskmine);




            int jan = 0;
            int feb = 0;
            int mar = 0;
            int apr = 0;
            int mai = 0;
            int jun = 0;
            int jul = 0;
            int aug = 0;
            int sept = 0;
            int okt = 0;
            int nov = 0;
            int dets = 0;

            foreach (DateTime kuupäev in nimekiri2)
            {
                if (kuupäev.Month == 1)
                {
                    jan = jan + 1;
                }
                if (kuupäev.Month == 2)
                {
                    feb++;
                }
                if (kuupäev.Month == 1)
                {
                    mar++;
                }
                if (kuupäev.Month == 1)
                {
                    apr++;
                }
                if (kuupäev.Month == 1)
                {
                    mai++;
                }
                if (kuupäev.Month == 1)
                {
                    jun++;
                }
                if (kuupäev.Month == 1)
                {
                    jul++;
                }
                if (kuupäev.Month == 1)
                {
                    aug++;
                }
                if (kuupäev.Month == 1)
                {
                    sept++;
                }
                if (kuupäev.Month == 1)
                {
                    okt++;
                }
                if (kuupäev.Month == 1)
                {
                    nov++;
                }
                if (kuupäev.Month == 1)
                {
                    dets++;
                }
            }

            var kuud = new List<int>();
            kuud.Add(jan);
            kuud.Add(feb);
            kuud.Add(mar);
            kuud.Add(apr);
            kuud.Add(mai);
            kuud.Add(jun);
            kuud.Add(jul);
            kuud.Add(aug);
            kuud.Add(sept);
            kuud.Add(okt);
            kuud.Add(nov);
            kuud.Add(dets);

            string jan1 = "jaanuaris";
            string feb1 = "veebruaris";
            string mar1 = "märtsis";
            string apr1 = "aprillis";
            string mai1 = "mais";
            string jun1 = "juunis";
            string jul1 = "juulis";
            string aug1 = "augustis";
            string sept1 = "septembris";
            string okt1 = "oktoobris";
            string nov1 = "novembris";
            string dets1 = "detsembris";

            var kuud2 = new List<string>();
            kuud2.Add(jan1);
            kuud2.Add(feb1);
            kuud2.Add(mar1);
            kuud2.Add(apr1);
            kuud2.Add(mai1);
            kuud2.Add(jun1);
            kuud2.Add(jul1);
            kuud2.Add(aug1);
            kuud2.Add(sept1);
            kuud2.Add(okt1);
            kuud2.Add(nov1);
            kuud2.Add(dets1);

            int levinuim_kuu_arv = 0;
            foreach (int kuu in kuud)
            {

                if (kuu > levinuim_kuu_arv)
                    levinuim_kuu_arv = kuu;
            }

            //Console.WriteLine("Kõige rohkem on ühes kuus sünnipäevi " + levinuim_kuu_arv + " korda.");

            for (int i = 0; i < kuud.Count; i++)
            {

                if (kuud[i] == levinuim_kuu_arv)
                {
                    Console.WriteLine("Kõige rohkem on sünnipäevi " + kuud2[i] + ", " + levinuim_kuu_arv + " korda.");
                }
            }
            Console.WriteLine();

            int aastaid_kokku = 0;

            for (int i = 0; i < nimekiri.Length; i++)
            {

                vastus = DateTime.Parse(nimekiri[i]);
                aastaid_kokku = aastaid_kokku + vastus.Year;

            }
            int keskmine_aasta_väärtus = aastaid_kokku / nimekiri.Length;
            //Console.WriteLine("Aastad kõik kokku: " + aastaid_kokku);
            Console.WriteLine("Keskmine aastate väärtus: " + keskmine_aasta_väärtus);
            var praegune_aeg = DateTime.Now;
            int praegune_aasta = praegune_aeg.Year;
            int keskmine_vanus = praegune_aasta - keskmine_aasta_väärtus;
            Console.WriteLine("Keskmine vanus on " + keskmine_vanus + " aastat!");
            Console.WriteLine();


            nimekiri2.Sort();
            Console.WriteLine("Sorteeritud nimekiri kasvavalt:");
            Console.WriteLine();
            foreach (var nimi_nimekirjas in nimekiri2)
            {
                Console.WriteLine(nimi_nimekirjas);
            }

            Console.ReadLine();





        }
    }
}
