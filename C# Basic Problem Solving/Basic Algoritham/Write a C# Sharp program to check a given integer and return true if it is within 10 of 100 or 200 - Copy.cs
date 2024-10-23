using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Basic_Problem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CheckNumber(103));
            Console.ReadLine();
        }
        static bool CheckNumber(int number)
        {
            if (Math.Abs(number - 100) <= 10 || Math.Abs(number - 200) <= 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}