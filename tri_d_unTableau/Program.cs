using System.Security.Cryptography;

namespace tri_d_unTableau
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] triTab = new int[] { 128, 64, 8, 512, 16, 32, 256 };
            Console.WriteLine(" Programme de tri d'un tableau ");
            Console.WriteLine(" Le Tableau initial, de l'index 0 à 6, comportant dans l'ordre 128, 64, 8, 512, 16, 32, 256, se présentera, après tri, ainsi: ");

            for (int i = 0; i < triTab.Length; i++)
            {
                int indiceMin = i;

                for (int j = i + 1; j < triTab.Length; j++)
                {
                    if (triTab[j] < triTab[indiceMin])
                    {
                        indiceMin = j;
                    }
                }
                if (indiceMin != i)
                {
                    int temp = triTab[i];
                    triTab[i] = triTab[indiceMin];
                    triTab[indiceMin] = temp;
                }
            }
            for (int k = 0; k < triTab.Length; k++)
            {
                Console.WriteLine(triTab[k]);
            }

        }
    }
}