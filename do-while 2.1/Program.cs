namespace do_while_2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число N:");
            double N;
            do
            {
                N = double.Parse(Console.ReadLine());
            } 
            while (N != 0);
        }
    }
}
