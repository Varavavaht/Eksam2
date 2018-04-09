using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ülesanne3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Proramm küsib kasutaja käest kolme sisendit: a) minimaalne aasta arv, b) maksimaalne aasta arv, c) suvaliselt genereeritavate andmete hulka.
            //Vastavalt sisestatud andmetele genereeritakse suvalislet etteantud vahemikus ja hulgal timestamp’e.

            var min_aasta = new DateTime();
            var max_aasta = new DateTime();
            var vastus = new DateTime();
            var vastuste_nimekiri = new List<DateTime>();
            Console.Write("Sisesta minimaalne aasta arv: ");
            string miinimum = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Sisesta maksimaalne aasta arv: ");
            string maksimum = Console.ReadLine();
            Console.WriteLine("Sisesta suvaliselt genereeritavate timestamp'ide arv");
            string sisestus = Console.ReadLine();

            //Parse'ime timestamp'id ja int'i
            int hulk = 0;
            int.TryParse(sisestus, out hulk);
            int aasta1 = 0;
            int.TryParse(miinimum, out aasta1);
            int aasta2 = 0;
            int.TryParse(maksimum, out aasta2);
            //AddYears.min_aasta = DateTime.Parse(miinimum);
            //max_aasta.Year = DateTime.Parse(miinimum);

            min_aasta = min_aasta.AddYears(aasta1);
            max_aasta = max_aasta.AddYears(aasta2);

            if (min_aasta > max_aasta)
            {
                Console.WriteLine("Sa sisestasid varasema lõpukuupäeva kui alguskuupäev. Programm ei pruugi õigesti töötada");
            }

            
            var ajavahemik = new TimeSpan();
            ajavahemik = max_aasta - min_aasta;
            //double päevad = ajavahemik.TotalMinutes;
            int päevad2 = 0;
            int.TryParse(sisestus, out päevad2);

            var rnd = new Random();
            //TimeSpan newSpan = new TimeSpan(0, rnd.Next(0, (int)ajavahemik.TotalMinutes), 0);
            //DateTime newDate = min_aasta + newSpan;

            TimeSpan liidetav_aeg = new TimeSpan();
            int timestampid = 0;
            int aeg=0;

            for (int i = 0; i < hulk; i++)
            {
                aeg = rnd.Next(0, (int)ajavahemik.TotalMinutes);
                liidetav_aeg = TimeSpan.FromMinutes(aeg);
                vastus = min_aasta + liidetav_aeg;
                vastuste_nimekiri.Add(vastus);

            }
            foreach (var nimi_nimekirjas in vastuste_nimekiri)
            {
                Console.WriteLine(nimi_nimekirjas);
            }
            Console.ReadLine();




            //var date99 = DateTime.Parse("13.03.1989"); //Suund on USA-le, mitte Eesti omale.
            //Console.WriteLine($"Day: { date.Day}");
            //Console.WriteLine($"Month: { date.Month}");
            //Console.WriteLine($"Hour: { date.Hour}");
            //Console.WriteLine(DateTime.Now.ToString());

            //var born = new DateTime(1989, 9, 10, 21, 45, 21);
            //Console.WriteLine(born);
        }
    }
}
