using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Boolean beauTemps;
        Boolean baladeBicyclette;        
        Boolean allerGaragiste;  
        Boolean livreIndisponible;        
        Boolean livreTrouve;

        string saisie1;
        string saisie2;
        string saisie3;
        string saisie4;
        string saisie5;

        Console.WriteLine(" L'histoire de ma bicyclette ");

        Console.WriteLine(" Répondez, aux questions, par oui ou par non, pour jouer à la novel story ");

        Console.WriteLine(" Fait-il beau aujourd'hui? ");

        saisie1 = Console.ReadLine();

        if (saisie1 == "oui")
        {
            Console.WriteLine(" La bicyclette fonctionne-t-elle? ");

            saisie2 = Console.ReadLine();

            if (saisie2 == "oui")
            {
                Console.WriteLine(" Je vais faire une balade à bicyclette ");
            }
            else
            {
                Console.WriteLine(" Les réparations peuvent-elles être réalisées immédiatement ");

                saisie3 = Console.ReadLine();

                if (saisie3 == "oui")
                {
                    Console.WriteLine(" Je vais faire une balade à bicyclette ");
                }
                else
                {
                    Console.WriteLine(" Je vais aller à l'étang ceuillir des joncs ");
                }
            }
        }
        else if(saisie1 == "non")
        {
            Console.WriteLine(" Le livre Got est-il chez moi? ");

            saisie4 = Console.ReadLine();

            if (saisie4 == "oui")
            {
                Console.WriteLine(" je m'installe dans le fauteuil pour lire le livre de GoT ");
            }
            else
            {
                Console.WriteLine(" Je vais à la bibliothèque chercher le livre de GoT. Le livre est-il encore disponible? ");

                saisie5 = Console.ReadLine();

                if (saisie5 == "oui")
                {
                    Console.WriteLine(" Je rentre chez moi avec le livre de Got et je m'installe dans le fauteuil pour le lire ");
                }
                else
                {
                    Console.WriteLine(" je rentre à la maison, avec un roman policier emprunté à la bibliothèque et je m'installe dans le fauteuil pour le lirer ");
                }
            }
        }
        else
        {
            Console.WriteLine(" !!!ERROR SAISIE!!! ");
            // erreur
        }
    }
}