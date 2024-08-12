namespace Encapsulation.Models
{
    public class Product
    {
        // Ürünün ismi, fiyatı ve miktarını saklamak için özel alanlar(fields)
        private string _name = string.Empty;
        private double _price;
        private int _quantity;
        private double _discountedPrice;
        private double _orginalPrice;


        public string Name
        {

            get { return _name; }
            set { _name = value; }
        }

        public double Price
        {

            get { return _price; }
            set
            {
                if (value > 0) _price = value;
                else throw new Exception("Fiyat 0'dan büyük olmalıdır.");
            }
        }

        public int Quantity
        {

            get
            {
                if (_quantity < 5) Console.WriteLine("Stok azaldı");

                return _quantity;
            }
            set
            {
                if (value > 0) _quantity = value;
                else throw new Exception("Miktar 0'dan büyük olmalıdır.");
            }
        }

        public double OriginalPrice
        {
            get { return _orginalPrice; }
        }

        private void ApplyDiscount()
        {
            // Eğer stok miktarı 5'ten azsa indirim yapılmaz.
            if (_quantity < 5)
            {
                _discountedPrice = _price;  // Az stok durumunda indirim yapılmaz.
            }

            // Eğer stok miktarı 5 veya daha fazla fakat 20'den azsa %5 indirim uygulanır.
            else if (_quantity is >= 5 and < 20)
            {
                _discountedPrice = _price * 0.05; // %5 indirim uygulandı
            }

            // Diğer durumlarda (stok 20 veya daha fazla) %10 indirim uygulanır.
            else
            {
                _discountedPrice = _price * 0.1; // %10 indirim uygulandı
            }
            // Orjinal fiyatı, indirimli fiyat çıkarılarak hesaplanır.

            _orginalPrice = _price - _discountedPrice;
        }

        // Stok miktarını güncelleyen ve ardından indirim uygulayan metod.
        public void SetQuantity(int quantity)
        {
            _quantity = quantity;
            ApplyDiscount();
        }
    }
}


