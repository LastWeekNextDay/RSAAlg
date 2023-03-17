using System;
using System.Collections.Generic;
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

        private int PublicKey { get; set; }

        private int PrivateKey { get; set; }

        private int Constant { get; set; } = 5;

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

        public Tuple<BigInteger, int> Encrypt(string text)
        {
            var textNumber = RsaUtil.ConvertTextToNumber(text);
            var power = BigInteger.Pow(textNumber, E);
            var result = power % PublicKey;
            // Return encrypted numbers
            return Tuple.Create(result, PublicKey);
        }

        public string Decrypt(BigInteger encryptedNumbers, int publicKey)
        {
            var power = BigInteger.Pow(encryptedNumbers, PrivateKey);
            var result = power % publicKey;
            // Return decrypted text
            return RsaUtil.ConvertNumberToText(result);
        }
    }
}