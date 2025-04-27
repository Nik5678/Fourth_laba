namespace for_3._12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите натуральное число: ");
            int n = int.Parse(Console.ReadLine());
            if (n < 1)
            {
                Console.WriteLine("Введите число больше 0!");
                return;
            }
            int sum = 0;
            int odd = 1;
            string decomposition = "";
            for (int i = 0; i < n; i++)
            {
                if (i == 0)
                {
                    decomposition += odd;
                }
                else
                {
                    decomposition += " + " + odd;
                }

                sum += odd;
                odd += 2;
            }
            Console.WriteLine($"{n}² = {decomposition} = {sum}");
            Console.WriteLine($"Проверка: {n} × {n} = {n * n}");
        }
    }
}
