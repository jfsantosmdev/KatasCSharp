using System;

namespace KatasCSharp.FizzBuzz
{
    public class FizzBuzzKata
    {
        public static string Answer(int i)
        {
            if (i % 3 == 0 && i % 5 == 0)
                return "Fizz Buzz";

            if (i % 3 == 0)
                return "Fizz";

            if (i % 5 == 0)
                return "Buzz";

            return i.ToString();
        }
    }
}
