namespace jeuDu_0_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Bienvenue dans le jeu du 0 - 2 ");

            int pointsJoueur = 0;
            int pointsOrdinateur = 0;
            int choixJoueur = 0;
            string choix;
            bool stop = false;

            do
            {
                do
                {

                    Console.WriteLine(" Saisir un nombre soit 0 ou 1 ou 2 ");
                    choix = Console.ReadLine();

                } while (int.TryParse(choix, out choixJoueur) == false && choixJoueur >= 3);
                if (choixJoueur < 0)
                {
                    stop = true;
                }  
                if (choixJoueur >= 3)
                {
                    stop = true;
                }
                else
                {
                    Random rnd = new Random();
                    int choixOrdinateur = rnd.Next(0, 2);

                    int difference = Math.Abs(choixJoueur - choixOrdinateur);

                    switch (difference)
                    {
                        case 1:
                            if (choixJoueur > choixOrdinateur)
                            {
                                pointsJoueur++;
                            }
                            else
                            {
                                pointsOrdinateur++;
                            }
                            break;
                        case 2:
                            if (choixJoueur < choixOrdinateur)
                            {
                                pointsJoueur++;
                            }
                            else
                            {
                                pointsOrdinateur++;
                            }
                            break;
                    }
                }
                Console.WriteLine(" SCORE JOUEUR " + pointsJoueur + " SCORE ORDINATEUR " + pointsOrdinateur);

            }
            while (pointsJoueur < 10 && pointsOrdinateur < 10 && stop == false);

            if (pointsJoueur == 10 && pointsOrdinateur < 10)
            {
                Console.Write(" Vous avez gagné ");

            }
            else if (pointsOrdinateur == 10 && pointsJoueur < 10)
            {
                Console.Write(" --- GAME OVER --- ");
            }
            else
            {
                Console.WriteLine(" --- THE END --- ");
                Console.WriteLine(" SCORE JOUEUR " + pointsJoueur + " SCORE ORDINATEUR " + pointsOrdinateur);
            }
        }
    }
}

