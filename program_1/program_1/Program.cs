using System;

namespace program_1
{
    class Program
    {

        static void Main(string[] args)
        {
            //Pitagoras();
            //BMI();
            //Kantor();
            //Kontrola();
            Delta();
        }

        static void Pitagoras()
        {
            double a = 3.5;
            double b = 6;

            Console.WriteLine(Math.Sqrt((a * a) + (b * b)));
        }

        static void BMI()
        {
            double weight, height, result;

            Console.WriteLine("Podaj swoją wagę i wzrost:\n Waga:");
            weight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\n Wzrost: ");
            height = Convert.ToDouble(Console.ReadLine());

            result = weight / ((height / 100) * (height / 100));
            Console.WriteLine($"Twój wskaźnik BMI wynosi: {result}");
        }

        static void Kantor()
        {
           const double CHF = 1.12, EUR = 1.08, USD = 3.99, GBP = 1.24;
           double PLN;

           Console.WriteLine("Podaj kwotę do wymiany (PLN): ");
           PLN = Convert.ToDouble(Console.ReadLine());

            double conversion = PLN / USD;

            Console.WriteLine($"Kwota w walucie pośredniej USD: {conversion}");

           Console.WriteLine("Wybierz walutę, na którą chcesz wymienić: \n1.CHF\n2.EUR\n3.GBP");
           int current = Convert.ToInt32(Console.ReadLine());
            
            switch (current)
            {
                case 1:
                    Console.WriteLine($"Kwota w CHF: {conversion * CHF}");
                    break;

                case 2:
                    Console.WriteLine($"Kwota w EUR: {conversion * EUR}");
                    break;

                case 3:
                    Console.WriteLine($"Kwota w GBP: {conversion * GBP}");
                    break;

                default:
                    Console.WriteLine("Nie wybrałeś poprawnej wymany walut.");
                    break;
            }
            
        }

        static void Kontrola()
        {
            int age;

            Console.WriteLine("Podaj swój wiek: ");
            age = Convert.ToInt32(Console.ReadLine());

            if (age >= 18)
            {
                Console.WriteLine("Access granted");

            } else if (age < 18 && age >= 15)
            {
                Console.WriteLine("Do you have parental constent? Y/N");
                string consent = Console.ReadLine().ToUpper();
                
                switch (consent)
                {
                    case "Y":
                        Console.WriteLine("Access granted");
                        break;
                    case "N":
                        Console.WriteLine("Access denied");
                        break;
                    default:
                        Console.WriteLine("Wrong answer");
                        break;
                }
            } else if (age < 15)
            {
                Console.WriteLine("Access denied");
            }
        }

        static void Delta()
        {
            Console.WriteLine("Podaj a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj c: ");
            int c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Math.Sqrt(Math.Pow(b, 2) - (4 * a * c)));
        }
    }
}
