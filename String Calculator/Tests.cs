using System;
using System.Collections.Generic;
using System.Text;

namespace String_Calculator
{
    //Write tests to prove your input validates.
    class Tests : StringCalculator
    {
        public bool CommaSplitTest()
        {
            int expected_result = 8;

            if (Add("1,2,5") != expected_result)
            {
                Console.WriteLine("Test failed " + Add("1,2,5") + " did not match the expected result.");
                return false;
            }

            else
            {
                Console.WriteLine("Test passed: " + Add("1,2,5"));
                return true;
            }
        }
    }
}
