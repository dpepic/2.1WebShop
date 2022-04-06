using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1WebShop
{
    internal static partial class Meni
    {
        public static List<Person> Persons = new();
        public static List<Artikal> Artikals = new();
        public static Person? loggedIn = null;
        public static void IspisiMeni()
        {
            do
            {
                Console.WriteLine("\n----------------------------");
                if (loggedIn is not null)
                {
                    Console.WriteLine($"--- Zdravo {loggedIn._name} ! ---");
                }
                Console.WriteLine("1.Registruj se !");
                if (loggedIn is null)
                {
                    Console.WriteLine("2.Prijavi se !");
                }
                else
                {
                    KorisnickiDeo();
                    Console.WriteLine("2.Odjavi se !");
                }
                Console.WriteLine("3.Izlistaj sve !");
                Console.WriteLine("4.Izadji !");
                Console.WriteLine("----------------------------");

                var unos = Console.ReadKey();
                bool podmeni = false;
                switch (unos.KeyChar)
                {
                    case '1':
                        UnosNovog();
                        break;
                    case '2':
                        LogIn();
                        break;
                    case '3':
                        Ispis();
                        break;
                    case '4':
                        Console.WriteLine("Izlazak ...");
                        break;
                    default:
                        if (loggedIn is Admin)
                        {
                            switch(unos.KeyChar)
                            {
                                case 'a':
                                    Console.WriteLine("Unos ARTIKLA!");
                                    podmeni = true;
                                    break;
                            }
                        } else if (loggedIn is User)
                        {
                            switch (unos.KeyChar)
                            {
                                case 'a':
                                    Console.WriteLine("Na webshop!");
                                    podmeni = true;
                                    break;
                            }
                        } 
                        if (!podmeni)
                            Console.WriteLine("Unos pogresan,pokusajte ponovo!");
                        break;
                }
                if (unos.KeyChar == '4')
                {
                    break;
                }

            } while (true);
        }
        public static void KorisnickiDeo()
        {
            switch(loggedIn)
            {
                case Admin:
                    Console.WriteLine("a -- unos artikla");
                    Console.WriteLine("b -- pregled artikala");
                    break;
                case User:
                    Console.WriteLine("a -- vidi \"web\"shop");
                    break;
            }
        }
        
    }
}
