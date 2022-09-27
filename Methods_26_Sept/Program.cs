using System.Drawing;

namespace Area_Kalkylator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Miniräknare();
            //Greeting();
            //Greeting("Hugo");
            //CheckFor18();
            //MagicNumbers();
            //TemperaturOmvandling();
            //MagicNumbersT();
            //GetSum(3, 6);

            //string alias = GetName("Aquaman");
            //string hero = "Aquaman";
            //Console.WriteLine($"{alias} is {hero}");

            //Add(3, 5);
            //EvenOrOdd2(41);

            //int a = 13;
            //int b = 37;
            //bool isSame = IsSame(a, b);
            //Console.Write($"{a} och {b} är ");
            //if (!isSame) Console.Write("inte ");
            //Console.WriteLine("lika");

            //ConvertToFahrenheit(0);
            //ConvertToFahrenheit(100);
            //ConvertToFahrenheit(37);
            //ConvertToFahrenheit(-40);
            //ConvertToFahrenheit(40);

            //int area32 = AreaOfSquare(32);
            //int area51 = AreaOfSquare(51); // LOL

            //AreaOfRectangle(13, 37); // Leet
            //AreaOfRectangle(4, 2);

            //OrthogonArea(13, 37);

            //CircleAreaAndCircumference(13);
            //CircleAreaAndCircumference(37);

            //int amount = 3;
            //int sum = DiceThrow(amount);
            //Console.WriteLine($"Summan av {amount} kast blev {sum}");

            int price = 100;
            int vat = 25;
            Console.WriteLine($"Priset är {price}kr och moms är {vat}%, totalt blir det { PriceWithTax(price, vat)} kr");

        }

        static void Miniräknare()
        {
            Console.WriteLine("Ange ett tal 1: ");
            double talEtt = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ange ett tal 2: ");
            double talTvå = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Summan av talen är: {talEtt + talTvå}");
            Console.WriteLine($"Produkten av talen är: {talEtt * talTvå}");
            Console.WriteLine($"Differensen av talen är: {talEtt - talTvå}");
            Console.WriteLine($"Summan av talen är: {talEtt / talTvå}");
        }

        public static void Greeting()
        {
            Console.WriteLine("Hej!");
        }

        public static void Greeting(string name)
        {
            Console.WriteLine("Hej " + name);
        }

        public static void CheckFor18()
        {
            Console.WriteLine("Hur gammal är du: ");
            int ålder = Convert.ToInt32(Console.ReadLine());

            if (ålder < 18)
            {
                Console.WriteLine("Du är yngre än 18");
            }
            else
            {
                Console.WriteLine("Du är äldre än 18");
            }
        }

        public static void MagicNumbers()
        {
            Console.WriteLine("Skriv in din skostorlek: ");
            int skostorlek = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Skriv in ditt födelseår: ");
            int födelseår = Convert.ToInt32(Console.ReadLine());

            int steg1 = födelseår - 6;
            int steg2 = skostorlek * 5;
            int steg3 = steg2 + 50;
            int steg4 = steg3 * 20;
            int steg5 = steg4 + 1016;
            int steg6 = steg5 - steg1;

            Console.WriteLine($"Ditt födelse år minus 6 är {steg1}");
            Console.WriteLine($"Din skostorlek gånger 5 är lika med {steg2}");
            Console.WriteLine($"Plus 50 är lika med {steg3}");
            Console.WriteLine($"Gånger 20 är lika med {steg4}");
            Console.WriteLine($"Plus 1016 är lika med {steg5}");
            Console.WriteLine($"Minus ditt födelseår {steg6}");
            Console.WriteLine($"Din skostorlek och ålder: {steg6}");
        }

        public static void TemperaturOmvandling()
        {
            Console.WriteLine($"Ange temperatur i Celsius: ");
            int celcius = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Fahrenheit: {celcius * 1.8 + 32}");
        }

        public static void MagicNumbersT()
        {
            // Deklarera variabler
            int sum;
            int year;
            // Ta in input
            Console.Write("Skriv in din skostorlek: ");
            int shoe = Convert.ToInt32(Console.ReadLine());
            Console.Write("Skriv in ditt födelseår: ");
            year = Convert.ToInt32(Console.ReadLine());
            // Bearbeta datan
            year = year - 6;
            Console.WriteLine($"Ditt födelseår minus 6 är {year}");
            sum = shoe * 5;
            Console.WriteLine($"Din skostorlek gånger 5 är lika med {sum}");
            sum = sum + 50;
            Console.WriteLine($"Plus 50 är lika med {sum}");
            sum = sum * 20;
            Console.WriteLine($"Gånger 20 är lika med {sum}");
            sum = sum + 1016;
            Console.WriteLine($"Plus 1016 är lika med {sum}");
            sum = sum - year;
            Console.WriteLine($"Minus ditt födelseår ({year}) är {sum}");
            // Presentera det magiska talet
            Console.WriteLine($"Din skostorlek och ålder:{sum}");
            Console.WriteLine();
        }

        public static int GetSum(int a, int b)
        {
            int sum = a + b;
            Console.WriteLine($"Summan är {sum}");
            return sum;
        }

        public static string GetName(string hero)
        {
            if (hero == "Aquaman") return "Arthur Curry";
            else if (hero == "Wolverine") return "James Howlett";
            else if (hero == "Wonderwoman") return "Diana Prince";
            else return "Okänd";
        }

        public static int Add(int a, int b)
        {
            int sum = a + b;
            Console.WriteLine($"The summ is: {sum}");
            return sum;
        }

        public static bool EvenOrOdd2(int number)
        {

            if (number % 2 == 0)
            {
                Console.WriteLine($"Talet {number} är ett jämt tal");
                return true;
            }
            else
            {
                Console.WriteLine($"Talet {number} är inte ett jämt tal");
                return false;
            }
        }

        public static bool IsSame(int a, int b)
        {
            if (a == b)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static double ConvertToFahrenheit(int celcius)
        {
            int faren = (celcius / 5) * 9 + 32;
            Console.WriteLine(faren);
            return faren;
        }

        public static int AreaOfSquare(int side)
        {
            int square = side * side;
            Console.WriteLine($"The are of sides = {side} is {square}");
            return square;
        }

        public static int AreaOfRectangle(int width, int height)
        {
            int reqt = width * height;
            Console.WriteLine($"The are of the rectangle with the width of {width} and height of {height} is {reqt}");
            return reqt;
        }

        public static double OrthogonArea(int width, int height)
        {
            int tri = (width * height) / 2;
            Console.WriteLine($"The are of the triangle with the width of {width} and height of {height} is {tri}");
            return tri;
        }

        public static double CircleAreaAndCircumference(double radius)
        {
            double cirO = 2 * radius * Math.PI;
            double cirA = Math.PI * radius * radius;
            Console.WriteLine($"Omkretsen är {cirO} och arean är {cirA}");
            return cirO;
            return cirA;
        }

        public static int DiceThrow(int amount)
        {
            Random random = new Random();
            int sum = 0;

            for (int i = 0; i < amount; i++)
            {
                int kast = random.Next(1, 7);
                Console.WriteLine(kast);
                sum += kast;                
            }
            return sum;
        }

        public static double PriceWithTax(int price, int vat)
        {
            double tot = price * 1.25;
            return tot;
        }
    }
}
