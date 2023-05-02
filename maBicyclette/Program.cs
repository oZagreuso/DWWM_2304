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

        string saisie;

        Console.WriteLine(" L'histoire de ma bicyclette ");

        Console.WriteLine(" Répondez, aux questions, par oui ou par non, pour jouer à la novel story ");

        Console.WriteLine(" Fait-il beau aujourd'hui? ");

        saisie = Console.ReadLine();

        if (saisie == "oui")
        {
            Console.WriteLine(" La bicyclette fonctionne-t-elle? ");

            saisie = Console.ReadLine();

            if (saisie == "oui")
            {
                Console.WriteLine(" Je vais faire une balade à bicyclette ");
            }
            else
            {
                Console.WriteLine(" Les réparations peuvent-elles être réalisées immédiatement ");

                saisie = Console.ReadLine();

                if (saisie == "oui")
                {
                    Console.WriteLine(" Je vais faire une balade à bicyclette ");
                }
                else
                {
                    Console.WriteLine(" Je vais aller à l'étang ceuillir des joncs ");
                }
            }
        }
        else if(saisie == "non")
        {
            Console.WriteLine(" Le livre Got est-il chez moi? ");

            saisie = Console.ReadLine();

            if (saisie == "oui")
            {
                Console.WriteLine(" je m'installe dans le fauteuil pour lire le livre de GoT ");
            }
            else
            {
                Console.WriteLine(" Je vais à la bibliothèque chercher le livre de GoT. Le livre est-il encore disponible? ");

                saisie = Console.ReadLine();

                if (saisie == "oui")
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