using System;
using System.Collections.Generic;
using System.Text;

//Write tests

//c.The return type should be an integer.
//d.Example input: “1,2,5” -expected result: “8”.
//e.Write tests to prove your input validates.


namespace String_Calculator
{
    class StringCalculator
    {
        //1.Create a simple String calculator with a method: int Add(string numbers)
        public int Add(string numbers)
        {
            //a.The numbers in the string are separated by a comma.
            string[] nums = numbers.Split(',');

            //b.Empty strings should return 0.
            if (string.IsNullOrEmpty(numbers))
                return 0;

            return Int32.Parse(numbers);
        }
    }
}


