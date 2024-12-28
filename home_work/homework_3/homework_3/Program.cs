using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // سه عدد از ورودی گرفته و مثل ماشین حساب ان را یک عدد سه رقمی نشان دهد

            Console.WriteLine("please enter 3 numbers whith one digit!: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());  
            int c = int.Parse(Console.ReadLine());

            int num = ((a*100) + (b * 10 ) + c);
            Console.WriteLine(num);
            Console.WriteLine("\t");
            Console.WriteLine("press any kee to exit ...");
            Console.ReadLine();
        }
    }
}
