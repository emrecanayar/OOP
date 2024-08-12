namespace Polymorphism
{
    public class Calculator
    {
        // İki tam sayı toplayan metot
        public int Sum(int number1, int number2)
        {
            return number1 + number2;
        }

        // Üç tam sayı toplayan metot
        public int Sum(int number1, int number2, int number3)
        {
            return number1 + number2 + number3;
        }

        // İki ondalıklı sayı toplayan metot
        public double Sum(double number1, double number2)
        {
            return number1 + number2;
        }
    }
}
