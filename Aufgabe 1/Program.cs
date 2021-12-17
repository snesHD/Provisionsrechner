using System;

namespace Aufgabe_1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double Provision;
            double GesamtProvision = 0;
            ConsoleKeyInfo weiter;
            do {

                Console.WriteLine("\nGeben Sie den Gaeschaftsall ein, Cent Beträge bitte mit einem Komma!: ");
                double Geschaeftsfall = Convert.ToDouble(Console.ReadLine());
                if (Geschaeftsfall > 10000)
                {
                    Provision = Geschaeftsfall / 100 * 6;
                }
                else
                {
                    Provision = Geschaeftsfall / 100 * 3;
                }
                GesamtProvision = Math.Round(GesamtProvision + Provision, 2);
                
                Console.WriteLine("Ihre Provision: " + Math.Round(Provision,2) + " EURO");
                Console.WriteLine("Möchten Sie weitere Geschäftsfälle eingeben [Y/N]");
                
                weiter = Console.ReadKey();
                Console.Clear();
            }while (weiter.Key == ConsoleKey.Y);

            Console.WriteLine("\nIhre Gesamtprovision: \t" + Math.Round(GesamtProvision,2) + " EURO");
        }
    }
}
