namespace do_while_2._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int a;
            int count = 0;
            do
            {
                count++;
                a = rnd.Next(1, 10);
                Console.WriteLine(a);
            } while (a != 7);
            Console.WriteLine($"7 сгенерировалась спустя {count} попыток");
        }
    }
}
