namespace Lab1
{
    public class Blue
    {
        public bool Task1(int a, int b)
        {
            bool answer = false;

            // code here
            if( (a > 0 && b > 0) || (a < 0 && b < 0) || (a == b))
                answer = true;
            // end

            return answer;
        }
        public bool Task2(double d)
        {
            bool answer = false;

            // code here
            if (Convert.ToInt16(d)!=d)
                answer = true;
            // end

            return answer;
        }
        public bool Task3(int a, int b)
        {
            bool answer = false;

            // code here
            if (b != 0)
            {
                int c = a / b;
                if (c * b == a)
                    answer = true;
            }
            // end

            return answer;
        }
        public double Task4(double d, double f, double g)
        {
            double answer = 0;

            // code here
            double c = Math.MaxMagnitude(Math.Abs(d), Math.Abs(f));
            double b = Math.Max(c, Math.Abs(g));
            if (b == Math.Abs(g))
                answer = g;
            else if (b == Math.Abs(d))
                answer = d;
            else
                answer = f;
                // end

                return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here
            if (x <= -1)
                answer = 0;
            if (x>-1 && x<=0)
                answer = x+1;
            if (x>0)
                answer = 1;

            // end

            return answer;
        }
        public bool Task6(double circleS, double squareS)
        {
            bool answer = false;

            // code here
            double a=Math.Sqrt(circleS/Math.PI);
            double b = Math.Sqrt(squareS);
            if (0.5*b>=a)
                answer = true;
            // end

            return answer;
        }

        public double Task7(double d, double f)
        {
            int answer = 0;

            // code here
             if (Math.Abs(d)<Math.Abs(f))
            { if (d>0)
                    answer = -1;
            }
            else
            {  if (f > 0)
                    answer = 1;
            }
                // end

                return answer;
        }
        public bool Task8(int a, int b, int c)
        {
            bool answer = false;

            // code here
            int g=(a/2+b/2+c/2);
            double s = (g-3) / 3;
            double m = g - (s * 3 + 3);
            if (g>=2)
                if ((g+1)%3==0 || g%3==0)
                    if ((a>= (g + 1) / 3 && a>= g / 3) && (b>= (g + 1) / 3 && b>= g / 3) && (c>= (g + 1) / 3 && c>= g / 3))
                        answer = true;


            // end

            return answer;
        }
    }

}
