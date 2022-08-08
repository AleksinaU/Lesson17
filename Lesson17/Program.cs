using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите числовой номер счета");
            int accountint = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите числовое значение баланса");
            double balanceSheet = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите ФИО");
            string fullName = Console.ReadLine();
            Count<int> count1 = new Count<int>(accountint,balanceSheet,fullName);
            Console.WriteLine(count1.GetInfo());

            Console.WriteLine("Введите строковый номер счета");
            string accountstring = Console.ReadLine();
            Console.WriteLine("Введите числовое значение баланса");
            balanceSheet = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите ФИО");
            fullName = Console.ReadLine();
            Count<string> count2 = new Count<string>(accountstring,balanceSheet,fullName);
            Console.WriteLine(count2.GetInfo());
            Console.ReadKey();
        }   
    }
}
