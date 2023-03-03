using System;

namespace RSAAlgorithm
{
    public static class RsaUtil
    {
        public static bool IsPrime(int n)
        {
            if (n <= 1)
            {
                return false;
            }

            if (n % 2 == 0)
            {
                return n == 2;
            }

            var l = (long)(Math.Sqrt(n) + 0.5);

            for (var i = 3; i <= l; i += 2)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
        
        public static long ConvertTextToNumber(string text)
        {
            var result = 0L;
            var length = text.Length;

            for (var i = 0; i < length; i++)
            {
                result += (long)(text[i] * Math.Pow(10, length - i - 1));
            }

            return result;
        }
    }
}