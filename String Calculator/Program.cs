using System;
using String_Calculator;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Tests test = new Tests();

            //d.Example input: “1,2,5” -expected result: “8”.
            test.CommaSplitTest();

            ////Example input: “” -expected result: “0”.
           // Console.WriteLine(sc.Add(""));
            
            ////a. Example: “1\n,2,3” -Result: “6”
            //Console.WriteLine(sc.Add("1\n,2,3"));
            ////b.Example 2: “1,\n2,4” -Result: “7”
            //Console.WriteLine(sc.Add("1\n,2,4"));

            //PART 3
            //c.Example: “//;\n1;3;4” - Result: 8
            //Console.WriteLine(sc.Add("//;\n1;3;4"));
            ////i. “//$\n1$2$3” - Result: 6
            //Console.WriteLine(sc.Add("//$\n1$2$3"));
            ////ii. “//@\n2@3@8” - Result: 13
            //Console.WriteLine(sc.Add("//@\n2@3@8"));

            //PART 4
           // Console.WriteLine(sc.Add("//,-1,-2,3,4"));
        }
    }
}
