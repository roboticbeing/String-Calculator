﻿using System;
using System.Collections.Generic;
using System.Text;

//Write tests



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
            int sum = 0;

            //b.Empty strings should return 0.
            if (string.IsNullOrEmpty(numbers))
                return 0;

            foreach (var num in nums)
            {
                sum += Int32.Parse(num);
            }

            //c.The return type is an integer.
            return sum;
        }
    }
}


