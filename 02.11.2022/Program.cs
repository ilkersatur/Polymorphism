//Polymorphism(çok şekillik, biçimlilik)
//özel bir durumun çözümüdür --- aynı isimli bir metodun farklı sınıflarda farklı şekilde çalışmsıdır.

using _02._11._2022;
Araba araba = new Araba();
Ferrari Ferrari = new Ferrari();
Serce Serce =   new Serce();
araba.Sur();
Ferrari.Sur();
Serce.Sur();

Console.WriteLine();

Araba araba2 = new Araba();
Araba Ferrari2 = new Ferrari();
Araba Serce2 = new Serce();
araba2.Sur();
Ferrari2.Sur();
Serce2.Sur();