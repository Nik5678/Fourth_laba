namespace for_3._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            int count = 10;

            Console.WriteLine($"Введите 10 оценок (2-5):");

            for (int i = 1; i <= count; i++)
            {
                Console.Write($"Оценка {i}: ");
                sum += int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"Средняя оценка: {sum / count:F2}");
        }
    
    }
}
