using System.Security.Cryptography;

namespace Lab1
{
    public class Green
    {
        public bool Task1(double d)
        {
            bool answer = false;

            // code here

            if(Math.Abs(d) >= 1)
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
            if(sr > 0)
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

            int a1 = Math.Abs(a);
            int b1 = Math.Abs(b);
            int sr = (a1 + b1) / 2;
            if((a+b) > sr)
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

            int mx = 0;
            if (a > b || a == b)
            {
                mx = a;
            }
            else mx = b;
            if(mx < c)
            {
                mx = c;
            }
            answer = mx;

                // end

                return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here

            if (Math.Abs(x) > 1)
            {
                answer = 0;
            }
            else answer = Math.Pow(x, 2) - 1;

                // end

                return answer;
        }
        public bool Task6(double x, double y)
        {
            bool answer = false;

            // code here

            if(y >= 0 && x >= -1 && x <= 1)
            {
                if (y <= x + 1 && y <= 1 - x)
                {
                    answer = true;
                }
            }

            // end

            return answer;
        }

        public bool Task7(int n)
        {
            bool answer = true;

            // code here
            if(n < 0)
            {
                answer = false;
            }
            else
            {
                if(n % 2 == 0)
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

            int tea = (X / 2) + 1;
            int rznc = Y * tea;
            if(rznc >= 240 && rznc <= 360)
            {
                answer = true;
            }

            // end

            return answer;
        }
    }
}
