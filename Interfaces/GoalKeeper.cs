namespace Interfaces
{
    public class GoalKeeper : IFutboller
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public int TShirtNumber { get; set; }
        public byte ShotPower { get; set; }
        public byte Aggressiveness { get; set; }
        public bool IsItNational { get; set; }
        public int BallControl { get; set; }
        public byte Reflex { get; set; }

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
