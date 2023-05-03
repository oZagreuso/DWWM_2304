namespace barnabeFaitSesCourses
{
    internal class Program
    {
        static void Main(string[] args)
        {                    
            double soldeRestant;
            int magasinVisite = 0;

            Console.WriteLine(" Barnabé fait ses courses ");
            Console.WriteLine(" indiquer le solde initial du compte de Barnabé ");
            soldeRestant = double.Parse(Console.ReadLine());           

            while (soldeRestant >= 0)
            {
                { 
                    soldeRestant = soldeRestant - ((soldeRestant / 2) + 1);
                }
                magasinVisite++;
            }
            if (soldeRestant < 1)
            {
                Console.WriteLine(" le nombre de magasins visités est de " + magasinVisite);
            }
        }
    }
}
