namespace rechercheDiviseursDeUnNombre
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            int i;

            Console.WriteLine(" Programme de recherche des diviseurs d'un nombre ");
            Console.WriteLine(" Saisir nombre ");
            
            n = int.Parse(Console.ReadLine());
            Console.WriteLine(" Les diviseurs de " + n + " sont ");

            for (i = 2; i < n; i ++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
