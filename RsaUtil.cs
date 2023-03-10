using System;
using System.Numerics;

namespace RSAAlgorithm
{
    public static class RsaUtil
    {
        private const int MinAscii = 32;
        private const int MaxAscii = 126;
        public static bool IsPrime(int n)
        {
            if (n <= 1)
            {
                return false;
            }
            
            for (var i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        public static int GCD(int a, int b)
        {
            while (true)
            {
                if (b == 0) return a;
                var a1 = a;
                a = b;
                b = a1 % b;
            }
        }

        public static BigInteger ConvertTextToNumber(string text)
        {
            var result = new BigInteger();
            
            foreach (var t in text)
            {
                if (t >= MinAscii && t <= MaxAscii)
                {
                    int numOfDigits = 0;
                    BigInteger temp = t;
                    while (temp > 0)
                    {
                        temp /= 10;
                        numOfDigits++;
                    }
                    var multiplier = BigInteger.Pow(10, numOfDigits);
                    result = result * multiplier + t;
                }
                else
                {
                    return -1;
                }
            }
            return result;
        }
        
        public static string ConvertNumberToText(BigInteger number)
        {
            var result = "";
            var text = number.ToString();
            var intHold = 0;
            for (var i = 0; i < text.Length; i++)
            {
                var asciiNumber = intHold != 0 ? intHold : int.Parse(text.Substring(i, 1));
                if (asciiNumber >= MinAscii && asciiNumber <= MaxAscii)
                {
                    result += (char)asciiNumber;
                    intHold = 0;
                }
                else
                {
                    intHold = intHold * 10 + asciiNumber;
                }
            }

            return result;
        }
    }
}