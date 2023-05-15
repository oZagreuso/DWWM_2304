using System;
using System.IO.IsolatedStorage;
using System.Reflection;

namespace denombrerLettreAlphabetDansTableau
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string alphabetTab = "abcdefghijklmnopqrstuvwxyz";                 

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
                    int occurences = 0;
                    for (int j = 0; j < saisieTexte.Length; j++)
                    {
                        if (saisieTexte[j] == alphabetTab[i])
                        {
                            occurences++;
                        }  
                    }
                    Console.WriteLine(" la lettre " + alphabetTab[i] + " présente " + occurences);
                }                
            }

        }
    }
}