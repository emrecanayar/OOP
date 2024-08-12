namespace Abstracts.Examples
{
    public class Carnivorous : Animal
    {
        public Carnivorous(string name, int age) : base(name, age)
        {
        }

        public override void Eat()
        {
            Console.WriteLine($"{Name}, besleniyor!..");
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name}, kükremekte!..");
        }
    }
}
