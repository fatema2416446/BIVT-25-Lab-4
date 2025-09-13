using System.Linq.Expressions;

namespace Lab1
{
    public class Blue
    {
        public bool Task1(int a, int b)
        {
            bool answer = false;

            // code here

            if (Math.Min(a, b) > 0 || Math.Max(a, b) < 0)
            {
                answer = true;
            }

            // end

            return answer;
        }
        public bool Task2(double d)
        {
            bool answer = false;

            // code here

            if (d != (double)(int)d)
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

            if (b != 0 && a % b == 0)
            {
                answer = true;
            }

            // end

            return answer;
        }
        public double Task4(double d, double f, double g)
        {
            double answer = 0;

            // code here

            if (Math.Abs(answer) < Math.Abs(d))
            {
                answer = d;
            }
            if (Math.Abs(answer) < Math.Abs(f))
            {
                answer = f;
            }
            if (Math.Abs(answer) < Math.Abs(g))
            {
                answer = g;
            }

            // end

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here

            if (x <= -1)
            {
                answer = 0;
            }
            else if (x <= 0)
            {
                answer = x + 1;
            }
            else
            {
                answer = 1;
            }

            // end

            return answer;
        }
        public bool Task6(double circleS, double squareS)
        {
            bool answer = false;

            // code here

            // 2*r v a,  4*r^2 v a^2
            if (4 * circleS <= Math.PI * squareS)
            {
                answer = true;
            }

            // end

            return answer;
        }

        public double Task7(double d, double f)
        {
            int answer = 0;

            // code here

            if (Math.Abs(d) < Math.Abs(f))
            {
                if (d > 0)
                {
                    answer = -1;
                }
            }
            else
            {
                if (f > 0)
                {
                    answer = 1;
                }
            }

            // end

            return answer;
        }
        public bool Task8(int a, int b, int c)
        {
            bool answer = false;

            // code here

            int sm = a / 2 + b / 2 + c / 2;
            if (sm % 3 == 0 && sm >= 3)
            {
                answer = true;
            }
            else if (sm % 3 == 2)
            {
                answer = true;
            }

            // end

            return answer;
        }
    }
}