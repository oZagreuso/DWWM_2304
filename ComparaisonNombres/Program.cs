internal class Program
{
    private static void Main(string[] args)
    {
        int a;
        string saisie;

        Console.WriteLine(" Bienvenue dans le programme qui définit si vous êtes majeur ou pas");

        Console.WriteLine(" Veuillez renseigner un âge ");

        saisie = Console.ReadLine();

        a = int.Parse(saisie);

        // si l'âge est inférieur à 0

        if (a < 0)
        {
            Console.WriteLine(" Vous n'êtes pas encore née ");

        }

        // si l'âge est inférieur à 18
        if (a < 18)
        {
            if (a >= 0)
            {
                Console.WriteLine(" vous êtes mineur ");
            }
        }

        // dans autres cas soit a>=18

        if (a >= 18)
        {
            Console.WriteLine(" vous êtes majeur ");
        }
     

    }
}
