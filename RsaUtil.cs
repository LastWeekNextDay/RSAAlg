using System.Collections.Generic;
using System.Numerics;

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

        public static int Gcd(int a, int b)
        {
            while (true)
            {
                if (b == 0) return a;
                var a1 = a;
                a = b;
                b = a1 % b;
            }
        }

        public static List<BigInteger> ConvertTextToNumbersList(string text)
        {
            var result = new List<BigInteger>();
            foreach (var t in text)
            {
                if (t < Constants.MinAscii || t > Constants.MaxAscii) return null;
                result.Add(t);
            }

            return result;
        }

        public static string ConvertNumbersListToText(List<BigInteger> numbers)
        {
            var result = "";
            foreach (var number in numbers)
            {
                result += (char)number;
            }

            return result;
        }

        public static List<BigInteger> ConvertNumberToNumbersList(BigInteger number)
        {
            var temp = number;
            var numbersList = new List<BigInteger>();
            while (temp != 0)
            {
                numbersList.Add((int)(temp % 256));
                temp /= 256;
            }

            numbersList.Reverse();
            return numbersList;
        }

        public static BigInteger ConvertNumbersListToNumber(List<BigInteger> list)
        {
            var size = list.Count;
            BigInteger result = 0;
            foreach (var number in list)
            {
                result += number * BigInteger.Pow(256, size - 1);
                size--;
            }

            return result;
        }

        public static List<BigInteger> ConvertPublicKeyToPrimeNumbers(int publicKey)
        {
            var list = new List<BigInteger>();
            var p = 2;
            int q;
            while (true)
            {
                if (publicKey % p == 0)
                {
                    q = publicKey / p;
                    break;
                }

                p++;
            }

            list.Add(p);
            list.Add(q);
            return list;
        }

        public static BigInteger EncryptNumber(BigInteger number, int publicKey, int e)
        {
            return BigInteger.ModPow(number, e, publicKey);
        }

        public static BigInteger DecryptNumber(BigInteger number, int publicKey, int privateKey)
        {
            return BigInteger.ModPow(number, privateKey, publicKey);
        }
    }
}