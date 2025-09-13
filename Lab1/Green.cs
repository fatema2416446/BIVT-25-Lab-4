namespace Lab1
{
    public class Green
    {
        public bool Task1(double d)
        {
            bool answer = false;

            // code here
            double m = Math.Abs(d);
            if (m >= 1)
            {
                answer = true;
            }
            else
            {
                answer = false;
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
        public bool Task3(int a, int b)
        {
            bool answer = false;

            // code here
            int summ = a + b;
            int ModSr = (Math.Abs(a) + Math.Abs(b)) / 2;
            if (summ > ModSr)
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
            int MaxAB = Math.Max(a, b);
            answer = Math.Max(MaxAB, c);
            // end

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here
            if (x > 1 | x < -1)
            {
                answer = 0;
            }
            else
            {
                answer = x * x - 1;
            }
            // end

            return answer;
        }
        public bool Task6(double x, double y)
        {
            bool answer = false;

            // code here
            if (y < 0)
            {
                answer = false;
            }
            else if ((x < 0) & (y <= (x + 1)))
            {
                answer = true;
            }
            else if ((x >= 0) & (y <= (1 - x)))
            {
                answer = true;
            }
            // end

            return answer;
        }

        public bool Task7(int n)
        {
            bool answer = true;

            // code here
            if (n >= 0)
            {
                if (n % 2 == 0)
                {
                    answer = false;
                }
            }
            else
            {
                answer = false;
            }
            // end

            return answer;
        }
        public bool Task8(int X, int Y)
        {
            bool answer = false;

            // code here
            int SumY = 0;
            if (X >= 7)
            {
                for (int i = 0; i < X; i++)
                { 
                    if ((i % 2) == 0) { SumY += Y; }
                 
                }
                if ((SumY >= 4 * 60) && (SumY <= 6 * 60))
                    answer = true;
            }
            // end

            return answer;
        }
    }
}