using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> intList = new List<int> { 1, 2, 3};
            var result = intList.MyWhere(i => i < 3);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
