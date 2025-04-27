namespace for_3._15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите n (2 <= n <= 10): ");
            int n = int.Parse(Console.ReadLine());
            double sum = 1.0;
            double factorial = 1.0;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
                sum += 1.0 / factorial;
            }
            Console.WriteLine($"Сумма ряда: {sum:F10}");
        }
    }
}
