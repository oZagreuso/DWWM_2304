using System.IO.IsolatedStorage;

namespace rechercherUneLettreDansUnePhrase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string saisiePhrase;
            char saisieLettre;
            int i = 0;
            int occurence = 0;

            Console.WriteLine(" Programme de recherche de lettres dans une phrase ");

            Console.WriteLine(" Entrer une phrase ");
            saisiePhrase = (Console.ReadLine());
            Console.WriteLine(" Entrer une lettre ");
            saisieLettre = char.Parse(Console.ReadLine());


            if (saisiePhrase == "" || saisiePhrase == ".")
            {
                Console.WriteLine(" La phrase est vide ");
            }
            else
            {
               
                while (i < saisiePhrase.Length)
                {
                    if (saisieLettre == saisiePhrase[i])
                    {
                        occurence++;
                    }
                    i++;
                }

                if (occurence == 0)
                {
                    Console.WriteLine(" La lettre n'est pas présente ");
                }
                else
                {
                    Console.WriteLine(" La lettre " + saisieLettre + " est présente " + occurence + " fois ");
                }

            }
        }
    }
}