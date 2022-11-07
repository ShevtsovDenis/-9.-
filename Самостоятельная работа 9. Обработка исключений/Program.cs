using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Самостоятельная_работа_9.Обработка_исключений
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вас приветствует калькулятор!");
            try
            {
                Console.Write("Введите целое число. Х=");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите целое число. У=");
                int y = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите код операции:");
                Console.WriteLine("1-сложение");
                Console.WriteLine("2-вычитание");
                Console.WriteLine("3-произведение");
                Console.WriteLine("4-частное");
                Console.Write("Ваш выбор:");
                double z = Convert.ToInt32(Console.ReadLine());
                if (z == 1)
                {
                    int s = x + y;
                    Console.WriteLine("Результат = {0}", s);
                }
                else if (z == 2)
                {
                    int s = x - y;
                    Console.WriteLine("Результат = {0}", s);
                }
                else if (z == 3)
                {
                    int s = x * y;
                    Console.WriteLine("Результат = {0}", s);
                }
                else if (z == 4)
                {
                    double s = (double)x / y;
                    Console.WriteLine("Результат = {0}", s);
                }
                else
                {
                    Console.WriteLine("Нет операции с указанным номером.");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
