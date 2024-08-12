namespace Polymorphism
{
    public class BasePhone
    {
        public int Id { get; set; }
        public string Brand { get; set; } = string.Empty;
        public string Model { get; set; } = string.Empty;
        public decimal UnitPrice { get; set; }

        public virtual void CallSound()
        {
            Console.WriteLine("Telefon default ses ile çalışıyor.");
        }
    }
}
