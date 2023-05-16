namespace palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Programme de detection de palindrome dans une phrase");

            Console.Write(" Entrez une phrase se terminant par un point ");
            string saisiePhrase = Console.ReadLine();


            if (saisiePhrase == ".")
            {
                Console.WriteLine(" La saisie est inexacte, elle est seulement composée d'un point, nouvelle saisie requise ");
            }

            if (saisiePhrase.Length == 0)
            {
                Console.WriteLine(" La saisie est vide ");
            }
            else
            {

                int phraseLongueur = saisiePhrase.Length;
                for (int i = 0; i < phraseLongueur / 2; i++)
                {
                    if (saisiePhrase[i] != saisiePhrase[phraseLongueur - 1 - i])
                    {
                        Console.WriteLine(" La chaîne de caractère n'est pas un palindrome");
                    }
                }
                Console.WriteLine(" La chaîne de caractères est un palindrome ");
            }
        }
    }

}
