using System;
using System.Numerics;

namespace RSAAlgorithm
{
    public class Rsa
    {
        private int _p;

        private int P
        {
            get => _p;
            set => _p = RsaUtil.IsPrime(value)
                ? // P must be a prime number 
                value
                : throw new ArgumentException("P must be a prime number");
        }

        private int _q;

        private int Q
        {
            get => _q;
            set => _q = RsaUtil.IsPrime(value)
                ? // Q must be a prime number
                value
                : throw new ArgumentException("Q must be a prime number");
        }

        private int FactorN { get; set; }

        private int E { get; set; }

        public int PublicKey { get; set; }

        private int PrivateKey { get; set; }

        public Rsa(int p, int q)
        {
            // Set P and Q
            P = p;
            Q = q;

            // Calculate FactorN
            FactorN = (P - 1) * (Q - 1);

            // Calculate E
            E = 2;
            while (E < FactorN)
            {
                if (RsaUtil.Gcd(E, FactorN) == 1) // E must be a coprime of FactorN
                {
                    break;
                }
                E++;
            }

            // Calculate Public Key
            PublicKey = P * Q;
            if (PublicKey < 127) throw new Exception("Public Key must be greater than maximum visible ASCII character");
            
            // Calculate Private Key
            PrivateKey = 1;
            while (true)
            {
                if (PrivateKey * E % FactorN == 1)
                {
                    break;
                }

                PrivateKey++;
            }
        }

        public BigInteger EncryptAscii(string text)
        {
            var numbers = RsaUtil.ConvertTextToNumbersList(text);
            if (numbers == null) throw new Exception("Text must be in ASCII range");
            for (var i = 0; i < numbers.Count; i++)
            {
                numbers[i] = RsaUtil.EncryptNumber(numbers[i], PublicKey, E);
            }
            var number = RsaUtil.ConvertNumbersListToNumber(numbers);
            return number;
        }

        public string DecryptAscii(BigInteger encryptedNumbers)
        {
            var numbers = RsaUtil.ConvertNumberToNumbersList(encryptedNumbers);
            for (var i = 0; i < numbers.Count; i++)
            {
                numbers[i] = RsaUtil.DecryptNumber(numbers[i], PublicKey, PrivateKey);
            }
            var message = RsaUtil.ConvertNumbersListToText(numbers);
            return message;
        }
    }
}