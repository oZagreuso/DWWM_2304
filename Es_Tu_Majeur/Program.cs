internal class Program
{
    private static void Main(string[] args)
    {
        int A;
        int X;
        string saisie;

        Console.WriteLine(" Bienvenue dans le programme VOTRE retraite ");

        Console.WriteLine(" Veuillez entrer votre âge ");

        saisie = Console.ReadLine();

        A = int.Parse(saisie);

        if (A < 0)
        {
            Console.WriteLine(" L'âge indiqué n'est pas valide ");
        }
        if (A >= 0)
        {
            X = (60 - A);
            Console.WriteLine(" Il vous reste " + X + " années avant la retraite ");
        }


    }
}