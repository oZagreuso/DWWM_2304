namespace jeuDuPendu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string choixMot;


            Console.WriteLine(" --- Bienvenue sur le jeu du Pendu --- ");

            do
            {
                Console.WriteLine(" --- JOUEUR 1: choisir un mot de 5 caractères minimum --- ");
                choixMot = Console.ReadLine().ToLower();

                if (choixMot.Length < 5)
                {
                    Console.WriteLine(" --- Le mot est trop court, choisir un nouveau mot de 5 caractères minimum --- ");
                }
            }
            while (choixMot.Length < 5);

            bool motOk = false;
            int nombreEssais = 6;

            char[] motSecret = choixMot.ToCharArray();

            Console.Clear();

            for (int i = 1; i < choixMot.Length - 1; i++)
            {
                motSecret[i] = '_';
            }
            motSecret[0] = choixMot[0];
            motSecret[motSecret.Length - 1] = choixMot[choixMot.Length - 1];


            do
            {

                Console.WriteLine(" --- Le mot SECRET est --- ");
                Console.WriteLine();

                foreach (char element in motSecret)
                {
                    Console.Write(element + " ");
                }
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(" --- Il vous reste " + nombreEssais + " essais --- ");

                Console.WriteLine();
                Console.WriteLine(" --- JOUEUR 2: saisir lettre --- ");

                char choixLettre = char.Parse(Console.ReadLine().ToLower());

                bool lettreOk = false;

                for (int i = 1; i < choixMot.Length - 1; i++)
                {
                    if (choixMot[i].CompareTo(choixLettre) == 0)
                    {
                        motSecret[i] = choixLettre;
                        lettreOk = true;
                    }
                }

                if (lettreOk)
                {
                    Console.WriteLine();
                    Console.WriteLine(" --- EUREKA, lettre trouvée --- ");
                    Console.WriteLine();
                }
                else
                {
                    nombreEssais--;
                    Console.WriteLine(" --- YOU LOSE --- ");
                    Console.WriteLine();
                    Console.WriteLine(" --- SAME PLAYER TRY AGAIN --- ");
                    Console.WriteLine();
                    Console.WriteLine(" Il vous reste " + nombreEssais + " essais ");
                }

                for (int i = 1; i < motSecret.Length - 1; i++)
                {
                    motOk = true;

                    if (motSecret[i] == 95)
                    {
                        motOk = false;

                    }
                }
            }
            while (nombreEssais > 0 && !motOk);

            if (motOk)
            {
                Console.WriteLine(" --- YOU WIN ---");
            }
            else if (nombreEssais <= 0)
            {
                Console.WriteLine(" --- GAME OVER ---");
                Console.WriteLine();
               
            }
            Console.WriteLine();
            Console.WriteLine(" --- Le mot SECRET était : " + choixMot + " --- ");
        }
    }
}