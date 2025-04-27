using static System.Runtime.InteropServices.JavaScript.JSType;

namespace do_while_2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            int count = 0;
            string str;
            bool continueStr = true;
            Console.WriteLine("Вводите числа (для завершения введите end):");
            do
            {
                str = Console.ReadLine();
                if (str.ToLower() == "end")
                {
                    continueStr = false;
                }
                else
                {
                    if (double.TryParse(str, out double number))
                    {
                        sum += number;
                        count++;
                    }
                    else
                    {
                        Console.WriteLine("Ошибка: введите число или 'end' для завершения!");
                    }
                }
            } while (continueStr);
            if (count > 0)
            {
                double average = sum / count;
                Console.WriteLine($"Среднее арифметическое: {average:F2}");
            }
            else
            {
                Console.WriteLine("Не было введено ни одного числа!");
            }
        }
    }

}
