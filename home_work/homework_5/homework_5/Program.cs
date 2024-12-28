using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // یک عدد از ورودی گرفته و مشخص کند ان عدد چند رقمی است

            Console.WriteLine("please enter a number: ");
            int num = int.Parse(Console.ReadLine());
            int i = 1;
            while ((num / 10) > 0)
            {
                num = num / 10;
                i++;
            }
            Console.WriteLine(i);

            Console.WriteLine("\t");
            Console.WriteLine("press any kee to exit ...");
            Console.ReadLine();
        }
    }
}
