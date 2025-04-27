namespace for_3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размер цикла: ");
            int N = int.Parse(Console.ReadLine());
            Console.Write("Введите значение цикла:");
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = n; count < N; count++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
