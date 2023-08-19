using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestingTask1
{
   public class FizzBuzz
    {

        private static string FIZZ = "FIZZ";
        private static string BUZZ = "BUZZ";
        
        public void Run()
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(checkFizzBuzz(i));
            }
        }

        public static string checkFizzBuzz(int num)
        {
            if (num < 1 || num > 100)
                throw new ArgumentException("The number should be between 1-100 ");

            if ((num % 3 == 0) && (num % 5 == 0))
                return FIZZ + BUZZ;

            if (num % 3 == 0)
                return FIZZ;

            if (num % 5 == 0)
                return BUZZ;

            return num.ToString();
        }
    }
}
