namespace Lab1
{
    public class Purple
    {
        public bool Task1(int a, int b, int c)
        {
            bool answer = false;

            bool allPositive = a > 0 && b > 0 && c > 0;
            bool allNegative = a < 0 && b < 0 && c < 0;
            bool allZero = a == 0 && b == 0 && c == 0;

            answer = allPositive || allNegative || allZero;

            return answer;
        }
        public bool Task2(int a, int b)
        {
            bool answer = false;

            answer = b != 0 && a % b == 0 || a != 0 && b % a == 0;

            return answer;
        }
        public bool Task3(int a, int b)
        {
            bool answer = false;


            answer = Math.Pow(a, 3) == b || Math.Pow(a, 2) == b || Math.Pow(b, 3) == a || Math.Pow(b, 2) == a;

            return answer;
        }
        public double Task4(double d, double f, double g)
        {
            double answer = 0;

            answer = Math.Pow(f, 2) - 4 * d * g;
            
            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            if (x <= -1)
                return 1;
            if (x > -1 && x <= 1)
                return -x;
            if (x > 1)
                return -1;

            return answer;
        }
        public bool Task6(double squareS, double circleS)
        {
            double a = Math.Sqrt(squareS);
            double d = Math.Sqrt(2) * a;
            double R = Math.Sqrt(circleS / Math.PI);

            return d / 2 <= R;

        }

        public int Task7(bool s, bool t, bool f)
        {
            int answer = 0;

            if (s)
            {
                if (t)
                {
                    answer = 6;
                }else
                {
                    if (f)
                    {
                        answer = 10;
                    }else
                    {
                        answer = 2;
                    }
                }
            }else
            {
                if (t)
                {
                    answer = 3;
                }else
                {
                    if (f)
                    {
                        answer = 5;
                    }
                    else
                    {
                        answer = 1;
                    }
                }
            }

            return answer;
        }
        public bool Task8(int year, int pupils, int salary)
        {
            bool answer = false;
            const int bank = 10000;

            if ((year % 400 == 0) || (year % 4 == 0 && year % 100 != 0))
                return false;

            answer = bank >= (Math.Ceiling(pupils / 7.0) * salary + pupils * 5);

            return answer;
        }
    }
}
