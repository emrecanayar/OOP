namespace Interfaces
{
    public class Defender : IFutboller
    {
        private byte _shotPower;

        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public int TShirtNumber { get; set; }
        public byte ShotPower
        {
            get => _shotPower; set
            {

                if (value > 70) Console.WriteLine("Defans oyuncusunun şut gücü 70 den büyük olamaz");
                else _shotPower = value;
            }
        }
        public byte Aggressiveness { get; set; }
        public bool IsItNational { get; set; }

        public void Defend()
        {
            Console.WriteLine("Top tutuyor.");
        }

        public void PassTheBall()
        {
            Console.WriteLine("Pas verildi.");
        }

        public void TakeAShot()
        {
            Console.WriteLine("Şut çekildi.");
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
