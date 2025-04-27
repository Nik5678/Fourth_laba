namespace do_while_2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double N;
            Console.WriteLine("Введите число: ");
            do
            {
                N = double.Parse(Console.ReadLine());
            } while (N > 100 || N < 0);
        }
    }
}
