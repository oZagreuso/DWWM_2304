using System;

namespace conversionKmMiles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void Main()
            {

                string saisie;
                bool saisieOk = true;
                double distanceEnKm;
                double distanceEnMil;




                do
                {
                    Console.Write("Saisir une valeur en kilomètres comprise entre 0,01 et 1 000 000 ou taper pour quitter ");
                    saisie = Console.ReadLine();
                }
                while (saisieOk = true);

                if (saisie == "q")
                {
                    Console.WriteLine(" Fin du Programme ");
                    saisieOk = false;
                }
                else
                {

                    if (double.TryParse(saisie, out distanceEnKm) || distanceEnKm < 0.01 || distanceEnKm > 1000000)
                    {
                        Console.WriteLine(" Erreur des saisie!!, Saisir une nouvelle valeur en kilomètres entre 0,01 et 100 000 ");
                    }
                    else
                    {
                        distanceEnMil = distanceEnKm / 1.609;
                        Console.WriteLine(saisie + " kilomètres équivaut à " + distanceEnMil + " miles", distanceEnKm, distanceEnMil);

                    }

                }


            }
        }
    }
}
