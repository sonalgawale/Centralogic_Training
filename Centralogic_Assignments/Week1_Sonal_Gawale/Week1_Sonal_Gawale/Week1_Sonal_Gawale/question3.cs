internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("----Calculator------");

        Console.WriteLine("Enter First Number : ");
        string num1 = Console.ReadLine();

        Console.WriteLine("Enter Second Number : ");
        string num2 = Console.ReadLine();

        float  number1 = Convert.ToSingle(num1);
        float  number2 = Convert.ToSingle(num2);
        
        //performing Calculator Operations
        Console.WriteLine("Addition = " + +Convert.ToSingle(number1+number2));
        Console.WriteLine("Substraction = "  +Convert.ToSingle(number1 - number2));
        Console.WriteLine("Multiplication = " + Convert.ToSingle(number1 * number2));
        Console.WriteLine("Division = " +Convert.ToSingle(number1 / number2));
        Console.WriteLine("Modulus = " +Convert.ToDouble(number1 % number2));

    }
}