using System;
using System.Linq;

namespace UnitTestDemo.Simple
{
    public class SimpleParser
    {
        public int ParseAndSum(string numbers)
        {
            if (numbers.Length == 0)
            {
                return 0;
            }

            var list = numbers.Split(',').ToList();

            int total = 0;
            try
            {
                //total = list.Sum(item => int.Parse(numbers));
                
                foreach (var x in list)
                {
                    total += int.Parse(x);
                }
            }
            catch (Exception)
            {
                throw new InvalidOperationException("Please send a valid list of numbers in a comma delimited format. ");
            }

            return total;
        }
    }
}
