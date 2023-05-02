using System.ComponentModel;

namespace intervalleDeuxNombres
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int saisie;
            int saisie2;         

            Console.WriteLine(" Saisir un nombre entier ");
            saisie = int.Parse(Console.ReadLine());


            Console.WriteLine(" Saisir un second nombre entier ");
            saisie2 = int.Parse(Console.ReadLine());

            Console.WriteLine(" L'intervalle entre A et B se compose de " );

            if (saisie < saisie2)
            {
                for (int i = saisie + 1; i < saisie2; i++)
                {
                    Console.WriteLine(i);                  
                }
            }
            else
            {
                for (int i = saisie - 1; i > saisie2; i--)
                {
                    Console.WriteLine(i);              
                }
            }

        }
    }
}