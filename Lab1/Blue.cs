namespace Lab1
{
    public class Blue
    {
        public bool Task1(int a, int b)
        {
            bool answer = (a * b > 0);
            return answer;
        }
        public bool Task2(double d)
        {
            bool answer = (Math.Abs(d) - (int)Math.Abs(d) > 0);
            return answer;
        }
        public bool Task3(int a, int b)
        {
            bool answer = (b != 0 && a % b == 0);
            return answer;
        }
        public double Task4(double d, double f, double g)
        {
            double answer = 0;

            double mx = Math.Max(Math.Max(Math.Abs(d), Math.Abs(f)), Math.Abs(g));
            if (Math.Abs(d) == mx) {
                answer = d;
            } else if (Math.Abs(f) == mx) {
                answer = f;
            } else if (Math.Abs(g) == mx) {
                answer = g;
            }
            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;
            if (x <= -1)
            {
                answer = 0;
            } else if (x <= 0)
            {
                answer = x + 1;
            } else
            {
                answer = 1;
            }

                return answer;
        }
        public bool Task6(double circleS, double squareS)
        {
            bool answer = (Math.Sqrt(circleS / Math.PI) <= Math.Sqrt(squareS) / 2.0);

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
            } else
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
            int g = (a / 2 + b / 2 + c / 2);
            if (g != 0)
            {
                if (g % 3 == 2)
                {
                    g++;
                }
                if (g % 3 == 0)
                {
                    g /= 3;
                    if (g <= c && g <= b && g <= a)
                    {
                        answer = true;
                    }
                }
            }
            
                // en

                return answer;
        }
    }
}