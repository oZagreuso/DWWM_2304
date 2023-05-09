using System;

namespace recherhcerUnNombreDansUnTableau
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] monTableau;
            int saisie;
            monTableau = new int[7];
            monTableau[0] = 8;
            monTableau[1] = 16;
            monTableau[2] = 32;
            monTableau[3] = 64;
            monTableau[4] = 128;
            monTableau[5] = 256;
            monTableau[6] = 512;

           
            for (int i = 0; i < monTableau.Length; i++)
            {
                Console.WriteLine(" Saisir un nombre ");
                saisie = int.Parse(Console.ReadLine());

                if (saisie == monTableau[i])
                {
                    Console.WriteLine(" La valeur de l'indice est " + i);
                }
                else
                {
                    Console.WriteLine(" Nombre non trouvé ");
                }
            }
        }
    }
}
    

    
