using Abstracts.Examples;


/*
  C# programlama dilinde abstract anahtar kelimesi, bir sınıfın ya da metodun soyut (abstract) olduğunu belirtir. Abstract sınıflar ve metodlar, nesne yönelimli programlama (OOP) konseptlerinin önemli bir parçasıdır ve soyutlamayı destekler.
 
Abstract Sınıf Nedir?
. Tanımlama: abstract anahtar kelimesi ile tanımlanan sınıftır.
. Özellikleri: Kendisinden türetilmek amacıyla oluşturulur ve doğrudan örneklenemez (instantiate).
. Amaç: Genel işlevselliği ve yapıyı tanımlamak ve bu sınıftan türeyen sınıfların bu yapıyı kullanmasını sağlamaktır.

Abstract Metod Nedir?
. Tanımlama: Yine abstract anahtar kelimesi ile tanımlanır ve sadece abstract sınıflar içerisinde bulunabilir.
. Gövdesiz: Abstract metodlar gövdesizdir, yani metodun içeriği olmaz.
. Zorunlu Üst Yazma: Abstract metodlar, türetilen sınıflar tarafından override anahtar kelimesi ile zorunlu olarak uygulanmalıdır.


Neden ve Ne Zaman Kullanılmalı?

. Soyutlamak İçin: Ortak özellik ve işlevselliğe sahip fakat kendi başına bir anlamı olmayan yapıları tanımlamak için.

. Yeniden Kullanılabilirlik: Ortak işlevselliği ve yapıyı bir kez tanımlayıp, bu yapıyı miras alan sınıflarda kullanmak ve böylece kod tekrarını önlemek için.

Genişletilebilirlik: Sistemi genişletirken, abstract sınıf ve metodlar sayesinde yeni işlevselliği ve yapıyı kolayca ekleyebiliriz.
 */



//Guitar guitar = new();
//guitar.Brand = "Yamaha";
//guitar.Model = "C40";
//string gitarSound = guitar.Play();

//BassGuitar bassGuitar = new();
//bassGuitar.Brand = "Yamaha";
//bassGuitar.Model = "C45";

//string bassGuitarSound = bassGuitar.Play();

//Musician musician = new();
//musician.FirstName = "Mehmet";
//musician.LastName = "Yılmaz";
//musician.Instrument = bassGuitar;


//Console.WriteLine($"Gitaristin Adı : {musician.FirstName} \nGitaristin  Soyadı : {musician.LastName} \nÇaldığı Enstrumanın Sesi : {bassGuitarSound}\nÇaldığı Enstruman Markası : {bassGuitar.Brand}");


Carnivorous carnivorous = new(name: "Aslan", age: 5);
Herbivorous herbivorous = new(name: "Zürafa", age: 3);

carnivorous.Eat();
carnivorous.MakeSound();
carnivorous.Sleep();

herbivorous.Eat();
herbivorous.MakeSound();
herbivorous.Sleep();

Console.WriteLine($"Hayvanın Adı : {carnivorous.Name}, Yaşı: {carnivorous.Age} => Etcil Hayvan");
Console.WriteLine($"Hayvanın Adı : {herbivorous.Name}, Yaşı: {herbivorous.Age} => Otçul Hayvan");