namespace Пример_цикла_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            while (условие_продолжения)
            {
                Console.WriteLine("Это выводится
                в теле цикла while");  
            }
            */

            //Найти сумму чисел от 1 до 5
            int i = 1, sum = 0;
            while (i <= 5)
            {
                sum = sum + i; //или sum += i;
                i++;
            }
            Console.WriteLine("Sum = {0}", sum);
        }
    }
}
