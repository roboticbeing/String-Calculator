using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace String_Calculator
{
    class StringCalculator
    {
        public int Add(string numbers)
        {
            int sum = 0;
            string[] nums;
            List<string> negative_nums = new List<string>();

            //The beginning of your string will now contain a small control code that lets you set a custom delimiter.
            //Format: “//[delimiter]\n[delimiter separated numbers]”
            if (numbers.StartsWith("//"))
            {
                string delimeter = numbers.Substring(numbers.IndexOf("//") + 2, 1);
                //Allow delimeters of arbitrary length with Regex
                nums = Regex.Split(numbers, @"\" + delimeter + "+");
            }

            else
            {
                //The numbers in the string are separated by a comma.
                nums = numbers.Split(',');
            }
           
            try
            {
                foreach (var num in nums)
                {
                    //Empty strings should return 0
                    if (string.IsNullOrEmpty(numbers))
                        break;

                    //Ignore the first split '//' and sum up the rest if they are positive numbers
                    if (!(num == "//") && Int32.Parse(num) > 0)
                    {
                        //Ignore numbers larger than 1000
                        if(Int32.Parse(num) < 1000)
                        sum += Int32.Parse(num);
                    }

                    //Add negative numbers to a list
                    if (!(num == "//") && Int32.Parse(num) < 0)
                    {
                        negative_nums.Add(num);
                    }
                }

                //if there are any negative numbers, throw an exception
                if (negative_nums.Count > 0)
                {
                    throw new Exception();
                }

            }

            catch (Exception)
            {
                Console.WriteLine("Negatives not allowed");
                Console.WriteLine("These are the numbers that caused the exception: ");
                //list the numbers that caused the exception
                foreach (var num in negative_nums)
                {
                    Console.WriteLine(num);
                }
            }
            //The return type is an integer.
            return sum;
        }
    }
}


