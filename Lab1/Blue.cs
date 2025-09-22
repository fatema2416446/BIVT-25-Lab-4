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
            bool answer = false;

            // code here
            if (Math.Abs(d) - Math.Floor(Math.Abs(d)) > 0)
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
            if (Math.Abs(d) > Math.Abs(g) && Math.Abs(d) > Math.Abs(f))
            {
                answer = d;
            }
            else if (Math.Abs(g) > Math.Abs(d) && Math.Abs(g) > Math.Abs(f))
            {
                answer = g;
            }
            else if (Math.Abs(f) > Math.Abs(g) && Math.Abs(f) > Math.Abs(d))

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
            else if (x <= 0 && x > -1)
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
            double kr = Math.Sqrt(circleS / Math.PI) * 2;
            double kv = Math.Sqrt(squareS);
            if (kr <= kv)
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
            else if (f > 0)
            {
                answer = 1;
            }
            
            // end

            return answer;
        }
        public bool Task8(int a, int b, int c)
        {
            bool answer = false;

            // code here
            int A = a / 2;
            int B = b / 2;
            int C = c / 2;
            
            
            if ((A+B+C)%3 == 0)
            {
                answer = true;

            }
            else if ((A+B+C+1)%3==0)
            {
                answer = true;
            }
            if (A+B+C+1 < 3)
            {
                answer = false;
            }

                // end

                return answer;
        }
    }
}
