namespace barnabeFaitSesCourses
{
    internal class Program
    {
        static void Main(string[] args)
        {                    
            double solde;
            double depenses = 0;
            int magasinVisite = 0;

            Console.WriteLine(" Barnabé fait ses courses ");
            Console.WriteLine(" indiquer le solde initial du compte de Barnabé ");
            solde = double.Parse(Console.ReadLine());
            depenses = ((solde / 2) + 1);

            while (solde > depenses)
            {
                {                     
                    solde = solde - ((solde / 2) + 1);
                }
                magasinVisite++;
            }
            if (solde <= depenses)
            {
                Console.WriteLine(" le nombre de magasins visités est de " + magasinVisite);
            }
        }
    }
}
