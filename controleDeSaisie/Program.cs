internal class Program
{
    private static void Main(string[] args)
    {
        string saisie;

        Console.WriteLine(" Programme de contrôle de saisie ");             
              
        do
        {
            Console.WriteLine(" Veuillez saisir votre prénom ");

            saisie = Console.ReadLine();
        }
        while (saisie.Length < 2);

        Console.WriteLine(" Bonjour " + saisie);
      
    }
}