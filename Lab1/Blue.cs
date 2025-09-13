namespace Lab1
{
    public class Blue
    {
        public bool Task1(int a, int b)
        {
            bool answer = false;

            // code here
            if ((a==0 && b==0) || (a>0 && b>0) || (a<0 && b<0))
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
            if (((Math.Abs(d) * 10000) % 10000) != 0)
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
            if ((Math.Abs(a) % Math.Abs(b)) == 0)
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
            answer = d;
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
            if (x > 0)
            {
                answer = 1;
            }
            else if ((-1 < x) && (x <= 0))
            {
                answer = x + 1;
            }
            // end

            return answer;
        }
        public bool Task6(double circleS, double squareS)
        {
            bool answer = false;

            // code here
            double d = 2 * (Math.Sqrt(circleS / Math.PI));
            double a = Math.Sqrt(squareS);
            if (d <= a)
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
            int m = (a/2) + (b/2) + (c/2);
            int mn = Math.Min(Math.Min(a, b), c);
            if (m % 3 == 0)
            {
                if (m >= 3)
                {
                    if ((m / 3) <= mn)
                    {
                        answer = true;
                    }
                }
            }
            else if ((m + 1) % 3 == 0)
            {
                if ((m + 1) >= 3)
                {
                    if (((m + 1) / 3) <= mn)
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
