
/*
 C# dilinde ve genel olarak nesne yönelimli programlama (OOP) konseptlerinde, polimorfizm (polymorphism), nesnelerin daha genel bir tür olarak ele alınabilmesine olanak tanır. Polimorfizm, bir nesnenin farklı tiplerdeki nesneler gibi davranma kabiliyetidir ve genellikle iki türde bulunur: Statik (veya Erken Bağlama) Polimorfizmi ve Dinamik (veya Geç Bağlama) Polimorfizmi.

1. Statik Polimorfizm:
Metot Aşırı Yükleme: Aynı isimde metotların farklı parametreler ile tanımlanmasıdır.
Operatör Aşırı Yükleme: Var olan operatörlerin farklı türler için farklı anlamlar kazandırılmasıdır.
 
2. Dinamik Polimorfizm:
Bu, en yaygın olarak iki yolla gerçekleşir:

Metot Üst Yazma (Override): Temel sınıfta tanımlanan bir metotun, türetilmiş sınıfta yeniden tanımlanmasıdır.
Geç tür dönüşümü: Bir nesnenin, çalışma zamanında (runtime) farklı türdeki bir nesne olarak ele alınmasıdır.
 

Neden ve Ne Zaman Kullanılmalı?

Kodun Yeniden Kullanılabilirliği: Polimorfizm, benzer işlevleri olan metodları yeniden yazmak yerine, bir üst sınıf metodunu çeşitli yollarla yeniden kullanmamızı sağlar.

Daha Temiz ve Okunabilir Kod: Polimorfizm sayesinde, daha genel bir tür üzerinden kod yazabilir ve bu kodun farklı türdeki nesnelerle çalışabilmesini sağlayabiliriz.

Esneklik: Sistemi genişletirken, mevcut kodu değiştirmek yerine yeni sınıflar ekleyebiliriz, bu da uygulamalarımızın esnekliğini ve bakımını kolaylaştırır.

Yüksek Seviyede Soyutlama: Polimorfizm ile daha genel türleri kullanarak kod yazabilir ve detayları gizleyebiliriz. Bu, yüksek seviyede soyutlama olanağı sağlar.
 */


// Dinamik Polimorphism

using Polymorphism;

Nokia nokia = new();
nokia.Brand = "Nokia";
nokia.Model = "3310";
nokia.CallSound();
Console.WriteLine($"Telefon Marka : {nokia.Brand}\nTelefon Model : {nokia.Model}");

Samsung samsung = new();
samsung.Brand = "Samsung";
samsung.Model = "Mini S3";
samsung.CallSound();
Console.WriteLine($"Telefon Marka : {samsung.Brand}\nTelefon Model : {samsung.Model}");

Iphone iphone = new();
iphone.Brand = "Apple";
iphone.Model = "Iphone X";
iphone.CallSound();
Console.WriteLine($"Telefon Marka : {iphone.Brand}\nTelefon Model : {iphone.Model}");


//Statik Polimorphism

//using Polymorphism;

//Calculator calculator = new();

//// İki tam sayı ile topla metodunu çağırır
//int result1 = calculator.Sum(5, 10);
//Console.WriteLine("Sonuç 1: " + result1);

//// Üç tam sayı ile topla metodunu çağırır
//int result2 = calculator.Sum(5, 10, 15);
//Console.WriteLine("Sonuç 2: " + result2);

//// İki ondalıklı sayı ile topla metodunu çağırır
//double result3 = calculator.Sum(5.5, 10.5);
//Console.WriteLine("Sonuç 3: " + result3);