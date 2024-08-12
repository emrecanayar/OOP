/*
  Interface Nedir?
 C# dilinde, bir interface, metodlar, özellikler (properties), olaylar (events) ve indeksleyiciler (indexers) gibi üye tanımları içerir, fakat bu üyelerin implementasyonu (uygulanış) içermez. Yani interface, içerdiği üyelerin nasıl işlemesi gerektiğini belirtmez, sadece bunlar olmalıdır der. Bunun yanı sıra, bir sınıf birden fazla interfacei implemente edebilir ve böylelikle C#’ın tek miras yapısının getirdiği kısıtlamaları bir nebze de olsa aşabiliriz.


Özellikleri:
. Bir interface gövdesiz metotlar, özellikler ve eventler içerir.
. interfaceler, sınıflar gibi örneklenemez.
. Bir sınıf birden fazla interfacei implemente edebilir.
. interfaceler birbirlerini kalıtım alabilir.
 
Ne İşe Yarar ve Neden Kullanılır?
Çoklu Miras Benzeri Davranış: C# çoklu mirasa izin vermez, ancak bir sınıf birden fazla interfacei implemente edebilir.

Desen (Pattern) Oluşturma: Belirli bir deseni veya şablonu takip etmeye zorlamak için kullanılır.

Sözleşme Oluşturma: Bir interface, bir tür sözleşmedir ve bu interface'i implemente eden sınıf, bu sözleşmeyi kabul etmiş olur ve interface içindeki tüm üyeleri implemente etmek zorundadır.

Bağımlılıkları Azaltma: Sınıflar arasındaki bağımlılıkları azaltmak ve böylece daha esnek, genişletilebilir ve bakımı kolay kod yazmak için kullanılır.

 
 
 */

using Interfaces;

GoalKeeper goalKeeper = new()
{
    FirstName = "Uğurcan",
    LastName = "Çakır",
    TShirtNumber = 23,
    ShotPower = 80,
    Aggressiveness = 90,
    IsItNational = true,
    Reflex = 90,
    BallControl = 95
};

Console.WriteLine($"Ad Soyad: {goalKeeper.ToString()}\n" +
                  $"Agresiflik: {goalKeeper.Aggressiveness}\n" +
                  $"Forma Numarası: {goalKeeper.TShirtNumber}\n" +
                  $"Milli Mi: {goalKeeper.IsItNational}\n" +
                  $"Refleks: {goalKeeper.Reflex}\n" +
                  $"Sut Gucu: {goalKeeper.ShotPower}");

goalKeeper.PassTheBall();

Console.WriteLine("\n\n\n");

Defender defender = new()
{
    FirstName = "Merih",
    LastName = "Demiral",
    TShirtNumber = 28,
    ShotPower = 70,
    Aggressiveness = 95,
    IsItNational = true
};


Console.WriteLine($"Ad Soyad: {defender.ToString()}\n" +
                  $"Agresiflik: {defender.Aggressiveness}\n" +
                  $"Forma Numarası: {defender.TShirtNumber}\n" +
                  $"Milli Mi: {defender.IsItNational}\n" +
                  $"Sut Gucu: {defender.ShotPower}");

defender.TakeAShot();

