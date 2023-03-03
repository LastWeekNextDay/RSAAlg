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
            
            for (var i = 2; i < n; i++)
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
            
            for (var i = 0; i < text.Length; i++)
            {
                result += (long)(text[i] * Math.Pow(10, text.Length - i - 1));
            }

            return result;
        }
        
        public static string ConvertNumberToText(long number)
        {
            var result = "";
            var text = number.ToString();

            for (var i = 0; i < text.Length; i += 2)
            {
                var temp = text.Substring(i, 2);
                // ReSharper disable once HeapView.BoxingAllocation
                result += (char)int.Parse(temp);
            }

            return result;
        }
    }
}