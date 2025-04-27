namespace for_3._10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double distance = 10.0;
            Console.WriteLine("Пробег по дням:");
            Console.WriteLine($"День 1: {distance:F2} км");
            for (int day = 2; day <= 10; day++)
            {
                distance *= 1.1;
                Console.WriteLine($"День {day}: {distance:F2} км");
            }
            double road = 10.0;
            double day_distance = 10.0;
            for (int day = 2; day <= 7; day++)
            {
                day_distance *= 1.1;
                road += day_distance;
            }
            Console.WriteLine($"Суммарный путь за 7 дней: {road:F2} км");
        }
    }
}
