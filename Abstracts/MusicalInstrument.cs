namespace Abstracts
{
    public abstract class MusicalInstrument
    {
        public string Brand { get; set; } = string.Empty;

        public string Model { get; set; } = string.Empty;

        public abstract string Play();

        public string GetDescription()
        {
            return $"Marka : {Brand}\nModel: {Model}";
        }
    }
}



/*
Abstract sınıflar soyut sınıflardır ve soyut sınıfların içerisinde hem soyut hem de somut metotlar bulunabilir.

Abstact sınıfların en büyük özelliği, içerisinde abstract olan yada olmayan metodları barındırabilmesidir. Abstract metodlar kalıtım aldığı class ta implement edilmek zorundadır. Bu sebepten ötürü metotların içerisinde bir gövde bulunmamaktadır.

Abstract olarak işaretlenmiş yapılar mutlaka override edilmek zorundadır.

Bazı genel kurallar
Abstract metodlar, private olarak tanımlamalazlar. Çünkü private metodlar, miras alınan classlar tarafından implement edilemezler. Bu sebepten dolayı abstract metodlar protected, public yada internal olarak tanımlanmalıdır.

Abstract metotlar sadece Abstract classlar içerisinde tanımlanabilirler.

Abstract metodlar virtual olarak tanımlamazlar. Çünkü zaten abstract metodlar override edilmek zorundadır.

Abstract metotlar static olarak tanımlanamzlar.

 
 */