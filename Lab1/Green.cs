```csharp
using System;

namespace Lab1
{
    public sealed class Green
    {
        // Task1: |x| >= 1 and not zero
        public bool Task1(double x)
        {
            return x != 0 && Math.Abs(x) >= 1;
        }

        // Task2: different signs or one is zero
        public bool Task2(double a, double b)
        {
            return a * b <= 0;
        }

        // Task3: true if a <= b
        public bool Task3(int a, int b)
        {
            return a <= b;
        }

        // Task4: maximum of three integers
        public int Task4(int a, int b, int c)
        {
            return Math.Max(a, Math.Max(b, c));
        }

        // Task5: special cosine-based function
        public double Task5(double x)
        {
            if (x == 0) return -1;
            if (x > 0 && x < 1) return -Math.Cos(x);
            return 0;
        }

        // Task6: both strictly between 0 and 1
        public bool Task6(double a, double b)
        {
            return a > 0 && b > 0 && a < 1 && b < 1;
        }

        // Task7: check if number is prime
        public bool Task7(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i * i <= n; i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }

        // Task8: true if a >= 7 and b between 50 and 60 inclusive
        public bool Task8(int a, int b)
        {
            return a >= 7 && b >= 50 && b <= 60;
        }
    }
}
```
