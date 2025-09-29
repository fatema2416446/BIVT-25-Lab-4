namespace Lab1
{
    public class Blue
    {
        public bool Task1(int a, int b)
        {
            bool answer = false;

            // code here
            if ((a < 0 && b < 0) || (a > 0 && b > 0))
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
            if (b == 0)
            {
                answer = false;
            }
            else
            {
                if (a % b == 0)
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
        public double Task4(double d, double f, double g)
        {
            double answer = 0;

            // code here
            if (Math.Abs(d) >= Math.Abs(f) && Math.Abs(d) >= Math.Abs(g))
            {
                return d;
            }
            else if (Math.Abs(f) >= Math.Abs(d) && Math.Abs(f) >= Math.Abs(g))
            {
                return f;
            }
            else
            {
                return g;
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
            double circled = Math.Sqrt(circleS / Math.PI) * 2;
            double squared = Math.Sqrt(squareS);
            if (squared <= circled)
            {
                answer = false;
            }
            if (squared >= circled)
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
            if (Math.Abs(d) > Math.Abs(f))
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
            int coins = a / 2 + b / 2 + c / 2;
            if (coins % 3 == 0)
            {
                int p = coins / 3;
                if (a >= p && b >= p && p >= 1)
                {
                    answer = true;
                }
            }
            else
            {
                if ((coins + 1) % 3 == 0)
                {
                    int p = (coins + 1) / 3;
                    if (a >= p && b >= p && (c + 1) >= p && p >= 1)
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
