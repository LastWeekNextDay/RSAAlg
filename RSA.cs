using System;

namespace RSAAlgorithm
{
    public class Rsa
    {
        private int _p;

        private int P
        {
            get => _p;
            set => _p = RsaUtil.IsPrime(value) ? // P must be a prime number 
                value : throw new ArgumentException("P must be a prime number");
        }

        private int _q;

        private int Q
        {
            get => _q;
            set => _q = RsaUtil.IsPrime(value) ? // Q must be a prime number
                value  : throw new ArgumentException("Q must be a prime number");
        }

        private int FactorN { get; set; }

        private int _e;

        private int E
        {
            get => _e;
            set => _e = value > 1 && value < FactorN // E must be greater than 1 and less than factor of Public Key
                ? RsaUtil.GCD(value, FactorN) == 1 // E must be a coprime of FactorN
                    ? value
                    : throw new ArgumentException("E must be a prime number")
                : throw new ArgumentException
                    ("E must be greater than 1 and less than factor of Public Key");
        }

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
                if (RsaUtil.GCD(E, FactorN) == 1) // E must be a coprime of FactorN
                {
                    break;
                }

                E++;
            }

            // Calculate Public Key
            PublicKey = P * Q;
            // Calculate Private Key
            PrivateKey = (Constant * FactorN + 1) / E;
        }

        public long Encrypt(string text)
        {
            // Return encrypted numbers
            return (long)Math.Pow(RsaUtil.ConvertTextToNumber(text), E) % PublicKey;
        }

        public string Decrypt(long encryptedNumbers, int publicKey)
        {
            // Return decrypted text
            return RsaUtil.ConvertNumberToText((long)Math.Pow(encryptedNumbers, PrivateKey) % publicKey);
        }
    }
}