namespace for_3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размер цикла: ");
            int N = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = 20; count < N; count++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
