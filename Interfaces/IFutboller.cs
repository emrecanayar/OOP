namespace Interfaces
{
    public interface IFutboller
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int TShirtNumber { get; set; }
        public byte ShotPower { get; set; }
        public byte Aggressiveness { get; set; }
        public bool IsItNational { get; set; }

        void TakeAShot();
        void PassTheBall();
        void Defend();
    }
}
