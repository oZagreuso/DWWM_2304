namespace palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Programme de detection de palindrome dans une phrase");
            string saisiePhrase = "";
            bool estPalindrome = true;
            bool conditionsPalindromeOk = true;          

            do
            {
                Console.Write(" Entrez une phrase se terminant par un point ");
                saisiePhrase = Console.ReadLine();


                if (saisiePhrase == "")
                {
                    Console.WriteLine(" La saisie est inexacte, le champ est vide, nouvelle saisie requise ");
                   
                    conditionsPalindromeOk = false;
                }              
                else if (saisiePhrase == ".")
                {
                    Console.WriteLine(" La saisie est inexacte, nouvelle saisie requise ");
                    conditionsPalindromeOk = false;
                }
                else if (saisiePhrase[saisiePhrase.Length - 1] != '.') // SI le dernier caractère, du tableau saisiePhrase, n'est pas un point = extraction de caractère (élément dans le cas d'un tableau)
                {
                    conditionsPalindromeOk = false;
                    Console.WriteLine(" La saisie est inexacte, la chaîne de caractères ne se termine pas par un point, nouvelle saisie requise ");
                }
                else
                {
                    conditionsPalindromeOk = true;
                }
            }
            while (!conditionsPalindromeOk);

            for (int i = 0; i < saisiePhrase.Length / 2d; i++)
            {
                if (saisiePhrase[i] != saisiePhrase[saisiePhrase.Length - 2 - i])
                {
                    estPalindrome = false;
                   
                }              

            }
            if (estPalindrome)
            {
                Console.WriteLine(" La chaîne de caractères est un palindrome ");
            }
            else
            {
                Console.WriteLine(" La chaîne de caractères n'est pas un palindrome ");
            }
        }
    }
}


