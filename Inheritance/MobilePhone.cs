namespace Inheritance
{
    public class MobilePhone : BasePhone
    {
        public bool HasCamera { get; set; }
        public bool IsTouched { get; set; }

        public MobilePhone()
        {
            // * işrareti proteced olduğu anlamına gelir. Protected nesnelere sadece miras alan sınıflar üzerinden erişilebilir. Dışarıdan erişime kapalıdır.
            _phoneType = "Mobile Phone";

        }

        // : base() => Miras aldığı sınıf içeriisnde constructor var ise bu şekilde miras alınan sınıf içerisindeki constructor atama yapabiliriz.
        public MobilePhone(bool hasCamera, bool isTouched, string brand, string connectionType) : base(brand, connectionType)
        {
            HasCamera = hasCamera;
            IsTouched = isTouched;
            _phoneType = "Mobile Phone";

            //constructor yerine içeriden atama işlemide yapabiliriz. Aşağıdaki örnekte olduğu gibi.
            //this.Brand = brand;
            //base.ConnectionType = connectionType;
        }

        public string TakePhoto()
        {
            if (HasCamera) return "Fotoğraf çekebilirsiniz.";
            else return "Bu telefonda kamera bulunmamaktadır.";
        }
    }
}
