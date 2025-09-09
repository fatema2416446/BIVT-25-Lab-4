using System;
namespace Lab1
{
    public class Green
    {
        public bool Task1(double d)
        {
            bool answer = false;

            if (Math.Abs(d) >= 1)
            {
                answer = true;
            }

            return answer;

            //done
        }
        public bool Task2(double d, double f)
        {
            bool answer = false;

            double avg = (d + f) / 2;

            if (avg > 0)
            {
                answer = true;
            }

            return answer;
            //done
        }
        public bool Task3(int a, int b)
        {
            bool answer = false;

            int sum = a + b;
            int na = Math.Abs(a);
            int nb = Math.Abs(b);
            double avg = (na + nb) / 2;
            if (sum > avg)
            {
                answer = true;
            }

            return answer;
            //done
        }
        public int Task4(int a, int b, int c)
        {
            int answer = 0;

            int maxi = Math.Max(a, b);
            int maxj = Math.Max(c, maxi);
            answer = maxj;

            return answer;
            //done
        }
        public double Task5(double x)
        {
            double answer = 0;

            if (Math.Abs(x) > 1) {
                answer = 0;
            }
            else if (Math.Abs(x) <= 1)
            {
                answer = Math.Pow(x, 2) - 1;
            }

            return answer;
            //done
        }
        public bool Task6(double x, double y)
        {
            bool answer = false;

            if (y < 0) answer = false;
            else if (x < -1 || x > 1) answer = false;
            else if (x < 0) return answer = y <= 1 + x;
            else if (x >= 0) return answer = y <= 1 - x;

                return answer;
            //done
        }

        public bool Task7(int n)
        {
            bool answer = true;

            if (n < 0)
            {
                answer = false;
            }
            else if ( n % 2 == 0)
            {
                answer = false;
            }

            return answer;
        }
        public bool Task8(int X, int Y)
        {
            bool answer = false;

            if ((X * 60 >= 420) && (360 >= (Y * (X + 1) / 2)) && (Y * (X + 1) / 2) >= 240)
            {
                answer = true;
            }

            return answer;
        }
    }
}
