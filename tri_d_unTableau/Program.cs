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
            PersonalSort(ref triTab);
            DisplayTab(triTab);
            

        }
        public static void PersonalSort(ref int[] _myTable)
        {

            for (int i = 0; i < _myTable.Length; i++)
            {
                int indiceMin = i;

                for (int j = i + 1; j < _myTable.Length; j++)
                {
                    if (_myTable[j] < _myTable[indiceMin])
                    {
                        indiceMin = j;
                    }
                }

                //   if (indiceMin != i)

                int temp = _myTable[i];
                _myTable[i] = _myTable[indiceMin];
                _myTable[indiceMin] = temp;
                // }
            }
            
        }
        public static void DisplayTab(int[]_myTable)
        {
            Console.WriteLine(" ------ Affichage du Tableau ------ ");
            
            for (int k = 0; k < _myTable.Length; k++)
            {
                Console.Write(_myTable[k] + " ");
            }
            Console.WriteLine(" \n ------FIN------ ");

        }
    }
}