namespace tpEmpruntAvecCreationTableauAmortissementModeConsole
{
    internal class Program
    {

        public static double CalculMensualite(double tauxInteretAnnuel, double capitalEmprunte, int nombreAnneesRemboursement)
        {
            double tauxMensuel = tauxInteretAnnuel / 12;
            int nombreMois = nombreAnneesRemboursement * 12;

            double q = Math.Pow(1 + tauxMensuel, -nombreMois);
            double mensualite = capitalEmprunte * tauxMensuel / (1 - q);

            return Math.Round(mensualite, 2);
        }
        static void Main(string[] args)
        {
            double tauxInteretAnnuel;
            double capitalEmprunte;
            int nombreAnneesRemboursement;

            Console.WriteLine(" saisir le taux d'interêt annuel ");
            tauxInteretAnnuel = int.Parse(Console.ReadLine());

            Console.WriteLine(" saisir le montant du capital emprunté ");
            capitalEmprunte = int.Parse(Console.ReadLine());

            Console.WriteLine(" saisir le nombre d'années du remboursement ");
            nombreAnneesRemboursement = int.Parse(Console.ReadLine());


            double mensualite = CalculMensualite(tauxInteretAnnuel, capitalEmprunte, nombreAnneesRemboursement);

            Console.WriteLine("La mensualité constante à rembourser est : " + mensualite);
        }
    }
}