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

            while (tentatives <= 3)
            {
                Console.WriteLine(" Saisir mot-de-passe ");
                saisie = Console.ReadLine();

                if (saisie == mdp)
                {
                    Console.WriteLine(" Vous êtes connecté ");
                    return;
                }
                else
                {
                    Console.WriteLine(" Votre mote-de-passe est erroné. ");
                    tentatives++;
                   
                }
      


            }
            if (tentatives > 3)
            {
                Console.WriteLine(" Votre compte est bloqué ");
            }

        }



    }
}
