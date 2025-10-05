```csharp
namespace Lab1
{
    public class White
    {
        // Task1: return true if number > 0 and is an integer
        public bool Task1(double x)
        {
            return x > 0 && Math.Abs(x - Math.Round(x)) < 1e-9;
        }

        // Task2: return true if number is even
        public bool Task2(int x)
        {
            return x % 2 == 0;
        }

        // Task3: return the number with the larger absolute value
        public int Task3(int a, int b)
        {
            return Math.Abs(a) >= Math.Abs(b) ? a : b;
        }

        // Task4: return the smaller of two numbers, but only if it is < 0
        // else return 0
        public int Task4(int a, int b)
        {
            int min = Math.Min(a, b);
            return min < 0 ? min : 0;
        }

        // Task5: if |x| >= 1 return sign(x), otherwise return x itself
        public double Task5(double x)
        {
            if (Math.Abs(x) >= 1)
                return Math.Sign(x);
            return x;
        }

        // Task6: check triangle inequality
        public bool Task6(double a, double b, double c)
        {
            return a > 0 && b > 0 && c > 0 &&
                   a + b > c &&
                   a + c > b &&
                   b + c > a;
        }

        // Task7: return true if number divisible by both 2 and 3
        public bool Task7(int x)
        {
            return x % 2 == 0 && x % 3 == 0;
        }

        // Task8: check if point (x, y) lies inside circle radius r
        public bool Task8(double x, int y, int r)
        {
            return (x * x + y * y) <= r * r;
        }
    }
}
```
