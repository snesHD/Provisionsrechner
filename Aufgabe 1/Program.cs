using System;

namespace Aufgabe_1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double Provision;
            double GesamtProvision = 0;
            string weiter = "Y";
            do {

                Console.WriteLine("\nGeben Sie den Gaeschaftsall ein: ");
                double Geschaeftsfall = Convert.ToDouble(Console.ReadLine());
                if (Geschaeftsfall > 10000)
                {
                    Provision = Geschaeftsfall / 100 * 6;
                    Console.WriteLine("Ihre Provision: " + Provision);
                    GesamtProvision = GesamtProvision + Provision;
                    Console.WriteLine("\nNeue Gesamtprovision: " + GesamtProvision + "\n");
                }
                else
                {
                    Provision = Geschaeftsfall / 100 * 3;
                    Console.WriteLine("Ihre Provision: " + Provision);
                    GesamtProvision = GesamtProvision + Provision;
                    Console.WriteLine("\nNeue Gesamtprovision: " + GesamtProvision + "\n");
                }

                Console.WriteLine("Möchten Sie weitere Geschäftsfälle eingeben");
                Console.WriteLine("y für Weitermachen");
                weiter = Console.ReadLine();

            }while (weiter.ToLower() == "y");

            Console.WriteLine("\nIhre Gesamtprovision: \t" + GesamtProvision);
        }
    }
}
