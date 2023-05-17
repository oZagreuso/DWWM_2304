using System;
using System.IO.IsolatedStorage;
using System.Reflection;

namespace denombrerLettreAlphabetDansTableau
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string alphabet2 = "";
            for (char i = 'a'; i <= 'z'; i++) // autre façon de faire le tableau alhabet
            {
                alphabet2 += i;
               
            }
            Console.WriteLine(alphabet2);

            string alphabetTab = "abcdefghijklmnopqrstuvwxyz";

            int[] occurencesAlphaLettres = new int[26];



            Console.WriteLine(" Programme pour dénombrer le nombre d'occurences de lettres de l'alphabet dans un texte ");

            Console.WriteLine(" Entrez un texte de 120 carractères minimum ");
            string saisieTexte = Console.ReadLine();

            while (saisieTexte.Length < 120)
            {
                Console.WriteLine(" Texte trop court, veuillez entrer un autre texte ");
                saisieTexte = Console.ReadLine();
            }
            if (saisieTexte.Length >= 120)
            {
                for (int i = 0; i < alphabetTab.Length; i++)
                {
                    //int occurences = 0;
                    for (int j = 0; j < saisieTexte.Length; j++)
                    {
                        if (saisieTexte[j].Equals(alphabetTab[i]))
                        {
                            occurencesAlphaLettres[i]++;
                            //  occurences++;
                        }
                    }
                 
                }
                for (int i = 0; i < alphabetTab.Length; i++)
                {
                    if (occurencesAlphaLettres[i] != 0)
                    {
                        Console.WriteLine(" La lettre " + alphabetTab[i] + " est présente :" + occurencesAlphaLettres[i] + " fois dans la phrase saisie ");
                    }

                }

                

            }

        }
    }
}