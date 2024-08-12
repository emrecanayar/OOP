// Encapsulation : Nesnenin üyelerine yapılan erişimin kontrol altına alınmasına ve bu kontrolün nesnenin kendisi tarafından yapılmasını sağlamaktır. Amaç fiedl'ları private yaparak bu alanlara dışarıdan erişimi önlemek ve get-set metotları ile kontrolü sağlamaktır.

// Arka plan kodlarını gizleme : Oluşturulan class içerisinde kullanıcının işlemlerini daha kolay gerçekleştirmesi için bazı işlemleri birleştirerek (kapsüllenerek) tek işlem gibi gösterilir. Örneğin veritabanına bağlantı işleminde, biz sadece bağlantı değişkeninin Open() metodunu kullanmaktayız. Fakat class içerisinde kullanıcıdan aldığı parametreleri kullanarak bağlantıyı gerçekleştirmek için birçok metot bulunmaktadır. Bu metodları kullanıcıya gösterip bağlantıyı saglayabilmek için bunlari su sekilde birlestirin demek yerine bu islem sinif içerisinde yapilmis ve kullanicinin kolaylikla kullanabilmesi için Open() metodu olusturulmustur.


// Değişkenlere tam erişimi engelleme : Class içerisinde olusturduğumuz global deşiskenlere dışarıdan erişmek için public olarak tanimlama yapmaktayiz. Fakat bazen bu degişkenlerin degerlerini degistirmek istemeyebiliriz. Fakat kullanmamiz da gerekebilir. Bu durumda degiskenimizi kapsüllememiz gerekmektedir. Yani, bu degiskeni private olarak tanimlamak ve bir read-only property ile bu degiskenin yazma iznini ortadan kaldirmamiz gerekmektedir.

using Encapsulation.Models;

Product product = new();
product.Price = 257;
product.Name = "Kalem";
product.Quantity = 3;
var quantity = product.Quantity;

product.SetQuantity(25);
Console.WriteLine($"Ürün Adı      : {product.Name}, " +
                  $"Fiyat         : {product.Price}, " +
                  $"İndirim Fiyat : {product.OriginalPrice}");


