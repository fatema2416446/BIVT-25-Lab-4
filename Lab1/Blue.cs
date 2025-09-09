namespace Lab1
{
    public class Blue
    {
        public bool Task1(int a, int b)
        {
            bool answer = false;

            // code here

            if ((a > 0 && b > 0) || (a < 0 && b < 0))
            {
                answer = true;
            }

            // end

            return answer;
        }
        public bool Task2(double d)
        {
            bool answer = true;

            // code here

            if(d % 1 == 0)
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

            double d1 = Math.Abs(d);
            double f1 = Math.Abs(f);
            double g1 = Math.Abs(g);

            if ((d1 > f1 || d1 == f1) && (d1 > g1 || d1 == g1))
            {
                answer = d;
            }
            else if ((f1 > d1 || f1 == d1) && (f1 > g1 || f1 == g1))
            {
                answer = f;
            }
            else answer = g;

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
            else if (-1 < x && x <= 0)
            {
                answer = x + 1;
            }
            else answer = 1;

                // end

                return answer;
        }
        public bool Task6(double circleS, double squareS)
        {
            bool answer = false;

            // code here
            double pr = circleS / Math.PI;
            double r = Math.Pow(pr, 0.5);
            double a = Math.Pow(squareS, 0.5);
            if (r * 2 <= a)
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

            double d1 = Math.Abs(d);
            double f1 = Math.Abs(f);
            if(d1 < f1)
            {
                if(d > 0)
                {
                    answer = -1;
                }
            }
            else
            {
                if(f > 0)
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

            int a1 = a / 2;
            int b1 = b / 2;
            int c1 = c / 2;
            int s = a1 + b1 + c1;
            if (s % 3 == 0)
            {
                int k = s / 3;
                if(k>=1 && k <= c1)
                {
                    answer = true;
                }
            }
            if((s+1) % 3 == 0)
            {
                int k = (s + 1) / 3;
                if(k>=1 && k == c1 + 1)
                {
                    answer = true;
                }
            }
            // end

            return answer;
        }
    }
}
