namespace while_1._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Число в двоичной СС: ");
            string N = Console.ReadLine();
            int decimalNumber = 0;
            int power = 1;
            int i = N.Length - 1;
            while (i >= 0)
            {
                if (N[i] == '1')
                {
                    decimalNumber += power;
                }
                power *= 2;
                i--;
            }
            Console.WriteLine($"Число в десятичной СС: {decimalNumber}");
        }
    }
}
