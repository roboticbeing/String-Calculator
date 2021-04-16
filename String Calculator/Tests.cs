using System;
using System.Collections.Generic;
using System.Text;

namespace String_Calculator
{
      //Write tests to prove your input validates.
    class Tests : StringCalculator
    {
        public bool CommaSplitTest(string input)
        {
            int expected_result = 0;
            switch(input)
            {
                case "1,2,5":
                    expected_result = 8;
                    break;
                case "2,2,2":
                    expected_result = 6;
                    break;
            }

            if (Add(input) != expected_result)
            {
                Console.WriteLine("Comma Split Test failed: " + Add(input) + " did not match " + expected_result);
                return false;
            }

            else
            {
                Console.WriteLine("Comma Split Test passed: " + Add(input));
                return true;
            }
        }
    }
}
