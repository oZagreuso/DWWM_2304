internal class Program
{
    private static void Main(string[] args)
    {
        int a;
        string saisie;

        Console.WriteLine(" Bienvenue dans le programme de comparaison de nombres ");

        Console.WriteLine(" Veuillez renseigner un âge ");

        saisie = Console.ReadLine();

        a = int.Parse(saisie);

        // si l'âge est inférieur à 0

        if (a < 0)
        {
           (" vous n'etes pas encore nee ");
        }

        // si l'âge est inférieur à 18
        else if (a < 18)
        {
           (" vous ete mineur ");
        }

        // dans autres cas soit a>=18

        else
        {
            (" vous ete majeur ");
        }
     

    }
}
}