//bir satış firmasında tam zamnlı ve yarı zamanlı iki tip personel çalışmaktadır . Tam zamanlı personelelrin maaşı taban ücret + prim şeklinde hesaplanmaktadır. Prim ise : satış miktarı aylık miktar 5000 den küçük ise %1 , 50000-150000 arasında %2 , 150000 den büyük ise %3 olarak hesaplanmaktadır
//Yarı zamanlı personellerim maaşı çalıştığı saat * saat ücreti olarak hesaplanmaktadır. Yarı zamanlı personellerin primi ise yaptığı aylık toplam satış miktarının %1 olarak hesaplanmaktadır.
//bu firma için gerekli olan uygulamayı OOP kullanarak gerekli teknolojileri kullanarak yazınız.

using Ornek_III;

TamZamanlı tamzamanlı = new TamZamanlı(1000, 100000);
YarıZamanlı yarızamanlı = new YarıZamanlı(1000, 100, 100000);

TamZamanlı tamzamanlı1 = new TamZamanlı(10, 10);
YarıZamanlı yarızamanlı1 = new YarıZamanlı(10, 100, 100000);

Console.WriteLine($"{tamzamanlı.Toplam}");
Console.WriteLine($"{tamzamanlı1.Maas}");
Console.WriteLine($"{yarızamanlı.Toplam}");
Console.WriteLine($"{yarızamanlı1.Maas}");