```csharp
using System;

namespace Lab1
{
    public sealed class Purple
    {
        // Task1: true if a is strictly between b and c
        public bool Task1(int a, int b, int c)
        {
            return (b < a && a < c) || (c < a && a < b);
        }

        // Task2: true if either divides the other
        public bool Task2(int a, int b)
        {
            if (a == 0 || b == 0) return true;
            return (a % b == 0) || (b % a == 0);
        }

        // Task3: cube relation
        public bool Task3(int a, int b)
        {
            return a == b * b * b || b == a * a * a;
        }

        // Task4: TODO refine; placeholder formula
        public double Task4(double a, double b, double c)
        {
            return a * a + b * b - c * c;
        }

        // Task5: piecewise function
        public double Task5(double x)
        {
            if (Math.Abs(x) <= 1) return -x;
            return x > 0 ? -1 : 1;
        }

        // Task6: TODO refine
        public bool Task6(double a, double b)
        {
            return Math.Abs(a - b) < 1e-9;
        }

        // Task7: TODO refine
        public double Task7(bool a, bool b, bool c)
        {
            // Just a placeholder mapping
            if (a && b && c) return 6;
            if (a && b && !c) return 6;
            if (a && !b && c) return 2;
            if (!a && !b && !c) return 1;
            return 5;
        }

        // Task8: TODO refine; placeholder check
        public bool Task8(int year, int m, int d)
        {
            // Maybe leap year & valid date check
            try
            {
                var dt = new DateTime(year, 1, 1).AddDays(m - 1).AddDays(d - 1);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
```
