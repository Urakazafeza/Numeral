using System;

namespace Numeral
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string b, o, d, h;
           
            Console.WriteLine("enter the number");
             int numconverter = int.Parse(Console.ReadLine());
            b = Convert.ToString(numconverter, 2);
            Console.Write("the number in binary is: "); Console.WriteLine(b);
            o = Convert.ToString(numconverter, 8);
            Console.Write("the number in octal is: "); Console.WriteLine(o);
            h = Convert.ToString(numconverter, 16);
            Console.Write("the number in hexadecimal is: "); Console.WriteLine(h);           
            d = Convert.ToString(numconverter);
            Console.Write("the number in decimal is: "); Console.WriteLine(d);
        }
    }

}
