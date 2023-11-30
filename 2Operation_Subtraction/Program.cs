using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Operation_Subtraction
{
    internal class Program
    {
        public void Subtraction()
        {
            int a = 20, b = 10;
            int c = a - b;
            Console.WriteLine("Subtraction : " + c);
        }
        static void Main(string[] args)
        {
            Program op = new Program();
            op.Subtraction();
            Console.ReadLine(); 
        }
    }
}
