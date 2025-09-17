namespace Lab1
{
    public class Purple
    {
        public bool Task1(int a, int b, int c)
        {
            bool allPositive = (a > 0) && (b > 0) && (c > 0);
            bool allNegative = (a < 0) && (b < 0) && (c < 0);
            return allPositive ||  allNegative;
        }
        public bool Task2(int a, int b)
        {
            return a == 0 || b == 0 || (a % b == 0) || (b % a == 0);
        }
        public bool Task3(int a, int b)
        {
            return a * a == b || a * a * a == b || b * b == a || b * b * b == a;
        }
        public double Task4(double d, double f, double g)
        {
            // dx^2 + fx + g = 0
            return f * f - 4 * d * g;
        }
        public double Task5(double x)
        {
            if (x <= -1)
            {
                return 1;
            }

            if (x < 1)
            {
                return -x;
            }

            return -1;
        }
        public bool Task6(double squareS, double circleS)
        {
            if (squareS <= 0 || circleS <= 0)
            {
                return false;
            }
            // radius >= a*sqrt(2)/2
            // S = pi * r^2 => S / pi >= a^2 / 2 => S >= pi * a^2 / 2; a^2 = squareS
            const double eps = 1e-12;
            return circleS + eps >= Math.PI * squareS / 2;
        }

        public int Task7(bool s, bool t, bool f)
        {
            if (s && t)
            {
                return 6;
            }

            if (s && !t)
            {
                return f ? 10 : 2;
            }

            if (!t && !f)
            {
                return 1;
            }

            return t ? 3 : 5;
        }
        public bool Task8(int year, int pupils, int salary)
        {
            const int bank = 10000;
            if ((year % 400 == 0) || (year % 4 == 0 && year % 100 != 0))
            {
                return false;
            }

            if (pupils <= 0)
            {
                return true;
            }

            int aurorsNum = (pupils + 6) / 7;
            long totalCost = (long)aurorsNum * salary + (long)pupils * 5;
            return totalCost <= bank;
        }
    }
}