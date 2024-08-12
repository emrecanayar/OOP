namespace Abstracts.Examples
{
    public class Herbivorous : Animal
    {
        public Herbivorous(string name, int age) : base(name, age)
        {

        }
        public override void Eat()
        {
            Console.WriteLine($"{Name}, ot yiyor!..");
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name}, homurdanıyor!..");
        }
    }
}
