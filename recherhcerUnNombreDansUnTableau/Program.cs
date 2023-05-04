namespace recherhcerUnNombreDansUnTableau
{
    internal class Program
    {
        static void Main(string[] args)
        {         
            int[] monTableau;
            monTableau = new int[7];
            monTableau[0] = 8;
            monTableau[1] = 16;
            monTableau[2] = 32;
            monTableau[3] = 64;
            monTableau[4] = 128;
            monTableau[5] = 512;

            for (int i = 0; i < monTableau.Length; i++)
            {
                Console.WriteLine(monTableau[i]);
                Console.WriteLine(" saisir un nombre ");
                string saisie = Console.ReadLine();
                
                foreach (int s in monTableau)
                {
                    Console.WriteLine(s);
                }                  
            }
        }
    }
}