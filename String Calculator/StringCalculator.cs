using System;
using System.Collections.Generic;
using System.Text;



namespace String_Calculator
{
    class StringCalculator
    {
        //1.Create a simple String calculator with a method: int Add(string numbers)
        //2.Change the Add method to handle new lines in the input format - it already handles new lines.
        //3. 3.Support a custom delimiter
        public int Add(string numbers)
        {
            //a.The numbers in the string are separated by a comma.
            //string[] nums = numbers.Split(',');

            //a. The beginning of your string will now contain a small control code that lets you set a custom delimiter.
            //b. Format: “//[delimiter]\n[delimiter separated numbers]”
            string delimeter = numbers.Substring(numbers.IndexOf("//") + 2, 1);
            string[] nums = numbers.Split(delimeter);
            int sum = 0;

            //b.Empty strings should return 0.
            if (string.IsNullOrEmpty(numbers))
                return 0;

            foreach (var num in nums)
            {
                if(!(num == "//"))
                {
                    sum += Int32.Parse(num);
                }
                
            }

            //c.The return type is an integer.
            return sum;
        }
    }
}


