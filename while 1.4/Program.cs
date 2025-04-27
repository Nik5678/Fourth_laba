namespace while_1._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Число в десятичной СС: ");
            int N = int.Parse(Console.ReadLine());
            double K = 0;
            double K1 = 0;
            string C = " ";
            while (N > 0)
            {
                K = N % 5;
                C = K + C;
                N = N / 5;
            }
            Console.WriteLine($"Число в пятеричной СС: {C}");
        }
    }
}
