using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1WebShop
{
    internal static partial class Meni
    {
        public static void UnosArtikla()
        {
            Artikal a = new();

            do
            {
                Console.Write("Unesite sifru: ");
                a.Sifra = Console.ReadLine();
                if (Artikals.Where(art => art.Sifra == a.Sifra).Any())
                {
                    Console.WriteLine("Duplikat sifre!");
                } else
                {
                    break;
                }

            } while (true);

            Console.Write("Unesite naziv: ");
            a.Naziv = Console.ReadLine();
            Console.Write("Unesite ulaznu cenu: ");
            a.UCena = decimal.Parse(Console.ReadLine());
            Console.Write("Unesite kolicina: ");
            a.Kolicina = int.Parse(Console.ReadLine());
            Db db = new();
            db.Add(a);
            db.SaveChanges();
            Artikals = db.Artikals.ToList();
        }
        public static void IzlistajArtikle()
            => Artikals.ForEach(a => Console.WriteLine($"{a.Sifra}--{a.Naziv} Ulazna:{a.UCena} Marza:{a.Marza} Izlazna:{a.IzlaznaCena} Kolicina:{a.Kolicina}"));
        /*{
            foreach(Artikal a in Artikals)
            {
                Console.WriteLine($"{a.Sifra}--{a.Naziv} Ulazna:{a.UCena} Marza:{a.Marza} Izlazna:{a.IzlaznaCena} Kolicina:{a.Kolicina}");
            }
        }*/
        public static void PromenaCene()
        {
            Console.WriteLine("Unesite sifru: ");
            string sifra = Console.ReadLine();
            Db db = new();
            var art = db.Artikals.Where(a => a.Sifra == sifra)
                .FirstOrDefault();
            if (art is null)
            {
                Console.WriteLine("Nema ga :/");
                return;
            }
            Console.WriteLine("Menjate marzu ili izlaznu (m/i)?");
            var unos = Console.ReadKey().Key;

            switch(unos)
            {
                case ConsoleKey.M:
                    Console.WriteLine("Unesite marzu: ");
                    art.Marza = int.Parse(Console.ReadLine());
                    break;
                case ConsoleKey.I:
                    Console.WriteLine("Unesite izlaznu: ");
                    art.IzlaznaCena = decimal.Parse(Console.ReadLine());
                    break;
                default:
                    Console.WriteLine("Nista");
                    break;
            }
            db.SaveChanges();
            Artikals = db.Artikals.ToList();
        }
    }
}
