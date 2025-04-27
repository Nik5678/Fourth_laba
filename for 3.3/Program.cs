namespace for_3._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("а)");
            for (int i = 20; i < 36; i++) { Console.WriteLine(i); }

            Console.WriteLine("б)");
            Console.Write("Введите значение b (> 10): ");
            int b = int.Parse(Console.ReadLine());
            for (int i = 11; i < b; i++) { Console.WriteLine(Math.Pow(i, 2)); }

            Console.WriteLine("в)");
            Console.Write("Введите значение a (< 10): ");
            int a = int.Parse(Console.ReadLine());
            for (int i = a; i < 50; i++) { Console.WriteLine(Math.Pow(i, 3)); }

            Console.WriteLine("г)");
            Console.Write("Введите начальное значение a (a>b): ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Введите конечное значение b (a>b): ");
            b = int.Parse(Console.ReadLine());
            for (int i = a; b < i; i--) { Console.WriteLine(i); }
        }
    }
}
