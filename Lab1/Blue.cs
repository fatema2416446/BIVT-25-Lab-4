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
            if (d - (int)d != 0)
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
                answer = a % b == 0;
            }
            // end

            return answer;
        }
        public double Task4(double d, double f, double g)
        {
            double answer = 0;

            // code here
            answer = Math.Max(Math.Max(Math.Abs(d), Math.Abs(f)), Math.Abs(g));
            if (Math.Abs(d) == answer)
            {
                answer = d;
            }
            else if (Math.Abs(f) == answer)
            {
                answer = f;
            }
            else
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
            else if (-1 < x && x <= 0)
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
            double r_c = Math.Sqrt(circleS / Math.PI);
            double r_s = Math.Sqrt(squareS) / 2;
            if (r_c <= r_s)
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

        public double Task7(double d, double f)
        {
            int answer = 0;

            // code here
            if (Math.Abs(d) < Math.Abs(f))
            {
                if (d > 0) {
                    answer = -1;
                }
            }
            else
            {
                if (f > 0) {
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
            int zap_a = (int)Math.Floor(a / 2.0);
            int zap_b = (int)Math.Floor(b / 2.0);
            int zap_c = (int)Math.Floor(c / 2.0);

            int S = zap_a + zap_b + zap_c;

            if (S % 3 == 0)
            {
                answer = S / 3 >= 1;
            }
            
            if ((S + 1) % 3 == 0)
            {
                answer = (S + 1) / 3 >= 1;
            }
            // end

            return answer;
        }
    }
}
