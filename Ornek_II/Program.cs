using Ornek_II;

Daire daire = new Daire() { r = 3 };
Daire silindir = new Silindir() { r = 3, h = 10 };
Daire koni = new Koni() { r = 3, h = 10 };

Console.WriteLine(daire.Hesapla());
Console.WriteLine(silindir.Hesapla());
Console.WriteLine(koni.Hesapla());