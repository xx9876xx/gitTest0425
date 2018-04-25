using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1;

namespace ConsoleApp1
{
    class Program
    {

        

        static void Main(string[] args)
        {

            Calculator cal= new Calculator();
            int a = cal.add(1,2);
            Console.WriteLine("1+2={0}",a);
            Console.Read();
        }
    }
}
