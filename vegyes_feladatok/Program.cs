using System.Threading.Channels;

namespace vegyes_feladatok
{
    internal class Program
    {
        static void feladat1()
        {

            Console.WriteLine("mennyien értékelték a játékot");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("mennyien értékelték a játékot pozitívan");
            int p = int.Parse(Console.ReadLine());

            double positivepercentage = ((double)p / n) * 100;
            int roundedpercentage = (int)Math.Round(positivepercentage);

            string evulation;
            ConsoleColor color;

            if (roundedpercentage > 90)
            {

                evulation = "nagyon pozitiv";
                color = ConsoleColor.Green;
            }
            else if (roundedpercentage >= 75)
            {

                evulation = "pozitiv";
                color = ConsoleColor.Green;

            }
            else if (roundedpercentage >= 55)
            {

                evulation = "többnyire pozitiv";
                color = ConsoleColor.Green;

            }
            else if (roundedpercentage >= 45)
            {

                evulation = "vegyes";
                color = ConsoleColor.Yellow;

            }
            else if (roundedpercentage >= 25)
            {

                evulation = "többnyire negatív";
                color = ConsoleColor.Red;

            }
            else if (roundedpercentage >= 10)
            {

                evulation = "negatív";
                color = ConsoleColor.Red;

            }
            else
            {

                evulation = "nagyon negatív";
                color = ConsoleColor.Red;

            }

                static void feladat2() { }

                static void feladat3() { }

                static void feladat4() { }

                static void Main(string[] args)
            {
                Console.WriteLine("Hello, World!");
                
                feladat1();
            }
        }
    }
}
