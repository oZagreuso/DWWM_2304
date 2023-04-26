internal class Program
{
    private static void Main(string[] args)
    {
        double R;
        double A;
        double aire;
        string saisie;

        Console.WriteLine("Bienvenue dans le programme de calcul de la surface d'un secteur circulaire");

        Console.WriteLine(" Veuillez indiquer la valeur du rayon R ");

        saisie = Console.ReadLine();

        R = int.Parse(saisie);

        Console.WriteLine(" Veuillez indiquer la valeur de l'angle A ");

        A = int.Parse(saisie);

        aire = (Math.PI * Math.Pow(R, 2) * A )/ 360;

        Console.WriteLine(" Le résulatat pour l'aire du secteur circulaire est de " + aire);

        Console.ReadLine();
    }
}