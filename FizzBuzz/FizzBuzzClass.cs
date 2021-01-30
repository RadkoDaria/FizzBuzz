using System;

namespace FizzBuzz
{
    public class FizzBuzzClass
    {
        public  string PrintFizzBuzz()
        {
            var resultFizzBuzz = string.Empty;
            resultFizzBuzz = GetNumbers(resultFizzBuzz);
            return resultFizzBuzz;
        }

        public  string PrintFizzBuzz(int number)
        {
            CanThrowArgumentExceptionWhenNumberNotInRule(number);

            var result = GetFizzBuzzResult(number);

            if (string.IsNullOrEmpty(result))
                result = GetFizzResult(number);
            if (string.IsNullOrEmpty(result))
                result = GetBuzzResult(number);

            return string.IsNullOrEmpty(result) ? number.ToString() : result;
        }

        private string GetFizzBuzzResult(int number)
        {
            string result = null;
            if (IsBuzzFizz(number)) result = "FizzBuzz";
            return result;
        }

        private string GetBuzzResult(int number)
        {
            string result = null;
            if (IsBuzz(number)) result = "Buzz";
            return result;
        }

        private string GetFizzResult(int number)
        {
            string result = null;
            if (IsFizz(number)) result = "Fizz";
            return result;
        }

        private void CanThrowArgumentExceptionWhenNumberNotInRule(int number)
        {
            if (number > 100 || number < 1)
                throw new ArgumentException(
                    string.Format(
                        "entered number is [{0}], which does not meet rule, entered number should be between 1 to 100.", number));
        }

        private string GetNumbers(string resultFizzBuzz)
        {

            for (var i = 1; i <= 100; i++)
            {
                var printNumber = string.Empty;
                if (IsFizz(i)) printNumber += "Fizz";
                if (IsBuzz(i)) printNumber += "Buzz";
                if (IsBuzzFizz(i)) printNumber += "";
                    if (IsNumber(printNumber))
                    printNumber = (i).ToString();
                resultFizzBuzz += " " + printNumber;
            }
            return resultFizzBuzz.Trim();
        }

        private bool IsFizz(int i)
        {
            return i % 3 == 0;
        }

        private bool IsBuzz(int i)
        {
            return i % 5 == 0;
        }

        private bool IsBuzzFizz(int i)
        {
            bool res = false;
            if (IsBuzz(i) && IsFizz(i))
                res = true;
                return res;
        }
        private static bool IsNumber(string printNumber)
        {
            return String.IsNullOrEmpty(printNumber);
        }
    }
}
