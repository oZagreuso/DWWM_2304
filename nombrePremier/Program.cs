using System.ComponentModel;

namespace nombrePremier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N;
            int i;

            Console.WriteLine(" Saisir un nombre ");
            N = int.Parse(Console.ReadLine());
            Console.WriteLine(N + " est un nombre premier ");

                for (i = 2; i <= N - 1; i++)
                {
                    if (N % i != 0)
                    {
                        Console.WriteLine(i);
                    }

                }
            
        }
     
    }
}