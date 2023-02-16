namespace Classes
{
    public class MyClass
    {
        //OOP nin en temel birimi class dır. Bizde bu class yapıları içerisinde neler var onlara değiniyor öğreniyor olacağız.

        /*
         Field
        - Nesne içerisinde veri depoladığımız/tuttuğumuz alanladır.
        - Başka bir deyişle class içerisinde yer alan değişkenlerdir.
        - Herhangi bir veri tipinden olabilir.
         
        Bu class üzerindeki örnek field tanımını aşağıda bulabilirsiniz.
         */

        int age;
        string name;


        /*
         Property
        - Nesne içerisinde özellik sağlar.
        - Property esasında bir metotdur. Yani programatik/algoritmik kodlarımızı inşa ettiğimiz bir metot.
        - Diğer metotlardan fiziksel olarak farkı parametre almamakta ve içerisinde get ve set olmak üzere iki adet blok almaktadır. (
                        get => Property içerisinde yer alan verileri okumak için
                        set => Property ye değer atamak için.
        )
        - Property'nin işlevsel açıdan metottan bir farkı yoktur lakin davranışsal olarak nesne üzerinden bir değer okuma ve değer atama işlemleri için kullanılır.
        - Biz yazılımcılar nesnelerimiz içerisindeki field larımıza direkt olarak erişilmesini istemeyiz.
        - Dolayısıyla fieldlar daki verileri kontröllü bir şekilde dışaraya açmak isteriz.
        - İşte böyle bir durumda metotları kullanırız. (İşte bunun için özel olarak C# metot yerine property yapıları geliştirilmiştir.)

        Bu işlemin asıl adı ise Encapsulation (Kapsülleme) dir.
        - Encapsulation, bir nesne içerisindeki dataların (field lardaki verilerin ) dışarıya kontrollü bir şekilde açılması ve kontrollü bir şekilde veri almasıdır.
         
        Property yapısı oluşturabilmek için bir kaç farklı yol vardır.

        Full Property 
        - En sade property yapılanmasıdır.
        - İçerisinde get ve set blokları tanımlanmalıdır.
         */

        #region Full Property
        //Property hangi türden bir field ı temsil ediyorsa o türden olmalıdır.
        //Propertyler temsil ettikleri field'ların isimlerinin başharfi büyük olacak şekilde isimlendirilir.

        //Bu operasyonun adı Encapsulation dır.
        public string Name
        {

            get
            {
                //Property üzerinden değer talep ediliğinde bu blok tetiklenir.
                //Yani değer buradan gönderilir.
                return name;

            }
            set
            {
                //Propertye atılan değer buradan field a yönlendirilir.
                name = value;
            }
        }


        #endregion

        #region Prop Property
        //Bir property her ne kadar encapsulation yapsada temsil ettiği field'da ki dataya hiç müdahale etmeden erişilmesini ve veri atanmasını sağlıyorsa böyle bir durumda kullanılan property imzasıdır.
        //Bizim buradaki amacımız hiç bir şekilde gelen veriyi direkt olarak field a göndermemek gelen veriyi propertyler üzerinden yönetmektir.

        // Kapsülleme yapamdan direkt olarak fiealda atama yöntemi

        //public int Age
        //{
        //    get
        //    {
        //        return age;
        //    }
        //    set { age = value; }
        //}

        //Bu standart prop kullanımı. Run time anında bu property için C# tarafından field oluşturulmaktadır.
        public int Age { get; set; }
        #endregion


        #region Expression-Bodied Property
        //Tanımlanan property'de Lambda Expression kullanmamızı sağlayan söz dizimidir.

        //Dikkat ederseniz readonly olarak oluşturulur.
        public string Gender => "Erkek";

        #endregion
    }

    //Peki Encapsulation kullanırken verileri kontrolerden geçirerek de okuyabiliriz yada yazabiliriz dedik peki bu kontrol mekanızması nasıl işliyor dilerseniz şimdi bir de buna değinelim. Aşağıdaki Banka sınıfını inceleyebiliriz.
    class Banka
    {
        int bakiye;

        public int Bakiye
        {
            get
            {
                //Field dıda okurken yine belirli bir algoritmaya 
                if (bakiye > 0)
                    return bakiye * 10 / 100;
                return 5;
            }
            set
            {
                //Property den gelen değeri bakiye atarken bu şekilde bir if else şartından geçirerek de field ımıza atayabiliriz.
                if (bakiye is > 5 and < 25)
                    bakiye = value;
                else
                    bakiye = value * 5 / 100;
            }
        }
    }

    //Sınıf elemanlarını bir sınıf içerisinde toplayacak olursak aşağıdaki gibi gözükmektedir. (Field,Property,Method,Indexer vs.)
    class ExampleClass
    {
        //Summary şeklinde tanımladığımız yorum satırları , eğer biz bu classtan bir nesne üretirsek orada ürettiğimiz nesne üzerinde açıklamasını göstermeye yarar.


        /// <summary>
        /// Bu bir fileddir. 
        /// </summary>
        int number;

        /// <summary>
        /// Bu bir propertydir.
        /// </summary>
        public int MyProperty { get; set; }
        public void ExampleMethod() { }

        //Bu bir Indexer dir.
        public int this[int a]
        {
            get { return 0; }
        }

        //Nested class dır. Bu class ExampleClass ın elemanı değildir. Dikkat edin..
        class SampleClass
        {

        }
    }
}
