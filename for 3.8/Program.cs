namespace for_3._8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество предметов: ");
            int count = int.Parse(Console.ReadLine());
            double totalMass = 0;
            Console.WriteLine("Введите массы предметов:");
            for (int i = 1; i <= count; i++)
            {
                Console.Write($"Масса предмета {i}: ");
                double mass = double.Parse(Console.ReadLine());
                totalMass += mass;
            }
            double averageMass = totalMass / count;
            Console.WriteLine($"Средняя масса предметов: {averageMass:F2}");
        }
    }
}
