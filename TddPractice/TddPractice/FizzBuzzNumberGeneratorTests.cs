using NUnit.Framework;

namespace TddPractice
{
    [TestFixture]
    public class FizzBuzzNumberGeneratorTests
    {
        [Test]
        public void GeneratesNumberOne()
        {
            Assert.That(FizzBuzzNumberGenerator.GenerateResult(1), Is.EqualTo("1"));
        }

        [Test]
        public void GeneratesNumberTwo()
        {
            Assert.That(FizzBuzzNumberGenerator.GenerateResult(2),Is.EqualTo("2"));
        }

        [Test]
        public void GeneratesFizzFromNumberThree()
        {
            Assert.That(FizzBuzzNumberGenerator.GenerateResult(3),Is.EqualTo("Fizz"));
        }

        [Test]
        public void GenerateFizzFromNumberSix()
        {
            Assert.That(FizzBuzzNumberGenerator.GenerateResult(6),Is.EqualTo("Fizz"));
        }

        [Test]
        public void GenerateBuzzFromNumberFive()
        {
            Assert.That(FizzBuzzNumberGenerator.GenerateResult(5),Is.EqualTo("Buzz"));
        }

        [Test]
        public void GenerateBuzzFromNumberTen()
        {
            Assert.That(FizzBuzzNumberGenerator.GenerateResult(10),Is.EqualTo("Buzz"));
        }

        [Test]
        public  void GenerateFizzBuzzFromNumberFifteen()
        {
            Assert.That(FizzBuzzNumberGenerator.GenerateResult(15),Is.EqualTo("FizzBuzz"));
        }

        [Test]
        public  void GenerateFizzBuzzFromNumberThirty()
        {
            Assert.That(FizzBuzzNumberGenerator.GenerateResult(30),  Is.EqualTo("FizzBuzz"));
        }
    }
}