namespace for_3._13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int n = 1; n <= 10; n++)
            {
                int square_sum = 0;
                int odd = 1;
                for (int i = 0; i < n; i++)
                {
                    square_sum += odd;
                    odd += 2;
                }
                sum += square_sum;
            }
            Console.WriteLine($"Сумма квадратов чисел от 1 до 10: {sum}");
        }
    }
}
