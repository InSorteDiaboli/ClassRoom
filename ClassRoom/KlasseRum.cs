using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class KlasseRum
    {
        public string Klassenavn { get; set; }
        public List<Studerende> Klasseliste { get; set; }
        public DateTime SemesterStart { get; set; }

        public KlasseRum()
        {
            
        }

        public void SeasonCount()
        {
            int numberofSpring = 0;
            int numberofSummer = 0;
            int numberofAutumn = 0;
            int numberofWinter = 0;

            foreach (var student in Klasseliste)
            {
                switch (student.Fødselsmåned)
                {
                    case 3:
                    case 4:
                    case 5:
                        numberofSpring++;
                        break;
                    case 6:
                    case 7:
                    case 8:
                        numberofSummer++;
                        break;
                    case 9:
                    case 10:
                    case 11:
                        numberofAutumn++;
                        break;
                    case 12:
                    case 1:
                    case 2:
                        numberofWinter++;
                        break;
                        default: throw new ArgumentException("Sæson eksisterer ikke");
                        
                }
            }

            Console.WriteLine($"Antallet af elever der har fødselsdag i hver sin sæson er: {numberofSpring} elever om foråret, {numberofSummer} elever om sommeren, {numberofAutumn} elever om efteråret og {numberofWinter} elever om vinteren");
        }

        public void BirthSeasonLinq()
        {
            var amountVinter = from s in Klasseliste
                where s.Fødselsmåned == 1 || s.Fødselsmåned == 2 || s.Fødselsmåned == 12
                select s;
            var amountSpring = from s in Klasseliste
                where s.Fødselsmåned == 3 || s.Fødselsmåned == 4 || s.Fødselsmåned == 5
                select s;
            var amountSummer = from s in Klasseliste
                where s.Fødselsmåned == 6 || s.Fødselsmåned == 7 || s.Fødselsmåned == 8
                select s;
            var amountAutumn = from s in Klasseliste
                where s.Fødselsmåned == 9 || s.Fødselsmåned == 10 || s.Fødselsmåned == 11
                select s;
            Console.WriteLine(amountSpring.Count() + " elever om foråret");
            Console.WriteLine(amountSummer.Count() + " elever om sommeren");
            Console.WriteLine(amountAutumn.Count() + " elever om efteråret");
            Console.WriteLine(amountVinter.Count() + " elever om vinteren");
        }
    }
}
