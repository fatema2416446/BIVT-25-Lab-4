
namespace Lab1
{
    public class Blue
    {
        public bool Task1(int a, int b)
        {
            bool answer = false;

            // code here
            if ((a < 0 && b < 0) || (a > 0 && b > 0))
                answer = true;
            else
                answer = false;
            // end

            return answer;
        }
        public bool Task2(double d)
        {
            bool answer = false;

            // code here
            if (d == Math.Round(d))
                answer = false;
            else
                answer = true;
            // end

            return answer;
        }
        public bool Task3(int a, int b)
        {
            bool answer = false;

            // code here
            if (((b != 0) && (Math.Abs(a) % Math.Abs(b) == 0)) || (a == 0))
                answer = true;
            else
                answer = false;
            // end

            return answer;
        }

        private int Abs(int v)
        {
            throw new NotImplementedException();
        }

        public double Task4(double d, double f, double g)
        {
            double answer = 0;

            // code here
            if ((Math.Abs(d) > Math.Abs(f)) && (Math.Abs(d) > Math.Abs(g)))
                answer = d;
            else if ((Math.Abs(f) > Math.Abs(d)) && (Math.Abs(f) > Math.Abs(g)))
                answer = f;
            else
                answer = g;
            // end

            return answer;
        }

        private int Abs(double g)
        {
            throw new NotImplementedException();
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
            double r = Math.Sqrt(circleS / Math.PI);
            double a = Math.Sqrt(squareS);
            if (2 * r <= a)
                answer = true;
            else
                answer = false;
            // end

            return answer;
        }

        public double Task7(double d, double f)
        {
            int answer = 0;

            // code here
            if (Math.Abs(d) * 100 < Math.Abs(f) * 100)
            {
                if (d > 0)
                    answer = -1;
                else
                    answer = 0;
            }
            else
            {
                if (f > 0)
                    answer = 1;
                else
                    answer = 0;
            }
            // end

            return answer;
        }
        public bool Task8(int a, int b, int c)
        {
            bool answer = false;

            // code here
            int s1 = a / 2;
            int s2 = b / 2;
            int s3 = c / 2;
            int s = s1 + s2 + s3;
            if ((s >= 2) && ((s % 3 == 0) || (s % 3 == 2)))
                answer = true;
            else
                answer = false;
                // end

                return answer;
        }
    }
}