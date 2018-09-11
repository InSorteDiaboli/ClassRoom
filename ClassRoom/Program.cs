using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            KlasseRum klasseRum = new KlasseRum();
            klasseRum.Klassenavn = "3B";
            klasseRum.SemesterStart = new DateTime(2018,9,4);
            klasseRum.Klasseliste = new List<Studerende>{new Studerende("Frederik", 1, 4), new Studerende("Louis", 4, 5), new Studerende("Vagner", 9, 6)};
            
            Console.WriteLine(klasseRum.Klassenavn);
            Console.WriteLine(klasseRum.SemesterStart);
            
            foreach (var student in klasseRum.Klasseliste)
            {
                Console.WriteLine(student);
            }

            klasseRum.SeasonCount();
            klasseRum.BirthSeasonLinq();
        }
    }
}
