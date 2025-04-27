namespace for_3._9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double position = 0;
            bool road = true;
            for (int i = 1; i <= 100; i++)
            {
                double step = 1.0 / i;
                position += road ? step : -step;
                road = !road;
            }
            Console.WriteLine($"После 100 этапов от дома: {Math.Abs(position):F6} км");

            double totalDistance = 0;
            for (int i = 1; i <= 100; i++)
            {
                totalDistance += 1.0 / i;
            }
            Console.WriteLine($"Общий пройденный путь: {totalDistance:F6} км");
        }
    }
}
