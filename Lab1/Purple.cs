namespace Lab1
{
    public class Purple
    {
        private int Max(int a, int b)
        {
            if (a < b) return b;
            return a;
        }

        private double Max(double a, double b)
        {
            if (a < b) return b;
            return a;
        }

        private int Min(int a, int b)
        {
            if (a < b) return a;
            return b;
        }

        private double Min(double a, double b)
        {
            if (a < b) return a;
            return b;
        }

        private int Abs(int x)
        {
            if (x >= 0) return x;
            return -x;
        }

        private int Max(int[] a)
        {
            int ans = (int)(-1e9);
            foreach (int i in a)
                if (i > ans)
                    ans = i;
            return ans;
        }

        private int Min(int[] a)
        {
            int ans = (int)(1e9);
            foreach (int i in a)
                if (i < ans)
                    ans = i;
            return ans;
        }

        private int Pow(int a, int b)
        {
            if (b == 0) return 1;
            if ((b & 1) == 1) return Pow(a, b - 1) * a;
            int temp = Pow(a, b >> 1);
            return temp * temp;
        }

        private double Pow(double a, int b)
        {
            if (b == 0) return 1;
            if ((b & 1) == 1) return Pow(a, b - 1) * a;
            double temp = Pow(a, b >> 1);
            return temp * temp;
        }


        public bool Task1(int a, int b, int c)
        {
            int[] l = { a, b, c };
            bool answer = (Max(l) < 0) || (Min(l) > 0) || (a * a + b * b + c * c == 0);
            return answer;
        }
        public bool Task2(int a, int b)
        {
            if (a == 0 || b == 0) return true;
            bool answer = Max(Abs(a), Abs(b)) % Min(Abs(a), Abs(b)) == 0;
            return answer;
        }
        public bool Task3(int a, int b)
        {
            bool answer = (Pow(a, 2) == b) || (Pow(a, 3) == b) || (Pow(b, 2)) == a || (Pow(b, 3) == a);
            return answer;
        }
        public double Task4(double d, double f, double g)
        {
            double answer = Pow(f, 2) - 4 * d * g;
            return answer;
        }
        public double Task5(double x)
        {
            double answer = Max(-1, Min(1, -x));
            return answer;
        }
        public bool Task6(double squareS, double circleS)
        {
            bool answer = circleS >= 3.1415 / 2 * squareS;
            return answer;
        }

        public int Task7(bool s, bool t, bool f)
        {
            if (s)
            {
                if (t)
                    return 6;
                else
                {
                    if (f)
                        return 10;
                    else
                        return 2;
                }
            }
            if (t)
                return 3;
            if (f)
                return 5;
            return 1;
        }
        public bool Task8(int year, int pupils, int salary)
        {
            const int bank = 10000;
            if (year % 400 == 0 || (year % 4 == 0 && year % 100 > 0)) return false;
            return 5 * pupils + salary * ((pupils + 6) / 7) <= bank;
        }
    }
}