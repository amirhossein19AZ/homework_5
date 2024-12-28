using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // برنامه ای بنویسید نمره کاربر را دخیره کند ؛ اگر بالای ۱۰ بود پاس شود در غیر این صورت حذف شود

            Console.WriteLine("please enter your score: ");
      
            int point = int.Parse(Console.ReadLine());

            if (point >= 10)
            {
                Console.WriteLine("you are pass :)");
            }
            else
            {
                Console.WriteLine("you are not pass! :(");
            }
            Console.WriteLine("\t");
            Console.WriteLine("press any kee to exit ...");
            Console.ReadLine();
        }
    }
}
