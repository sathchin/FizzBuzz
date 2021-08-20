using System.Collections.Generic;

namespace fizzbuzz.Services
{
    public interface IFizzBuzzService
    {
        IEnumerable<string> VerifyValues(string param);
        string Verify(string value);
    }
}