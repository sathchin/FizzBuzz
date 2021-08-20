using System;
using System.Linq;
using FizzBuzz.Infrastructure;
using fizzbuzz.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzz.Tests
{
    [TestClass]
    public class FizzBuzzServiceTests
    {

        [TestMethod]
        public void PassOneShouldReturnDividedByMessage()
        {
            var fizzBuzzService = new FizzBuzzService();
            var result = fizzBuzzService.Verify("1");
            var expected = string.Format(Constants.DividedBy, "1");
            Assert.AreEqual(expected, result);
        }
        
        [TestMethod]
        public void PassTwentyThreeShouldReturnDividedByMessage()
        {
            var fizzBuzzService = new FizzBuzzService();
            var result = fizzBuzzService.Verify("23");
            var expected = string.Format(Constants.DividedBy, "23");
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void PassAShouldReturnInvalidItem()
        {
            var fizzBuzzService = new FizzBuzzService();
            var result = fizzBuzzService.Verify("A");
            Assert.AreEqual(Constants.InvalidItem, result);
        }

        [TestMethod]
        public void PassThreeShouldReturnFizz()
        {
            var fizzBuzzService = new FizzBuzzService();
            var result = fizzBuzzService.Verify("3");
            Assert.AreEqual(Constants.Fizz,result);
        }

        [TestMethod]
        public void PassFiveShouldReturnBuzz()
        {
            var fizzBuzzService = new FizzBuzzService();
            var result = fizzBuzzService.Verify("5");
            Assert.AreEqual(Constants.Buzz, result);
        }

        [TestMethod]
        public void PassFifteenShouldReturnFizzBuzz()
        {
            var fizzBuzzService = new FizzBuzzService();
            var result = fizzBuzzService.Verify("15");
            Assert.AreEqual(Constants.Fizzbuzz, result);
        }
    }
}
