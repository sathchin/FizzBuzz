using System;
using System.Collections.Generic;
using FizzBuzz.Infrastructure;

namespace fizzbuzz.Services
{
    public class FizzBuzzService : IFizzBuzzService
    {
        public IEnumerable<string> VerifyValues(string param)
        {
            if (string.IsNullOrEmpty(param)) throw  new NullReferenceException("please supply parameter list");
            
            var values = param.Replace("[", "").Replace("]", "").Split(",");
            var result = new List<string>();

            foreach (var value in values)
            {
                result.AddRange(Verify(value)?.Split(","));
            }

            return result;
        }
    
    public string Verify(string value)
        {
            var isNumber = long.TryParse(value, out long number);
            if (!isNumber)
            {
                return Constants.InvalidItem;
            }
            else if(number % 3 == 0 && number % 5 == 0)
            {
                return Constants.Fizzbuzz;
            }
            else if(number % 5 == 0)
            {
                return Constants.Buzz;
            }
            else if (number % 3 == 0)
            {
                return Constants.Fizz;
            }
            else
            {
                return string.Format(Constants.DividedBy,number);
            }
        }
    }
}
