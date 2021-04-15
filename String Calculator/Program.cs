using System;
using String_Calculator;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            StringCalculator sc = new StringCalculator();

            //d.Example input: “1,2,5” -expected result: “8”.
            Console.WriteLine(sc.Add("1,2,5"));
        }
    }
}
