internal class Program
{
    private static void Main(string[] args)
    {
       
        Console.WriteLine("Enter First Number : ");
        string num1 = Console.ReadLine();

        Console.WriteLine("Enter Second Number : ");
        string num2 = Console.ReadLine();

        int n1 = Convert.ToInt32(num1);
        int n2 = Convert.ToInt32(num2);

        //Calculator using Switch Case
        Console.WriteLine("----Calculator------");
        Console.WriteLine("1.Addition");
        Console.WriteLine("2.Substraction");
        Console.WriteLine("3.Multiplication");
        Console.WriteLine("4.Division");
        Console.WriteLine("5.Modulus");
        Console.WriteLine("Select which operstion do you want to perform from the Above Operation list :  ");

        String ch = Console.ReadLine();
        int ch1 = Convert.ToInt32(ch);
        switch (ch1)
        {
            case 1:
                Console.WriteLine("Addition is "+(n1 + n2));
                break;

            case 2:
                Console.WriteLine("Susbstraction is "+(n1 - n2));
                break;

            case 3:
                Console.WriteLine("Multiplication is "+(n1 * n2));
                break;

            case 4:
                float div = n1 % n2;
                Console.WriteLine("Division "+div);
                break;

            case 5:
                float mod = n1 % n2;
                Console.WriteLine("Modulus is "+mod);
                break;

            default:
                Console.WriteLine("Invalid Operation !");
                break;
        }

    }
}