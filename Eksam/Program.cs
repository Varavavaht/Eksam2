using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Threading;

namespace Eksam
{
    class Program
    {
        //public static string FirstCharToUpper(string input)
        //{
        //    if (String.IsNullOrEmpty(input))
        //        throw new ArgumentException("Sisestus on tühi, proovi uuesti!");
        //    return input.First().ToString().ToUpper() + input.Substring(1);
        //}
        static void Main(string[] args)
        {
         
            Console.WriteLine("Sisesta inimeste nimesid, kui oled lõpetanud, siis sisesta nime asemel -1");
            List<string> nimekiri = new List<string>();
            bool sisestus = true;
            while (sisestus)
            {
                string nimi = Console.ReadLine();
                if (nimi == "-1")
                {
                    break;
                }
                nimi.ToLower();

                //Get the culture property of the thread.
                CultureInfo cultureInfo = Thread.CurrentThread.CurrentCulture;
                //Create TextInfo object.
                TextInfo textInfo = cultureInfo.TextInfo;
                string nimi2 = textInfo.ToTitleCase(nimi);
                
                nimekiri.Add(nimi2);


                //string[] answer = new string[10];
                //for (int i = 0; i < answer.length; i++)
                //{
                //    answer[i] = Console.ReadLine();
                //}
                


            }
            foreach (var nimi_nimekirjas in nimekiri)
            {
                Console.WriteLine(nimi_nimekirjas);
            }
            Console.ReadLine();
        }
    }
}
