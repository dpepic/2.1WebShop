using _2._1WebShop;


Meni.Artikals.Add(new Artikal { Kolicina = 5, Sifra = "001", Naziv = "Nesto", UCena = 50 });

Db db = new();
Meni.Artikals = db.Artikals.ToList();
db.Admins.ToList().ForEach(admin => Meni.Persons.Add(admin));
db.Users.ToList().ForEach(user => Meni.Persons.Add(user));
Meni.IspisiMeni();




