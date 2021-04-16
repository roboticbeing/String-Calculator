using System;
using String_Calculator;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Tests test = new Tests();

            //input: “1,2,5” -expected result: “8”.
            test.CommaSplitTest("1,2,5");
            //input: “2,2,2” -expected result: “6”.
            test.CommaSplitTest("2,2,2");
            //input: “” -expected result: “0”.
            test.EmptyStringTest("");
            //input: “1\n,2,3” -Result: “6”
            test.NewLineTest("1\n,2,3");
            //input: “1,\n2,4” -Result: “7”
            test.NewLineTest("1,\n2,4");
            //input: “//;\n1;3;4” - Result: 8
            test.CustomDelimeterTest("//;\n1;3;4");
            //input: “//$\n1$2$3” - Result: 6
            test.CustomDelimeterTest("//$\n1$$2$3");
            //input: “//@\n2@3@8” - Result: 13
            test.CustomDelimeterTest("//@\n2@3@8");
            //input: "//,-1,-2,3,4" - Exception thrown
            test.NegativeNumberTest("//,-1,-2,3,4");
            //input: "2,1001" - Result: 2
            test.IgnoreNumbersGreaterThan1000Test("2,1001");
            //input: "1,2,4000,20" - Result 23
            test.IgnoreNumbersGreaterThan1000Test("1,2,4000,20");
            test.ArbitraryLengthDelimeterTest("//***\n1***2***3");
            test.ArbitraryLengthDelimeterTest("//$5$$5$$$5");
        }
    }
}
