

int Add(int a, int b)
{
    return a + b;
}

int Subtract(int a, int b)
{
    return a - b;
}

int Multiply(int a, int b)
{
    return a * b;
}

int Divide(int a, int b)
{
    if (b == 0) throw new DivideByZeroException("Division by zero is not allowed.");
    return a / b;
}

int ExecuteOperation(int a, int b, Calculate operation)
{
    return operation(a, b);
}

//// Delegate instance'larını oluşturuyoruz
//Calculate add = Add;
//Calculate subtract = Subtract;
//Calculate multiply = Multiply;
//Calculate divide = Divide;

//// Farklı operasyonları çalıştırmak için delegatları kullanıyoruz
//Console.WriteLine("Addition: " + ExecuteOperation(5, 3, add));
//Console.WriteLine("Subtraction: " + ExecuteOperation(5, 3, subtract));
//Console.WriteLine("Multiplication: " + ExecuteOperation(5, 3, multiply));
//Console.WriteLine("Division: " + ExecuteOperation(6, 3, divide));


Calculate operations = Add;
operations += Subtract;
operations += Multiply;

int result = operations(5, 3);

Console.WriteLine("Result : " + result);

public delegate int Calculate(int x, int y);