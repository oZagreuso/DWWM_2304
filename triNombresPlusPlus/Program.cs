using System;
using System.ComponentModel;

internal class Program
{
    private static void Main(string[] args)
    {
        double a;
        double b;
        double c;
        string saisie;

        Console.WriteLine(" Programme de tri de nombres Upgrade ");

        Console.WriteLine(" Veuillez saisir un nombre a ");

        saisie = Console.ReadLine();

        a = int.Parse(saisie);

        Console.WriteLine(" Veuillez saisir un nombre b ");

        saisie = Console.ReadLine();

        b = int.Parse(saisie);

        Console.WriteLine(" Veuillez saisir un nombre c ");

        saisie = Console.ReadLine();

        c = int.Parse(saisie);

        if (a < b)
        {
            if (b < c)
            {
                Console.WriteLine(a + " < " + b + " < " + c);

            }
            else
            {
                if (a < c)
                {
                    Console.WriteLine(a + " < " + c + " < " + b);
                }
                else
                {
                    Console.WriteLine(c + " < " + a + " < " + b);
                }
            }
        }
        else
        {
            if (a < c)
            {
                Console.WriteLine(b + " < " + a + " < " + c);
            }
            else
            {
                if (b < c)
                {
                    Console.WriteLine(b + " < " + c + " < " + a);
                }
                else
                {
                    Console.WriteLine(c + " < " + b + " < " + a);
                }



            }
        }
    }
}