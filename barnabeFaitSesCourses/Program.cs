using System;

namespace barnabeFaitSesCourses
{
    internal class Program
    {
        static void Main(string[] args)
        {                    
            double solde;            
            int magasinVisite = 1;

            Console.WriteLine(" Barnabé fait ses courses ");
            Console.WriteLine(" indiquer le solde initial du compte de Barnabé ");
            solde = double.Parse(Console.ReadLine());

            while (solde >= ((solde / 2) + 1))
            {
            double depenses = 0;
            depenses = ((solde / 2) + 1);
            solde = solde - depenses;                
            magasinVisite++;
            }          
            Console.WriteLine(" le nombre de magasins visités est de " + magasinVisite);
            if (solde > 0)
            {
                Console.WriteLine(" Barnabé a dépensé " + solde + " euros dans un seul magasin ");
            }
            if (solde == 0)
            {
                Console.WriteLine(" mais Barnabé n'a pas d'argent, il ne peut pas faire de shopping ");
            }
        }
    }
}
