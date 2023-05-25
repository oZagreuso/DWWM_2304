namespace tpEmpruntAvecCreationTableauAmortissementModeConsole
{
    internal class Program
    {

        public static double CalculMensualite(double tauxInteretAnnuel, double capitalEmprunte, int nombreAnneesRemboursement)
        {
            double tauxMensuel = tauxInteretAnnuel / 1200;
            int nombreMois = nombreAnneesRemboursement * 12;

            double q = Math.Pow(1 + tauxMensuel, -nombreMois);
            double mensualite =( capitalEmprunte * tauxMensuel) / (1 - q);

            return Math.Round(mensualite, 2);
        }
        static void Main(string[] args)
        {
            double tauxInteretAnnuel;
            double capitalEmprunte;
            int nombreAnneesRemboursement;
            bool verifNombre;
            do
            {
                Console.WriteLine(" saisir le taux d'interêt annuel ");
                 verifNombre = double.TryParse(Console.ReadLine(),out tauxInteretAnnuel);

            } while (!verifNombre);
          

            Console.WriteLine(" saisir le montant du capital emprunté ");
            capitalEmprunte = double.Parse(Console.ReadLine());

            Console.WriteLine(" saisir le nombre d'années du remboursement ");
            nombreAnneesRemboursement = int.Parse(Console.ReadLine());


            double mensualite = CalculMensualite(tauxInteretAnnuel, capitalEmprunte, nombreAnneesRemboursement);

            Console.WriteLine("La mensualité constante à rembourser est : " + mensualite+ " euros ");
        }
    }
}