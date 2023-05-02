namespace rechercheDiviseursDeUnNombre
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N;
            int i;

            Console.WriteLine(" Programme de recherche des diviseurs d'un nombre ");
            Console.WriteLine(" Saisir nombre ");
            
            N = int.Parse(Console.ReadLine());
            Console.WriteLine(" Les diviseurs de " + N + " sont ");

            for (i = 2; i < N; i ++)
            {
                if (N % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
