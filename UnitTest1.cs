using NUnit.Framework;
using System;
using UnitTestingTask1;

namespace FizzBuzzTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void check_FizzBuzz_ReturnsCorrectStrings()
        {
            // Arrange
            int num1 = 3;
            int num2 = 5;
            int num3 = 15;
            int num4 = 77;

            // Act
            string result1 = FizzBuzz.checkFizzBuzz(num1);
            string result2 = FizzBuzz.checkFizzBuzz(num2);
            string result3 = FizzBuzz.checkFizzBuzz(num3);
            string result4 = FizzBuzz.checkFizzBuzz(num4);

            // Assert
            Assert.That(result1, Is.EqualTo("FIZZ"));
            Assert.That(result2, Is.EqualTo("BUZZ"));
            Assert.That(result3, Is.EqualTo("FIZZBUZZ"));
            Assert.That(result4, Is.EqualTo(num4.ToString()));
        }

        [Test]
        public void checkFizzBuzz_ThrowsException_WhenInvalidNumberGiven()
        {
            // Arrange
            int invalidNumber = 300;

            // Act && Assert
            Assert.Throws<ArgumentException>(()=>FizzBuzz.checkFizzBuzz(invalidNumber));
            
        }
    }
}