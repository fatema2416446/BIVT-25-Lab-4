namespace Lab1
{
    public class Green
    {
        public bool Task1(double d)
        {
            bool answer = false;
            // code here


            if  (d >= 1 || d <= -1 )
            {
                answer = true;

            }

            // end
            return answer;
        }
        public bool Task2(double d, double f)
        {
            bool answer = false;

            // code here
            double c = (d + f) / 2;
            if (c < 0)
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
            int c = a + b;
            int d = (Math.Abs(a) + Math.Abs(b)) / 2;
            if (c > d)
            {
                answer = true;
            }


            // end

            return answer;
        }
        public int Task4(int a, int b, int c)
        {
            int answer = 0;

            // code here
            int d = Math.Max(a, b);
            d = Math.Max(d, c);
            answer = d;
            // end

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here
            if (x > 1 || x < -1)
            {
                answer = 0;
            }
            else
            {
                answer = (x * x) - 1;

            }
                // end

                return answer;
        }
        public bool Task6(double x, double y)
        {
            bool answer = false;

            // code here
            if (x< 0 && y>= 1 + x)
            {
                answer = true;
            }
            else if(x>= 0 && y<= 1 - x)
            {
                answer = true;
            }

                // end

                return answer;
        }

        public bool Task7(int n)
        {
            bool answer = true;

            // code here
            if (n < 0)
            {
                answer = false;
            }
            else if (n % 2 == 0)
            {
                answer = false;
            }
                // end

                return answer;
        }
        public bool Task8(int X, int Y)
        {
            bool answer = false;

            // code here

            // end

            return answer;
        }
    }
}
