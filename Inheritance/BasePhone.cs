namespace Inheritance
{
    public class BasePhone
    {
        private string _brand;
        protected string _phoneType;
        protected string _connectionType;

        public BasePhone()
        {
            _phoneType = "Ahizeli Telefon";
        }

        public BasePhone(string brand, string connectionType)
        {
            _brand = brand;
            _connectionType = connectionType;
        }

        public string Brand
        {
            get { return _brand; }
            set { _brand = value; }


        }

        public string PhoneType { get { return _phoneType; } }

        public string ConnectionType { get { return _connectionType; } set { _connectionType = value; } }


        public virtual string Call()
        {
            return "Arama yapılıyor...";
        }

        public virtual string HangUp()
        {
            return "Arama sonlandırıldı.";
        }

        // Virtual methods (sanal metotlar), base class (temel sınıf) içinde bildirilmiş ve derived class (türemiş sınıf) içinde de tekrar bildirilebilen metotlardır. Böylelikle sanal metotlar kullanılarak nesne yönelimli programlama da çok sık başvurulan çok biçimliliği yani poliformizm (polimorphizm) uygulanmış olur. Yani temel sınıfta bir sanal metot bildirildiğinde bu temel sınıftan türeyen sınıflardaki metotlar override edilerek, temel sınıftaki sanal metotu devre dışı bırakabilirler.
        public virtual string ConnectionStatus()
        {
            return "Bağlantı kuruldu.";
        }
    }

}