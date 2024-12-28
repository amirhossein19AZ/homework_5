using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // برنامه ای بنویسید که یک عدد از ورودی گرفته و از یک تا آن عدد را چاپ کند
            Console.WriteLine("pleas enter a number: ");
            int usernum;
            string num;
            num = Console.ReadLine();
            usernum = int.Parse(num);

            int c = 1;
            while( c<= usernum )
            {
                Console.Write(c + "\t");
                c++;
            }
            Console.WriteLine("\t");
            Console.WriteLine("press any kee to exit ...");
            Console.ReadLine();
        }
    }
}
