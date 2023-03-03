using System;

namespace RSAAlgorithm
{
    public class Rsa
    {
        private int _p;

        private int P
        {
            get => _p;
            set => _p = RsaUtil.IsPrime(value) ? value : throw new ArgumentException("P must be a prime number");
        }

        private int _q;

        private int Q
        {
            get => _q;
            set => _q = RsaUtil.IsPrime(value) ? value : throw new ArgumentException("Q must be a prime number");
        }

        private int FactorN { get; set; }

        private int _e;

        private int E
        {
            get => _e;
            set => _e = value > 1 && value < FactorN ? value
                : throw new ArgumentException
                    ("E must be greater than 1 and less than factor of Public Key");
        }

        private int PublicKey { get; set; }

        private int PrivateKey { get; set; }

        private int Constant { get; set; } = 5;
        
        public Rsa(int p, int q, int e)
        {
            P = p;
            Q = q;
            FactorN = (P - 1) * (Q - 1);
            E = e;
            PublicKey = P * Q;
            PrivateKey = (Constant * FactorN + 1) / E;
        }
        
        public long Encrypt(int initialNumbers)
        {
            return (long)Math.Pow(initialNumbers, E % PublicKey);
        }
        
        public long Decrypt(int encryptedNumbers)
        {
            return (long)Math.Pow(encryptedNumbers, PrivateKey % PublicKey);
        }
    }
}