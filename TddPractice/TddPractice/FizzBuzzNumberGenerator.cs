using System.Text;

namespace TddPractice
{
    public static class FizzBuzzNumberGenerator
    {
        public static string GenerateResult(int number)
        {
            var result = new StringBuilder();

            if (IsMultipleOfThree(number)) result.Append("Fizz");
            if (IsMultipleOfFive(number)) result.Append("Buzz");
            if (IsEmpty(result)) result.Append(number);

            return result.ToString();
        }

        private static bool IsEmpty(StringBuilder result)
        {
            return result.ToString()==string.Empty;
        }

        private static bool IsMultipleOfThree(int number)
        {
            return FirstNumberIsMultipleOfSecondNumber(number, 3);
        }

        private static bool IsMultipleOfFive(int number)
        {
            return FirstNumberIsMultipleOfSecondNumber(number, 5);
        }

        private static bool FirstNumberIsMultipleOfSecondNumber(int firstNumber, int secondNumber)
        {
            return firstNumber % secondNumber == 0;
        }

        


    }
}