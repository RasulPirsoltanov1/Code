namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double annual = 0;
            double vergi = 0;
            double borc = 0;
            int raiting = 0;
            double istenilen_mebleg = 0;
            Console.WriteLine("Illik gelir: ");
            annual = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kredit reytingi: ");
            raiting = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Cari borc: ");
            borc = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Istenilen mebleg: ");
            istenilen_mebleg = Convert.ToInt32(Console.ReadLine());
            if (annual > 50000 && raiting > 700)
            {
                if (annual > 50000)
                {
                    vergi = istenilen_mebleg * 0.3;
                    borc = istenilen_mebleg + istenilen_mebleg * 0.3;
                }
                Console.WriteLine("Kreditiniz tesdiqlendi.");
            }
            else if (annual > 50000 && raiting < 700)
            {
                Console.WriteLine("Elave mellumatlari lazimdir ");
            }
            else
            {
                if (annual < 20000)
                {
                    vergi = istenilen_mebleg * 0.1;
                    borc = istenilen_mebleg + istenilen_mebleg * 0.1;
                }
                else if (annual > 20000 && annual < 50000)
                {
                    vergi = istenilen_mebleg * 0.2;
                    borc = istenilen_mebleg + istenilen_mebleg * 0.2;
                }
                else
                {
                    vergi = istenilen_mebleg * 0.3;
                    borc = istenilen_mebleg + istenilen_mebleg * 0.3;
                }
                Console.WriteLine("Tesdiqlenmedi!");
            }
            Console.WriteLine("Cari borcunuz : " + borc + "\n\n" + "velave olunan vergi : " + vergi);
        }
    }
}