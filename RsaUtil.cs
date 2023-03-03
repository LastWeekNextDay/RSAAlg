using System;
using System.Linq;

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
    }
}