namespace for_3._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вариант а):");
            for (int i = 10; i <= 25; i++) { Console.WriteLine($"{i} {i}.4"); }

            Console.WriteLine("Вариант б):");
            for (int i = 25; i <= 35; i++) { Console.WriteLine($"{i} {i}.5 {i-1}.8"); }
        }
    }
}
