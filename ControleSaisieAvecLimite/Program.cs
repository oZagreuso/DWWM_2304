using System.Reflection;

namespace ControleSaisieAvecLimite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = "formation";
            string saisie;
            int essaiMdp = 0;


            while (essaiMdp < 3) ;
            {
                Console.WriteLine(" Saisir mot-de-passe ");

                saisie = Console.ReadLine();

                if (password == saisie) ;
                {
                    Console.WriteLine(" Vous êtes connecté ");
                }
                if ()
                {
                    Console.WriteLine(" Votre compte est bloqué ");
                    return
                }


            }

        }



    }
}
