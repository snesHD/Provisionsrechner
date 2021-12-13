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
                    Console.WriteLine("Ihre Provision: " + Provision);
                    GesamtProvision = Math.Round(GesamtProvision + Provision,2);
                    Console.WriteLine("\nNeue Gesamtprovision: " + GesamtProvision + "\n");
                }
                else
                {
                    Provision = Geschaeftsfall / 100 * 3;
                    Console.WriteLine("Ihre Provision: " + Provision);
                    GesamtProvision = Math.Round(GesamtProvision + Provision, 2);
                    Console.WriteLine("\nNeue Gesamtprovision: " + GesamtProvision + "\n");
                }

                Console.WriteLine("Möchten Sie weitere Geschäftsfälle eingeben");
                Console.WriteLine("y für Weitermachen");
                weiter = Console.ReadKey();

            }while (weiter.Key == ConsoleKey.Y);

            Console.WriteLine("\nIhre Gesamtprovision: \t" + Math.Round(GesamtProvision,2));
        }
    }
}
