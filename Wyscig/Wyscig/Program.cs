using System;
using System.Collections.Generic;

namespace Wyscig
{
    internal class Program
    {
        //  stworzenie listy z zawodnikami

        static List<Competitor> Competitors = new List<Competitor>();

        static public int ID { get; set; }

        //  stworzenie struktury 'competitor' przechowujaca dane o zawodniku

        struct Competitor
        {
            public int id, ranking;
            public string name, surName, nationality, email, sex;
            public byte age;
            public bool experience;
        }

        //  klasa glowna main zwracajaca void

        static void Main(string[] args)
        {
            //  build interfejsu menu

            int choice;

            do
            {

                //  metoda odwolujaca sie do interfejsu uzytkownika

                DisplayMenu();

                //  petla zabezpieczajaca kod/program przed zlym wprowadzeniem danych/zmiennej

                while ((!int.TryParse(Console.ReadLine(), out choice)) || (choice < 0 || choice > 5))
                {
                    Console.WriteLine("Niepoprawny wybór, wprowadź wybór ponownie - tylko cyfry od 0 do 5!");
                }

                // switch wybierajacy opcje z menu i jej callback

                switch (choice)
                {
                    case 1:
                        AddCompetitor();
                        break;

                    case 2:
                        DelCompetitor(1);
                        break;

                    case 3:
                        EditCompetitor(1);
                        break;

                    case 4:
                        DisplayCompetitor(1);
                        break;

                    case 5:
                        DisplayAll();
                        break;

                    default:
                        break;
                }

            } while (choice != 0);
            CloseProgram();
        }

        private static void DisplayMenu()
        {
            Console.Clear();
            Console.WriteLine("Aplikacja wyśćig pokoju menu:\n" +
                "1. Dodawanie zawodnika\n" +
                "2. Usuwanie zawodnika\n" +
                "3. Edytowanie zawodnika\n" +
                "4. Wyświetl zawodnika\n" +
                "5. Wyświetla wszystkich zawodnikó\n" +
                "0. Zamknij program");
        }

        //  klasy handlujace zawodnikow

        static string Credentials(string credentialsToDisplay)
        {
            Console.Clear();
            Console.WriteLine(credentialsToDisplay);
            return Console.ReadLine();
        }

        static void AddCompetitor()
        {
            Competitor newCompetitor = new Competitor();
            newCompetitor.id = ID;
            newCompetitor.name = Credentials("Podaj imię: ");
            newCompetitor.surName = Credentials("Podaj nazwisko: ");
            newCompetitor.nationality = Credentials("Podaj nazwisko: ");
            newCompetitor.age = byte.Parse(Credentials("Podaj wiek: "));
            newCompetitor.email = Credentials("Podaj email: ");
            newCompetitor.sex = Credentials("Podaj płeć(K/M): ").ToUpper();
            newCompetitor.experience = Credentials("Czy jesteś zawodowcem?(T/N): ") ==  "T" ? true : false;
            newCompetitor.ranking = int.Parse(Credentials("Podaj ranking: "));
            Competitors.Add(newCompetitor);
            ID++;
        }

        static void DelCompetitor(int _id)
        {

        }

        static void EditCompetitor(int _id)
        {

        }

        static void DisplayCompetitor(int _id)
        {

        }

        static void DisplayAll()
        {

        }

        static void CloseProgram()
        {

        }
    }
}