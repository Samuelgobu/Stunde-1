using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stunde_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hallo Welt!");
            
            //Datentypen: Ganye Yahlen, Deyimalyahlen, zichenketten, Zeichen, Wahrheitswert (Boolean)

            // Ganze Zahlen:
            int ganzeZahlA = 42;
            int ganzeZahlB;
            ganzeZahlB = 7;
            Console.WriteLine(ganzeZahlA);
            Console.WriteLine(ganzeZahlB);
            short kleinGanzeZahl;
            long großeGanzeZahl;
            int ganzeZahlC = ganzeZahlA % ganzeZahlB;
            Console.WriteLine(ganzeZahlC);

            //Gleitkommazahlen (DeyimalZahlen)
            double gleitkommazahl = 3;
            double gleitkommazahlB = 5;
            decimal großeGleitkommazahl;
            Console.WriteLine (gleitkommazahl / gleitkommazahlB);
            // int zu double = Kein Propblem
            //double zu int = Braucht Eingreifen

            bool wahrheitswert = true;
            //später mehr

            // Zeichen und Zeichenketten
            char Zeichen = '&';
            string zeichenketten = "Hallo Welt";
            // string + string := Konkatenation
        }
    }
}
