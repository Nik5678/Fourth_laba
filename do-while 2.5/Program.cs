namespace do_while_2._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число M: ");
            int M = int.Parse(Console.ReadLine());
            int a = 0, b = 1;
            Console.WriteLine("Последовательность Фибоначчи (до первого числа > " + M + "):");
            Console.Write(a + " " + b + " ");
            int next;
            do
            {
                next = a + b;
                Console.Write(next + " ");
                a = b;
                b = next;
            } while (next <= M);
        }
    
    }
}
