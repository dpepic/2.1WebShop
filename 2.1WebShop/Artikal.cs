using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1WebShop
{
    internal class Artikal
    {
        public int Id { get; set; }

        public List<Order> Orders { get; set; } = new();


        private string _sifra = string.Empty;
        public string Sifra
        {
            get => _sifra;
            set => _sifra = value;
        }
        public string Naziv { get; set; } = string.Empty;

        public decimal UCena { get; set; }
        
        
        private int _marza;
        public int Marza
        {
            get => _marza;
            set 
            {
                _marza = value;
                _izlaznaCena = UCena * (1 + _marza / 100m);
            }
        }
        /*
        public void PostaviMarzu(int m) //Setter
        {
            _marza = m;
            _izlaznaCena = _uCena * (1 + _marza / 100m);
        }
        public decimal DohvatiMarzu()
        {
            return _marza;
        }
        //public decimal DohvatiMarzu() => _marza; //Getter
        */
       

        private decimal _izlaznaCena;
        public decimal IzlaznaCena
        {
            get => _izlaznaCena;
            
            set
            {
                _izlaznaCena = value;
                _marza = (int)((_izlaznaCena / UCena - 1) * 100);
            }
        }
       /* public void PostaviIzlaznuCenu(decimal c)
        {
            _izlaznaCena = c;
            _marza = (int)((_izlaznaCena / _uCena - 1)*100);
        }
        public decimal DohvatiIzlaznu()
        {
            return _izlaznaCena;
        }*/
        
        
        public int Kolicina { get; set; }
    }
}
