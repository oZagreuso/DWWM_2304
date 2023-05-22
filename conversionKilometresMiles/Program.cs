namespace conversionKilometresMiles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string saisie;
            double valeur;
            bool conditionSaisieOk = true;
            double km = 0;
            double miles = 0;

            do
            {
                Console.WriteLine(" Programme de conversion de kilomètres en miles ");
                Console.WriteLine(" Saisir une valeur en km entre 0,01 et 1 000 000, sinon quitter avec la touche Q ");
                saisie = Console.ReadLine();


                if (saisie == "q")
                {
                    Console.WriteLine(" FIN PROGRAMME ");
                    conditionSaisieOk = false;

                }
                else
                if (double.TryParse(saisie, out km))
                {
                    if (km >= 0.01 && km <= 1000000)
                    {
                        miles = km * 1.609;
                        Console.WriteLine(km + " correspond à " + miles);
                    }
                    else
                    {
                        Console.WriteLine(" Valeur en dehors de la limite, saisir une nouvelle valeur comprise entre 0.01 et ,1 000 000 km ");
                    }
                }
                else
                {
                    Console.WriteLine(" ERREUR! saisie invalide! Renseigner une nouvelle valeur entre 0.01 et 1 000 000 ");
                }

            }
            while (!conditionSaisieOk);
        }
    }
}