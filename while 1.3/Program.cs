namespace while_1._3
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
            while (N > 0) {
                K = N % 2;
                C = K + C;
                N = N / 2;
            }
            Console.WriteLine($"Число в двоичной СС: {C}");
        }
    }
}
