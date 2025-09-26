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

            // code
            answer = n % 2 == 0;
            // end

            return answer;
        }
        public int Task3(int a, int b)
        {
            int answer = 0;

            // code here
            if (a > b)
                {
                    return a;
                }
            else
                {
                    return b;
                }
            
                // end

                return answer;
        }
        public double Task4(double d, double f)
        {
            double answer = 0;
            // code here
            if (Math.Abs(d) != Math.Abs(f))
            {
                if (Math.Abs(d) < Math.Abs(f))
                {
                    answer = d;
                }
                else
                {
                    answer = f;
                }
            }
            else
            {
                if (d < f)
                {
                    answer = Math.Abs(d) * (-1);
                }
                else
                {
                    answer = Math.Abs(f);
                }
            }
            // end

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here
            double l = Math.Abs(x);
            if (l > 1)
            {
                answer = 1;
            }
            else
            {
                answer = x;
            }
                // end

                return answer;
        }
        public bool Task6(double x, double y, double r)
        {
            bool answer = false;

            // code here
            double a = x * x;
            double b = y * y;
            double c = r * r;
            double f = a + b - c;
            if ((x >= 0 && x <= r) && (y >= 0 && y <= r))
            {
                answer = true;
            }
            else
            {
                return answer;
            }
            // end

            return answer;
        }

        public bool Task7(int n)
        {
            bool answer = false;

            // code here
            int s = n * n;
            if ((s-n) > 2*n)
            {
                if (n % 2  == 0)
                {
                    answer = true;
                }
                else
                {
                    return answer;
                }
            }
            else
            {
                return answer;
            }
                // end

                return answer;
        }
        public bool Task8(double L, int T, int M)
        {
            bool answer = false;

            // code here
            if ((L <= 30 && (M == 2 || M == 4)) && ((T >= 5) || (M % 2 == 0)))
            {
                answer = true;
            }
            else
            {
                return answer;
            }
                // end

                return answer;
        }
    }
}