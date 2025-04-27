namespace while_1._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Число в семеричной СС (цифры от 0 до 7): ");
            string str = Console.ReadLine();
            int decimalNumber = 0;
            int power = 1;
            int index = str.Length - 1;
            while (index >= 0)
            {
                int digit = str[index] - '0';
                decimalNumber += digit * power;
                power *= 7;
                index--;
            }
            Console.Write($"Число в десятичной СС: {decimalNumber}");
        }
    }
}
