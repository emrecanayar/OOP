/*
 
 Inheritance (Kalıtım) Nedir?
Kalıtım (Inheritance), nesne yönelimli programlamada (OOP) bir sınıfın başka bir sınıftan özelliklerini (metotlar, alanlar, özellikler vb.) miras almasını sağlar. Miras alan sınıfa "alt sınıf" veya "türetilen sınıf" denirken, miras veren sınıfa "üst sınıf" veya "temel sınıf" denir.
 
 Kalıtımın Faydaları:

. Kod Yeniden Kullanımı: Bir sınıfın özellikleri, ondan türetilen diğer sınıflar tarafından kullanılabilir. Bu, kod tekrarını önler ve programın genelinde kodun yeniden kullanılmasını sağlar.

. Modülerlik: Programın farklı bölümleri, belirli görevlere veya işlevlere odaklanan sınıflara ayrılır. Bu, kodun okunabilirliğini ve bakımını kolaylaştırır.

. Genelleştirilmiş Sınıflar: Genel işlevlere sahip sınıflar oluşturabilir ve bu sınıfları, özel işlevlere sahip diğer sınıflar için temel olarak kullanabilirsiniz.

Daha Organize ve Anlaşılır Kod: Kalıtım, kodun mantıklı ve organize bir yapıda olmasına yardımcı olur.


Neden Kullanırız?
. Birçok Benzer Özellik Taşıyan Sınıflar Oluşturmak İçin: Eğer birçok sınıf benzer özelliklere veya işlevlere sahipse, bu özellikleri ve işlevleri tek bir temel sınıfta gruplayabilir ve diğer sınıfların bu temel sınıftan türetilmesini sağlayabiliriz.

. Kodun Bakımını Kolaylaştırmak İçin: Kalıtım sayesinde, bir özelliği veya işlevi bir yerde güncellediğinizde bu değişiklik, türetilen tüm sınıflarda otomatik olarak yansır.

. Daha Esnek ve Genişletilebilir Yazılımlar Oluşturmak İçin: Temel sınıfları ve türetilen sınıfları bağımsız olarak genişletebilir veya değiştirebilirsiniz. Bu, yazılımın esnek ve genişletilebilir olmasına yardımcı olur.
 */


using Inheritance;

MobilePhone mobilePhone = new(true, false, "Nokia", "Wireless");
Console.WriteLine(mobilePhone.Call());
Console.WriteLine(mobilePhone.TakePhoto());


SmartPhone smartPhone = new();
Console.WriteLine(smartPhone.ConnectionStatus());
Console.WriteLine(smartPhone.HangUp());



