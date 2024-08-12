namespace Abstracts.Examples
{
    public abstract class Animal
    {
        private string _name = string.Empty;
        private int _age;

        protected Animal(string name, int age)
        {
            _name = name;
            _age = age;
        }

        public string Name { get => _name; set => _name = value; }
        public int Age { get => _age; set => _age = value; }

        public abstract void MakeSound();
        public abstract void Eat();

        public void Sleep()
        {
            Console.WriteLine($"{Age} yaşındaki {Name}, uykuya daldı");
        }
    }
}
