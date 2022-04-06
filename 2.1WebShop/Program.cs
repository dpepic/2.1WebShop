using _2._1WebShop;


Artikal a = new Artikal();

a._uCena = 100;
a.PostaviMarzu(20);
a.IzlaznaCena = 1000;

Console.WriteLine(a.IzlaznaCena);


Meni.Persons.Add(new Admin { _address = new Address { _address="asd", _city="qweqwe", _poBox="234", _streetNo="asfg"}, _name = "john", _surname = "doe", _email = "john@gmail.com", _username = "john", _password = "john" }) ;
Meni.Persons.Add(new User { _name = "qwe", _surname = "muller", _email = "ana@gmail.com", _username = "ana", _password = "ana" });
Meni.Persons.Add(new Admin { _name = "ana", _surname = "muller", _email = "ana@gmail.com", _username = "ana", _password = "ana" });
Meni.Persons.Add(new User { _name = "zxc", _surname = "muller", _email = "ana@gmail.com", _username = "ana", _password = "ana" });

Meni.Artikals.Add(new Artikal { _kolicina = 5, _sifra = "001", _naziv = "Nesto", _uCena = 50 });
Meni.IspisiMeni();




