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
            person.Name = Console.ReadLine();
            Console.Write("Unesite Prezime: ");
            person.Surname = Console.ReadLine();
            Console.Write("Unesite Email: ");
            person.Email = Console.ReadLine();
            Console.Write("Unesite Username: ");
            person.Username = Console.ReadLine();
            Console.Write("Unesite Sifru: ");
            person.Password = Console.ReadLine();
            Console.Write("Unesite Grad: ");
            person.Address.City = Console.ReadLine();
            Console.Write("Unesite Postanski kod: ");
            person.Address.PoBox = Console.ReadLine();
            Console.Write("Unesite Adresu: ");
            person.Address.StreetName = Console.ReadLine();
            Console.Write("Unesite Br adrese: ");
            person.Address.StreetNo = Console.ReadLine();
            if (person is Admin admin)
            {
                Console.WriteLine("Unesite tajni broj: ");
                admin.TajniBroj = int.Parse(Console.ReadLine());
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

                loggedIn = Persons.Where(p => p.Username == username && p.Password == pass).FirstOrDefault();
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
            Persons.Where(person => person is Admin).ToList().ForEach(p => Console.WriteLine($"Ime:{p.Name} Prezime:{p.Surname} Email: {p.Username} Username:{p.Username}"));
            Console.WriteLine("Users:");
            Console.WriteLine("==========");
            Persons.Where(person => person is User).ToList().ForEach(p => Console.WriteLine($"Ime:{p.Name} Prezime:{p.Surname} Email: {p.Username} Username:{p.Username}"));
        }
    }
}
