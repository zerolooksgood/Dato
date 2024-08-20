using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
//Oppg 1
namespace Dato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Oppg 2
            int maaned1;
            int dag1;
            int maaned2;
            int dag2;
            //Variablene må defineres utenfor try-catch slik at de kan brukes på andre steder i koden
            while (true) //Jeg bruker en while (true) loop slik at den gjenntar sge helt til du har gitt gydlige tall
            {
                try //Programmet prøver å kjøre denne koden
                {
                    Console.WriteLine("Hvilken måned er datoen i (heltall)");
                    maaned1 = Convert.ToInt32(Console.ReadLine()); //Jeg bruker Convert.ToInt32() for å konverte teksten til et tall
                    Console.WriteLine("Hvilken dag i denne måneden er datoen (heltall 1-31)");
                    dag1 = Convert.ToInt32(Console.ReadLine());
                    break; //Bryter while (true) loopen. Denne koden kan kun kjøre hvis all koden før den har kjørt uten feil
                } catch (Exception ex) //Hvis det oppstår en error, for eksempel hvis brukeren skriver noe som ikke er et heltall fordi det ikke kan konverteres til en integer så kjøres denne koden
                {
                    Console.WriteLine(ex.Message); //Printer errormeldingen
                }
            }
            while (true) //Det samme bare med den andre datoen
            {
                try
                {
                    Console.WriteLine("Hvilken måned er den andre datoen i (heltall)");
                    maaned2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Hvilken dag i denne måneden er datoen (heltall 1-31)");
                    dag2 = Convert.ToInt32(Console.ReadLine());
                    break;
                } catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            //Oppg 3
            if (maaned1 == maaned2 && dag1 == dag2) //Sjekker om datoene er helt like
            {
                Console.WriteLine("Det er samme dato");
            } else if (maaned1 > maaned2) //Sjekker om den andre måneden er før den første
            {
                Console.WriteLine("Det er feil rekkefølge");
            } else if (maaned1 == maaned2 && dag1 > dag2) //Sjekker om dagen på dne andre datoen er først hvis måeneden er lik
            {
                Console.WriteLine("Det er feil rekkefølge");
            } else
            {
                Console.WriteLine("Det er riktig rekkefølge");
            }

            Console.ReadLine(); //For å hindre at programmet lukker seg selv
        }
    }
}
