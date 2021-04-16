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
        //4. Calling add with a negative number should throw an exception: “Negatives not allowed”.
        //The exception should list the number(s) that caused the exception
        public int Add(string numbers)
        {
            int sum = 0;
            string[] nums;
            List<string> negative_nums = new List<string>();

            //a. The beginning of your string will now contain a small control code that lets you set a custom delimiter.
            //b. Format: “//[delimiter]\n[delimiter separated numbers]”
            if (numbers.StartsWith("//"))
            {
                string delimeter = numbers.Substring(numbers.IndexOf("//") + 2, 1);
                nums = numbers.Split(delimeter);
            }

            else
            {
                //a.The numbers in the string are separated by a comma.
                nums = numbers.Split(',');
            }
           
            try
            {
                foreach (var num in nums)
                {
                    //b.Empty strings should return 0
                    if (string.IsNullOrEmpty(numbers))
                        break;

                    if (!(num == "//") && Int32.Parse(num) > 0)
                    {
                        sum += Int32.Parse(num);
                    }

                    if (!(num == "//") && Int32.Parse(num) < 0)
                    {
                        negative_nums.Add(num);
                    }
                }

                if (negative_nums.Count > 0)
                {
                    throw new Exception();
                }

            }

            catch (Exception)
            {
                Console.WriteLine("Negatives not allowed");
                Console.WriteLine("These are the numbers that caused the exception: ");
                foreach (var num in negative_nums)
                {
                    Console.WriteLine(num);
                }
            }
            //c.The return type is an integer.
            return sum;
        }
    }
}


