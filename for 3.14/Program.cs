namespace for_3._14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Введите число n (2 <= n <= 10): ");
            int n = int.Parse(Console.ReadLine());
            long sum = 0;
            long factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
                sum += factorial;
            }
            Console.WriteLine($"Сумма факториалов от 1! до {n}! = {sum}");
        }
    }
}
