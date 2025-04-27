namespace Пример_цикла_do_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //do
            //{
            //    Console.WriteLine("Это выводится в теле цикла do while");
            //} while (условие_продолжения);

            //Ввод пароля
            string Pass = "aboba";
            string str;
            do
            {
                Console.Write("Пароль: "); // подсказка
                str = Console.ReadLine();   // ввод текста
                Console.Clear(); // очистка консоли
            } while (str != Pass); // пока не совпадут
            Console.Write("Верно!");
        }
    }
}
