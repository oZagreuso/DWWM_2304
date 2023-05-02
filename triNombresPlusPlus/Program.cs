using System;
using System.ComponentModel;
using System.Security.Cryptography;

internal class Program
{
    private static void Main(string[] args)
    {
        int a;
        int b;
        int c;
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

        if (a == b)
        {
            if (a == c)
            {
                Console.WriteLine(a + " = " + b + " = " + c);
            }
            if (a < c)
            {
                Console.WriteLine(a + " = " + b + " < " + c);
            }
            if (c < a)
            {
                Console.WriteLine(c + " < " + a + " = " + b);
            }
        }
        if  (a < b)
        {
            if (a == c)
            {
                Console.WriteLine(a + " = " + c + " < " + b);
            }
            if (a < c)
            {
                if (b == c)
                {
                    Console.WriteLine(a + " < " + b + " = " + c);
                }
                if (b < c)
                {
                    Console.WriteLine(a + " < " + b + " < " + c);
                }
                if (c < b)
                {
                    Console.WriteLine(a + " < " + c + " < " + b);
                }
                if (c < a)
                {
                    Console.WriteLine(c + " < " + a + " < " + b);
                }
            }
        }
        if (b < a)
        {
            if ( a == c)
            {
                Console.WriteLine(b + " < " + a + " = " + c);
            }
            if  (a < c)
            {
                Console.WriteLine(b + " < " + a + " < " + c);
            }
        }
        if (c < a)
        {
            if ( b == c)
            {
                Console.WriteLine(b + " = " + c + " < " + a);
            }
            if (b < c)
            {
                Console.WriteLine(b + " < " + c + " < " + a);
            }
            if (c < b)
            {
                Console.WriteLine(c + " < " + b + " < " + a);
            }
        }
    }

}

