﻿using System;
using String_Calculator;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            StringCalculator sc = new StringCalculator();

            //e.Write tests to prove your input validates.

            //d.Example input: “1,2,5” -expected result: “8”.
            Console.WriteLine(sc.Add("1,2,5"));
            //Example input: “” -expected result: “0”.
            Console.WriteLine(sc.Add("0"));
            //a. Example: “1\n,2,3” -Result: “6”
            Console.WriteLine(sc.Add("1\n,2,3"));
            //b.Example 2: “1,\n2,4” -Result: “7”
            Console.WriteLine(sc.Add("1\n,2,4"));


        }
    }
}
