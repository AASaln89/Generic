using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    public class Count<T>
    {
        T CountNumber { get; set; }
        double Balance { get; set; }
        string Name { get; set; }
        public void WriteCountInfo()
        {
            Console.WriteLine("Введите номер счета");
            CountNumber = (T)Convert.ChangeType(Console.ReadLine(), typeof(T));
            Console.WriteLine("Введите баланс счета");
            Balance = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите ФИО держателя счета");
            Name = Console.ReadLine();
            Console.WriteLine("Для вывода результата нажмите любую клавищу");
            Console.ReadKey();
        }
        public string ShowCountInfo()
        {
            return $"\"Информация по счету\"\n{CountNumber}\n{Balance}\n{Name}";
        }
    }
}
