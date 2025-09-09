namespace Lab1
{
    public class Blue
    {
        public bool Task1(int a, int b)
        {
            bool answer = false;

            // code here
            answer = (a > 0 && b > 0) || (a < 0 && b < 0);
            // end

            return answer;
        }
        public bool Task2(double d)
        {
            bool answer = false;

            // code here
            if (d % 1 != 0)
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
        public bool Task3(int a, int b)
        {
            bool answer = false;

            // code here
            if (b != 0)
            {
                answer = a % b == 0;
            }
            else
            {
                answer = false;
            }
            // end

            return answer;
        }
        public double Task4(double d, double f, double g)
            {
                double answer = 0;

                // code here
                double preAns = Math.Max(Math.Abs(d), Math.Max(Math.Abs(f), Math.Abs(g)));
                if (preAns == Math.Abs(d))
                {
                    answer = d;
                }
                if (preAns == Math.Abs(g))
                {
                    answer = g;
                }
                if (preAns == Math.Abs(f))
                {
                    answer = f;
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
            if (x > 0)
            {
                answer = 1;
            }
            if ((x <= 0) && (x > -1))
            {
                answer = x+1;
            }
            // end

            return answer;
        }
        public bool Task6(double circleS, double squareS)
        {
            bool answer = false;

            // code here
            double diameter = Math.Sqrt(circleS / 3.14)*2;
            double squareSide = Math.Sqrt(squareS);
            answer = diameter <= squareSide;
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
            if ((a/2 + b/2 + c/2) % 3 == 0 && (a/2 + b/2 + c/2) >= 3)
            {
                answer = true;
            }
            else
            {
                if ((a/2 + b/2 + c/2 + 1) % 3 == 0 && (a/2 + b/2 + c/2 + 1) >= 3)
                {
                    answer = true;
                }
                else
                {
                    answer = false;
                }
            }
            // end

                return answer;
        }
    }
}
