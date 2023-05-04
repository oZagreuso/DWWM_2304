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

            while (solde >= ((solde / 2) + 1))
            {
            depenses = ((solde / 2) + 1);
            solde = solde - depenses;                
            magasinVisite++;
            }          
                Console.WriteLine(" le nombre de magasins visités est de " + magasinVisite);
            
        }
    }
}
