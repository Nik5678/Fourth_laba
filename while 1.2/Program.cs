namespace while_1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первоначальный вклад:");
            double N = double.Parse(Console.ReadLine());
            int count = 0;
            double K;
            while (N < 100000) {
                count++;
                K = N * 0.02;
                N = N + K;
            }
            Console.WriteLine($"Поздравляем, цель достигнута за {count} месяцев!");
        }
    }
}
