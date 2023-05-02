using System.ComponentModel;

namespace nombrePremier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nombreATester;
            int diviseur = 1;       

            Console.WriteLine(" Saisir un nombre ");
            nombreATester = int.Parse(Console.ReadLine());

            do
            {              
                diviseur++;
            }
            while (nombreATester % diviseur != 0);             
                
            if (nombreATester == diviseur)
            {
                Console.WriteLine(nombreATester + " est un nombre premier ");
            }
            else
            {
                Console.WriteLine(nombreATester + " n'est pas un nombre premier ");
            }

             
        }
     
    }
}