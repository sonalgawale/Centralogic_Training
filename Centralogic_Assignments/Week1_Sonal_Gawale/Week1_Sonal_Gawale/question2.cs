internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter First Number : ");
        string num1  = Console.ReadLine();
        Console.WriteLine("Enter Second Number : ");
        string num2 = Console.ReadLine();

        int number1 = Convert.ToInt32(num1);
        int number2 = Convert.ToInt32(num2);

        int ans = (number1 + number2);
        Console.WriteLine("Square of Sum of Two Numbers is : " + (ans*ans));

    }
}