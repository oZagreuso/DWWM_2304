internal class Program
{
    private static void Main(string[] args)
    {
        int a;
        int b;
        int temp;
        string saisie;
        string saisie2;

        Console.WriteLine("Bienvenue dans ce programme d'inversion de deux valeurs ");

        Console.WriteLine(" Veuillez renseigner une valeur de A ");

        saisie = Console.ReadLine();
       
        a = int.Parse(saisie);

        Console.WriteLine(" Veuillez renseigner une valeur de B ");

        saisie2 = Console.ReadLine();

        b = int.Parse(saisie2);

        temp = a;
        a = b;
        b = temp;

        Console.WriteLine(" Après permutation la valeur de A est de " + a + " et la valeur de B est de " +b);

    }
}
