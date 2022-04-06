using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1WebShop
{
    internal static partial class Meni
    {
        public static void UnosNovog()
        {
            Console.WriteLine("\nPritisnite taster A za Admina,taster K za Korisnika,Taster ESC za povratak nazad! ");
            var unos2 = Console.ReadKey();
            Person person = null;
            switch (unos2.Key)
            {
                case ConsoleKey.A:
                    person = new Admin();
                    break;
                case ConsoleKey.K:
                    person = new User();
                    break;
                default:
                    Console.WriteLine("Pogresan unos");
                    break;
            }
            Console.Write("Unesite Ime: ");
            person._name = Console.ReadLine();
            Console.Write("Unesite Prezime: ");
            person._surname = Console.ReadLine();
            Console.Write("Unesite Email: ");
            person._email = Console.ReadLine();
            Console.Write("Unesite Username: ");
            person._username = Console.ReadLine();
            Console.Write("Unesite Sifru: ");
            person._password = Console.ReadLine();
            Console.Write("Unesite Grad: ");
            person._address._city = Console.ReadLine();
            Console.Write("Unesite Postanski kod: ");
            person._address._poBox = Console.ReadLine();
            Console.Write("Unesite Adresu: ");
            person._address._address = Console.ReadLine();
            Console.Write("Unesite Br adrese: ");
            person._address._streetNo = Console.ReadLine();
            if (person is Admin admin)
            {
                Console.WriteLine("Unesite tajni broj: ");
                admin._tajniBroj = int.Parse(Console.ReadLine());
            }
            Persons.Add(person);
        }
        public static void LogIn()
        {
            if (loggedIn is null)
            {
                Console.Write("Unesite username: ");
                string username = Console.ReadLine();
                Console.Write("Unesite sifru: ");
                string pass = Console.ReadLine();

                loggedIn = Persons.Where(p => p._username == username && p._password == pass).FirstOrDefault();
                if (loggedIn is not null)
                {
                    Console.WriteLine("Prijavljeni ste!");
                }
            }
            else
            {
                loggedIn = null;
                Console.WriteLine("Odjavljeni ste");
            }
        }
        public static void Ispis()
        {
            //foreach (Person p in Persons)
            //{
            //    Console.WriteLine($"Ime:{p._name} Prezime:{p._surname} Email: {p._username} Username:{p._username}");
            //}
            Console.WriteLine("Admini:");
            Console.WriteLine("==========");
            Persons.Where(person => person is Admin).ToList().ForEach(p => Console.WriteLine($"Ime:{p._name} Prezime:{p._surname} Email: {p._username} Username:{p._username}"));
            Console.WriteLine("Users:");
            Console.WriteLine("==========");
            Persons.Where(person => person is User).ToList().ForEach(p => Console.WriteLine($"Ime:{p._name} Prezime:{p._surname} Email: {p._username} Username:{p._username}"));
        }
    }
}
