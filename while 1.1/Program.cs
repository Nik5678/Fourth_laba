namespace while_1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число N: ");
            int N = int.Parse(Console.ReadLine());
            if (N < 0)
            {
                N = -N;
            }

            if (N == 0)
            {
                Console.WriteLine("0");
            }
            else
            {
                int count = 0;
                int temp = N;
                while (temp != 0)
                {
                    temp /= 10;
                    count++;
                }
                int divisor = 1;
                int tempCount = count - 1;
                while (tempCount > 0)
                {
                    divisor *= 10;
                    tempCount--;
                }
                while (divisor > 0)
                {
                    int digit = N / divisor;
                    Console.Write(digit + " ");
                    N %= divisor;
                    divisor /= 10;
                }
                Console.WriteLine();
            }
        }
    }
}
