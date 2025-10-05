```csharp
namespace Lab1
{
    public sealed class Blue
    {
        // Task1: check if numbers have opposite signs
        public bool Task1(int a, int b)
        {
            return (a < 0 && b > 0) || (a > 0 && b < 0);
        }

        // Task2: true if |x| < 1 and not zero
        public bool Task2(double x)
        {
            return x != 0 && System.Math.Abs(x) < 2;
        }

        // Task3: true if a is divisible by b
        public bool Task3(int a, int b)
        {
            if (b == 0) return false;
            return a % b == 0;
        }

        // Task4: maximum of three numbers
        public double Task4(double a, double b, double c)
        {
            return System.Math.Max(a, System.Math.Max(b, c));
        }

        // Task5: piecewise absolute function
        public double Task5(double x)
        {
            if (System.Math.Abs(x) >= 1) return 1;
            return 1 - System.Math.Abs(x);
        }

        // Task6: check if a < b
        public bool Task6(double a, double b)
        {
            return a < b;
        }

        // Task7: comparator
        public double Task7(double a, double b)
        {
            if (a > b) return 1;
            if (a < b) return -1;
            return 0;
        }

        // Task8: triangle existence
        public bool Task8(int a, int b, int c)
        {
            if (a <= 0 || b <= 0 || c <= 0) return false;
            return (a + b > c) && (a + c > b) && (b + c > a);
        }
    }
}
```
