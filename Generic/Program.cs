using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            Count<int> count = new Count<int>();
            Count<string> count1 = new Count<string>();
            count.WriteCountInfo();
            Console.WriteLine(count.ShowCountInfo());
            count1.WriteCountInfo();
            Console.WriteLine(count1.ShowCountInfo());
        }
    }
}
