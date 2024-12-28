using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // برنامه ای بنویسید که عدد از کاریر گرفته اگر زوج بود ؛ ۲ برابر و اگبر فرد بود ؛ان را نصف کند.

            Console.WriteLine("please enter a number:");
            float num = int.Parse(Console.ReadLine());

            if ( num % 2 ==0)
            {
                 num = num * 2;
                Console.WriteLine(num);
            }
            else
            {
                num = (num / 2);
                Console.WriteLine(num);
            }
            

            Console.WriteLine("\t");
            Console.WriteLine("press any kee to exit ...");
            Console.ReadLine();

        }
    }
}
