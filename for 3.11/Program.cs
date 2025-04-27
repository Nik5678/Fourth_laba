namespace for_3._11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double yield = 20.0;
            Console.WriteLine("а) Урожайность по годам:");
            for (int year = 2; year <= 8; year++)
            {
                yield *= 1.02;
                Console.WriteLine($"Год {year}: {yield:F2} ц/га");
            }
            double area = 100.0;

            Console.WriteLine("\nб) Площадь участка по годам:");
            for (int year = 1; year <= 7; year++)
            {
                if (year >= 4)
                    Console.WriteLine($"Год {year}: {area:F2} га");
                area *= 1.05;
            }

            double total = 0;
            double area1 = 100.0;
            double yield1 = 20.0;
            Console.WriteLine("\nв) Общий урожай за первые 6 лет:");
            for (int year = 1; year <= 6; year++)
            {
                total += area1 * yield1;
                area1 *= 1.05;
                yield1 *= 1.02;
            }
            Console.WriteLine($"Суммарный урожай: {total:F2} ц");
        }
    }
}
