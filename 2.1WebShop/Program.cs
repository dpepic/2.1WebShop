using _2._1WebShop;

Meni.Persons.Add(new Admin { _address = new Address { _address="asd", _city="qweqwe", _poBox="234", _streetNo="asfg"}, _name = "john", _surname = "doe", _email = "john@gmail.com", _username = "john", _password = "john" }) ;
Meni.Persons.Add(new User { _name = "qwe", _surname = "muller", _email = "ana@gmail.com", _username = "ana", _password = "ana" });
Meni.Persons.Add(new Admin { _name = "ana", _surname = "muller", _email = "ana@gmail.com", _username = "ana", _password = "ana" });
Meni.Persons.Add(new User { _name = "zxc", _surname = "muller", _email = "ana@gmail.com", _username = "ana", _password = "ana" });

Meni.Artikals.Add(new Artikal { Kolicina = 5, Sifra = "001", Naziv = "Nesto", UCena = 50 });

Db db = new();
Meni.Artikals = db.Artikals.ToList();
Meni.IspisiMeni();




