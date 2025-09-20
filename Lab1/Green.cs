namespace Lab1
{
    public class Green
    {
        public bool Task1(double d)
        {
            bool answer = false;

            // code here
            double absd = Math.Abs(d);
            if (absd >= 1)
            {
                answer = true;
            }
            // end

            return answer;
        }
        public bool Task2(double d, double f)
        {
            bool answer = false;

            // code here
            double sr = (d + f) / 2;
            if (sr > 0)
            {
                answer = true;
            }
            // end

            return answer;

        }
        public bool Task3(double a, double b)
        {
            bool answer = false;

            // code here
            double sum = a + b;
            double sr = (Math.Abs(a) + Math.Abs(b)) / 2;
            if (sr < sum)
            {
                answer = true;
            }
            // end
            return answer;
        }
        public int Task4(int a, int b, int c)
        {
            int answer = 0;

            // code here
            return Math.Max(Math.Max(a, b), c);
            // end

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here
            double absx = Math.Abs(x);
            if (absx > 1)
            {
                return 0;
            }
            else
            {
                answer = (x * x) - 1;
            }
            // end

            return answer;
        }
        public bool Task6(double x, double y)
        {
            bool answer = false;

            // code here
            if (y >= 0)
            {
                if (x < 0)
                {
                    answer = y <= 1 + x;

                }
                else
                {
                    answer = y <= 1 - x;
                }
            }
            // end

            return answer;
        }

        public bool Task7(int n)
        {
            bool answer = true;

            // code here
            if (n < 0)
            {
                answer = false;
            }
            else
            {
                if (n % 2 == 0)
                {
                    answer = false;
                }
            }

            // end

            return answer;
        }
        public bool Task8(int X, int Y)
        {
            bool answer = false;

            // code here
            int day = X;
            if (X % 2 != 0)
            {
                day = (X / 2) + 1;
            }
            else
            {
                day = X / 2;
            }
            int tea_day = day * Y;
            if ((tea_day >= 240) && (tea_day <= 360) && X >= 7)
            {
                answer = true;
            }


            // end

            return answer;
        }
    }
}
