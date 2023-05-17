namespace calculNombresParfaits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nombre = 1;          
            int compteur = 0;          

            while (compteur <= 4)
            {
                int sommeDiviseurs = 0;
                for (int diviseur = 1; diviseur < nombre; diviseur++)
                {
                    if (nombre % diviseur == 0)
                    {
                        sommeDiviseurs += diviseur; // exemple:  sommeDiviseur = (somme diviseur + diviseur) <- ajout
                    }
                }
                if (sommeDiviseurs == nombre)
                {
                    Console.WriteLine(nombre + " est un nombre parfait");
                    compteur++;
                }
                nombre++;
            }
        }
    }
}