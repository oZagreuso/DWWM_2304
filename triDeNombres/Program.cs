internal class Program
{
    private static void Main(string[] args)
    {
        double a;
        double b;
        string saisie;
        
        Console.WriteLine(" Bienvenue sur le programme de tri de nombres ");

        Console.WriteLine(" Veuillez saisir un nombre a ");

        saisie = Console.ReadLine();

       a = int.Parse(saisie);

        Console.WriteLine(" Veuillez saisir un nombre b ");

        saisie = Console.ReadLine();

        b = int.Parse(saisie);
                
        
            if (a < b)
            {
                if (a != b)
                {
                    Console.WriteLine(" Le résultat du tri de nombre est :" + a + " < " + b);
                }
                else
                {
                    Console.WriteLine(" Le résultat du tri de nombre est :" + a + " = " + b);
                }
            }

            else
            {
                if (a != b)
                {
                    Console.WriteLine(" Le résultat du tri de nombre est :" + b + " < " + a);
                }
                else
                {
                    Console.WriteLine(" Le résultat du tri de nombre est :" + b + " = " + a);
                }
            }

            

        
        

    }
}