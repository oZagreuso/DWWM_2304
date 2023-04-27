using System.Reflection;

namespace ControleSaisieAvecLimite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = " formation ";
            string saisie;
            int compteur = 0;

            do
            {
                Console.WriteLine(" Saisir le mot-de-passe ");

                saisie = Console.ReadLine();
                                             
                compteur++;                             

            }
            while (compteur <= 3);
            {
                do
                {
                    Console.WriteLine(" vous êtes connecté ");
                }
                while (password == saisie);
                {

                }
            }



            
        }
    }
}