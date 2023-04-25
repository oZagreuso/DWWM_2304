internal class Program
{
    private static void Main(string[] args)
    {
        int rayon;        
        double aire;
        double volume;
        string saisie;

        
        Console.WriteLine(" Programme de calcul de l'aire et du volume d'une sphère ");

        Console.WriteLine(" Indiquer la valeur du rayon ");

        saisie = Console.ReadLine();

        rayon = int.Parse(saisie);

        Console.WriteLine(" vous avez saisi " + rayon);

        aire = 4 * Math.PI * Math.Pow(rayon, 2);

        Console.WriteLine(" l'aire de la sphère est de " + aire);

        volume = 4 / 3d * Math.PI * Math.Pow(rayon, 3);

        Console.WriteLine(" le volume de la sphère est de " + volume);

        Console.ReadLine();
               
    }
}
