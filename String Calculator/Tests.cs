using System;
using System.Collections.Generic;
using System.Text;

namespace String_Calculator
{
      //Write tests to prove your input validates.
    class Tests : StringCalculator
    {

        public bool IgnoreNumbersGreaterThan1000Test(string input)
        {
            int expected_result = 0;
            switch (input)
            {
                case "2,1001":
                    expected_result = 2;
                    break;
                case "1,2,4000,20":
                    expected_result = 23;
                    break;
            }

            if (Add(input) != expected_result)
            {
                Console.WriteLine("Ignore Numbers Greater Than 1000 Test failed: " + Add(input) + " did not match " + expected_result);
                return false;
            }

            else
            {
                Console.WriteLine("Ignore Numbers Greater Than 1000 Test passed: " + Add(input));
                return true;
            }
        }
        public bool NegativeNumberTest(string input)
        {
            //error handling in Add method, no need for expected results
            Add(input);
            return false;
        }

        public bool CustomDelimeterTest(string input)
        {
            int expected_result = 0;
            switch (input)
            {
                case "//;\n1;3;4":
                    expected_result = 8;
                    break;
                case "//$\n1$2$3":
                    expected_result = 6;
                    break;
                case "//@\n2@3@8":
                    expected_result = 13;
                    break;
            }

            if (Add(input) != expected_result)
            {
                Console.WriteLine("Custom Delimeter Test failed: " + Add(input) + " did not match " + expected_result);
                return false;
            }

            else
            {
                Console.WriteLine("Custome Delimeter Test passed: " + Add(input));
                return true;
            }
        }

        public bool NewLineTest(string input)
        {
            int expected_result = 0;
            switch (input)
            {
                case "1\n,2,3":
                    expected_result = 6;
                    break;
                case "1,\n2,4":
                    expected_result = 7;
                    break;
            }

            if (Add(input) != expected_result)
            {
                Console.WriteLine("New Line Test failed: " + Add(input) + " did not match " + expected_result);
                return false;
            }

            else
            {
                Console.WriteLine("New Line Test passed: " + Add(input));
                return true;
            }
        }

        public bool EmptyStringTest(string input)
        {
            int expected_result = 0;
           
            if (Add(input) != expected_result)
            {
                Console.WriteLine("Empty String Test failed: " + Add(input) + " did not match " + expected_result);
                return false;
            }

            else
            {
                Console.WriteLine("Empty String Test passed: " + Add(input));
                return true;
            }
        }

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
