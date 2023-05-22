namespace conversionKilometresMiles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string saisie;
            double valeur;
            bool conditionsSaisieOk = true;        
            double km = 0;
            double miles = 0;
            
            do
            {
                Console.WriteLine(" Programme de conversion de kilomètres en miles ");
                Console.WriteLine(" Saisir une valeur en Km entre 0,01 et 1 000 000 ");
                saisie = Console.ReadLine();
               

                if (saisie == "q")
                {
                    Console.WriteLine(" FIN PROGRAMME ");
                    conditionsSaisieOk = false;

                }
                else 
                for (double i =)
                {

                }

            }
            while (!conditionsSaisieOk);
        }
    }
}