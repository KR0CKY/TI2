using System;
using System.Numerics;


namespace TI
{
    class Key
    {
        static long[] OpenExp = new long[4] { 71, 499, 1601, 65537 };

        private long q;

        private long p;

        private long Module;

        private long SecretExp;

        private long e;

        public long[] PrivateKey { get; }

        public long[] PublicKey { get; }

        public Key()
        {
            PrivateKey = new long[2];
            PublicKey = new long[2];
        }

        public void CreateKey()
        {
           
            bool Simple = false;
            Random random = new Random();

            while (!Simple)
            {
                p = random.Next(100, 10000);
                if (SimpleNumber(p))
                {
                    Simple = true;
                    for (long i = 2; i < Math.Sqrt(p) + 1; i++)
                    {
                        if (p % i == 0)
                        {
                            Simple = false;
                            break;
                        }
                    }
                }
            }

            Simple = false;
            while (!Simple)
            {
                q = random.Next(100, 10000);
                if (SimpleNumber(q))
                {
                    Simple = true;
                    for (long i = 2; i < Math.Sqrt(q) + 1; i++)
                    {
                        if (q % i == 0)
                        {
                            Simple = false;
                            break;
                        }
                    }
                }
            }

            Module = p * q;

            long EulerFunction = (p - 1) * (q - 1);

            e = OpenExp[random.Next(0, 4)];

            PublicKey[0] = e;
            PublicKey[1] = Module;

            SecretExp = CloseExp(e, EulerFunction);
            if (SecretExp < 0)
                SecretExp = EulerFunction + SecretExp;
            if (SecretExp == 0)
                CreateKey();

            PrivateKey[0] = SecretExp;
            PrivateKey[1] = Module;
        }

        
        private bool SimpleNumber(long Num)
        {
            for (long i = 2; i < Num && i < 11; i++)
            {
                if (!Miller(Num, i))
                {
                    return false;
                }
            }
            return true;
        }

        
        private bool Miller(long Num, long a)
        {

            if (Num % 2 == 0)
                return false;
            long s = 0, d = Num - 1;
            while (d % 2 == 0)
            {
                d /= 2;
                s++;
            }

            long r = 1;
            long x = (long)BigInteger.ModPow(a, d, Num);
            if (x == 1 || x == Num - 1)
                return true;

            x = (long)BigInteger.ModPow((long)Math.Pow(a, d), (long)Math.Pow(2, r), Num);

            if (x == 1)
                return false;

            if (x != Num - 1)
                return false;

            return true;
        }

        
        private static void Euclid(long a, long b, out long x, out long y, out long d)
        {
            long q, r, x1, x2, y1, y2;

            if (b == 0)
            {
                d = a;
                x = 1;
                y = 0;
                return;
            }

            x2 = 1;
            x1 = 0;
            y2 = 0;
            y1 = 1;

            while (b > 0)
            {
                q = a / b;
                r = a - q * b;
                x = x2 - q * x1;
                y = y2 - q * y1;
                a = b;
                b = r;
                x2 = x1;
                x1 = x;
                y2 = y1;
                y1 = y;
            }

            d = a;
            x = x2;
            y = y2;
        }
        static long CloseExp(long a, long n)
        {
            long x, y, d;
            Euclid(a, n, out x, out y, out d);

            if (d == 1)
                return x;

            return 0;

        }

    }
}

