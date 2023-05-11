using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_9._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Задание 3. Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
            Console.Write("Введите число: ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите другое число: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int result = Akkerman(m, n);
            if (result < 0) Console.WriteLine("Введено отрицательное значение");
            else Console.WriteLine(result);

            Console.ReadKey();
        }
        static int Akkerman(int m, int n)
        {
            if (m < 0 || n < 0) return -1;
            else
            {
                if (m == 0) return n + 1;
                else if (n == 0 && m != 0) return Akkerman(m - 1, 1);
                else return Akkerman(m - 1, Akkerman(m, n - 1));
            }
        }
    }
}
