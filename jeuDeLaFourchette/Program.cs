namespace jeuDeLaFourchette
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nombreMystere;
            int saisie;
            int cadreMin = 0;
            int cadreMax = 100;
            int nombreEssais = 0;

            Console.WriteLine(" Bienvenue sur le jeu de la Fourchette ");

            Random rnd = new Random();
            nombreMystere = rnd.Next(0, 100);


            do
            {
                Console.WriteLine(" Saisir un nombre entre " + cadreMin + " et " + cadreMax);
                saisie = int.Parse(Console.ReadLine());                

                if (nombreMystere < saisie)
                {
                    Console.WriteLine(" Votre choix est supérieur au nombre mystère ");
                    cadreMax = saisie - 1;
                }
                if (nombreMystere > saisie)
                {
                    Console.WriteLine(" Votre choix est inférieur au nombre mystère ");
                    cadreMin = saisie + 1;
                }
                nombreEssais++;
            }
            while (nombreMystere != saisie);

            if (nombreMystere == saisie)
            {
                Console.WriteLine(" Bravo vous avez trouvé en " + nombreEssais + " essais ");
            }
            
        }
    }
}