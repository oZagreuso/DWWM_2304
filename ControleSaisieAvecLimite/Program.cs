using System.Reflection;

namespace ControleSaisieAvecLimite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string mdp = "formation";
            int tentatives = 1;
            string saisie;
                        
            do
            { 
            Console.WriteLine(" Saisir mot-de-passe ");
            saisie = Console.ReadLine();

                if (saisie == mdp)
                {
                    Console.WriteLine(" Vous êtes connecté ");
                }
                else
                {
                    Console.WriteLine(" Votre mot-de-passe est erroné ");
                    tentatives++;
                }
            }   
            while (tentatives <= 3 && saisie != mdp);
                    
                if (tentatives > 3)
                {
                    Console.WriteLine(" Votre compte est bloqué ");
                }              
        }
    }
}
