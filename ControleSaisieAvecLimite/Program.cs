using System.Reflection;

namespace ControleSaisieAvecLimite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string mdp = "formation";
            int tentatives = 0;
            string saisie;

            Console.WriteLine(" Saisir mot-de-passe ");

            while (tentatives < 3)
            {                
                saisie = Console.ReadLine();

                if (saisie == mdp)
                {
                    Console.WriteLine(" Vous êtes connecté ");
                    return;
                }
                else
                {
                    Console.WriteLine(" Votre mote-de-passe est erroné. Saisir nouveau mot-de-passe ");
                    tentatives++;
                   
                }


            }

        }



    }
}
