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
                Console.WriteLine(" JOUEUR 1: choisir un mot de 5 caractères minimum ");
                choixMot = Console.ReadLine();
            }
            while (choixMot.Length < 5);


            bool motOk = false;
            int nombreEssais = 6;

            do
            {
                char[] motSecret = new char[choixMot.Length];

                for (int i = 1; i < choixMot.Length - 1; i++)
                {
                    motSecret[i] = '_';
                }

                motSecret[0] = choixMot[0];
                motSecret[motSecret.Length - 1] = choixMot[choixMot.Length - 1];

                Console.WriteLine(" Le mot a deviner est " + new string(motSecret));
                Console.WriteLine(" Il vous reste " + nombreEssais + " essais ");

                Console.WriteLine(" --- JOUEUR 2: saisir lettre --- ");
                char choixLettre = char.Parse(Console.ReadLine());

                bool lettreOk = false;

                for (int i = 1; i < choixMot.Length - 1; i++)
                {
                    if (motSecret[i] == choixLettre)
                    {
                        motSecret[i] = choixLettre;
                        lettreOk = true;
                    }
                }

                if (!lettreOk)
                {
                    nombreEssais--;
                    Console.WriteLine(" Lettre ne figure pas dans le mot ");
                }

                if (new string(motSecret) == choixMot)
                {
                    motOk = true;
                }
            }
            while (nombreEssais > 0 && !motOk);

            if (motOk)
            {
                Console.WriteLine(" --- YOU WIN ---");
            }
            else
            {
                Console.WriteLine(" --- GAME OVER ---");
                Console.WriteLine(" Le mot mystère était : " + choixMot);
            }
        }
    }
}
