using static System.Math;

namespace Lab1
{
    public class Blue
    {
        public bool Task1(int a, int b)
        {
            bool answer = false;

            // code here
            if (Sign(a) == Sign(b))
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
            if (d%1!=0)
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
            if (Math.Abs(d) > answer)
            {
                answer = d;
            }
            if (Math.Abs(f) > Math.Abs(answer))
            {
                answer = f;
            }
            if (Math.Abs(g) > Math.Abs(answer))
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
            else if (x > -1 && x <= 0)
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
            double circleD = Math.Sqrt(circleS * 4 / double.Pi);
            double SquareSide = Math.Sqrt(squareS);

            if (circleD <= SquareSide)
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
                else
                {
                    return answer;
                }
            }
            else
            {
                if (f > 0)
                {
                    answer = 1;
                }
                else
                {
                    return answer;
                }
            }
            // end

            return answer;
        }
        public bool Task8(int a, int b, int c)
        {
            bool answer = false;

            // code here
            int max = a / 2 + b / 2 + c / 2;
            if (max >= 2)
            {
                if (max / 3 <= a && max / 3 <= b && max / 3 <= c)
                {
                    if (max % 3 == 0 || max % 3 == 2)
                    {
                        answer = true;
                    }
                }
            }
            // end

            return answer;
        }
    }
}

