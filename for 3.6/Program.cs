namespace for_3._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите x: ");
            double x = double.Parse(Console.ReadLine());
            double sum = 0.0;
            double power = x;
            for (int i = 1; i <= 11; i += 2)
            {
                sum += power / i;
                power *= x * x;
            }
            Console.WriteLine($"Сумма ряда: {sum:F6}");
        }
    }
}
