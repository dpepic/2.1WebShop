using _2._1WebShop;

List<Person> Persons = new();
Persons.Add(new Admin { _name = "john", _surname = "doe", _email = "john@gmail.com", _username = "john", _password = "john" }) ;
Persons.Add(new Admin { _name = "ana", _surname = "muller", _email = "ana@gmail.com", _username = "ana", _password = "ana" });
Person loggedIn = null;
do
{
    Console.WriteLine("\n----------------------------");
    if (loggedIn is not null)
    {
        Console.WriteLine($"--- Zdravo {loggedIn._name} ! ---");
    }
    Console.WriteLine("1.Registruj se !");
    if(loggedIn is null) 
    { 
        Console.WriteLine("2.Prijavi se !");
    }
    else
    {
        Console.WriteLine("2.Odjavi se !");
    }
    Console.WriteLine("3.Izlistaj sve !");
    Console.WriteLine("4.Izadji !");
    Console.WriteLine("----------------------------");

var unos = Console.ReadKey();

    switch (unos.Key)
    {
        case ConsoleKey.D1:
            Console.WriteLine("Pritisnite taster A za Admina,taster K za Korisnika,Taster ESC za povratak nazad! ");
            do
            {
                bool vrati = false;
                var unos2 = Console.ReadKey();
                switch (unos2.Key)
                {
                    case ConsoleKey.A:
                        Admin admin = new();
                        Console.Write("Unesite Ime: ");
                        admin._name = Console.ReadLine();
                        Console.Write("Unesite Prezime: ");
                        admin._surname = Console.ReadLine();
                        Console.Write("Unesite Email: ");
                        admin._email = Console.ReadLine();
                        Console.Write("Unesite Username: ");
                        admin._username = Console.ReadLine();
                        Console.Write("Unesite Sifru: ");
                        admin._password = Console.ReadLine();
                        Console.Write("Unesite Grad: ");
                        admin._address._city = Console.ReadLine();
                        Console.Write("Unesite Postanski kod: ");
                        admin._address._poBox = Console.ReadLine();
                        Console.Write("Unesite Adresu: ");
                        admin._address._address = Console.ReadLine();
                        Console.Write("Unesite Br adrese: ");
                        admin._address._streetNo = Console.ReadLine();
                        Persons.Add(admin);
                        vrati = true;
                        break;
                    case ConsoleKey.K:
                        User user = new();
                        Console.Write("Unesite Ime: ");
                        user._name = Console.ReadLine();
                        Console.Write("Unesite Prezime: ");
                        user._surname = Console.ReadLine();
                        Console.Write("Unesite Email: ");
                        user._email = Console.ReadLine();
                        Console.Write("Unesite Username: ");
                        user._username = Console.ReadLine();
                        Console.Write("Unesite Sifru: ");
                        user._password = Console.ReadLine();
                        Console.Write("Unesite Grad: ");
                        user._address._city = Console.ReadLine();
                        Console.Write("Unesite Postanski kod: ");
                        user._address._poBox = Console.ReadLine();
                        Console.Write("Unesite Adresu: ");
                        user._address._address = Console.ReadLine();
                        Console.Write("Unesite Br adrese: ");
                        user._address._streetNo = Console.ReadLine();
                        Persons.Add(user);
                        vrati = true;
                        break;
                    case ConsoleKey.Escape:
                        break;
                    default: Console.WriteLine("Pogresan unos");
                        break;
                }
                if (unos2.Key == ConsoleKey.Escape)
                {
                    break;
                }
                if (vrati == true)
                {
                    break;
                }
            } while (true);

            break;
        case ConsoleKey.D2:
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
            break;
        case ConsoleKey.D3:
            foreach (Person p in Persons)
            {
                Console.WriteLine($"Ime:{p._name} Prezime:{p._surname} Email: {p._username} Username:{p._username}");
            }
            break;
        case ConsoleKey.D4:
            Console.WriteLine("Izlazak ...");
            break;
        default: Console.WriteLine("Unos pogresan,pokusajte ponovo!");
            break;
    }
    if(unos.Key == ConsoleKey.D4)
    {
        break;
    }

} while (true);