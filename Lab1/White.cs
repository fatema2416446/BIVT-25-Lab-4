namespace Lab1
{
    public class White
    {
        public bool Task1(double d)
        {
            bool answer = false;

            // code here
            answer = d > 0;
            // end

            return answer;
        }
        public bool Task2(int n)
        {
            bool answer = false;

            // code here
            answer = n % 2 == 0;
            // end

            return answer;
        }
        public int Task3(int a, int b)
        {
            int answer = 0;

            // code here
            if (a>b)
                answer = a;
            if (a<b)
                answer = b; 
            // end

            return answer;
        }
        public double Task4(double d, double f)
        {
            double answer = 0;

            if (Math.Min(Math.Abs(d), Math.Abs(f)) == Math.Abs(d))
            {
                answer = d;
            }
            else answer = f;

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here
            if (Math.Abs(x) > 1) answer = 1;
            if (Math.Abs(x) <= 1) answer = x;
            // end

            return answer;
        }
        public bool Task6(double x, double y, double r)
        {
            bool answer = false;

            // code here
            if (Math.Abs(x*x + y*y - r*r) <= 0.0001)
                answer = true;
            //double xyr = x * x + y * y - r * r;
            //answer = xyr <= 0.0001;
            // end

            return answer;
        }

        public bool Task7(int n)
        {
            bool answer = false;

            // code here
            int s = n * n;
            if (s - n > 2 * n)
            {
                if (n % 2 == 0)
                {
                    answer = true;
                }
            }
            // end

            return answer;
        }
        public bool Task8(double L, int T, int M)
        {
            bool answer = false;

            // code here
            answer = (L / 10 <= 3 && T + M >= 5 && M % 2 == 0);
            // end

            return answer;
        }
    }
}
