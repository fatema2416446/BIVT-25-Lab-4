namespace Lab1
{
    public class Green
    {
        public bool Task1(double d)
        {
            bool answer = false;

            // code here
         if (Math.Abs(d) >= 1)
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
            if ((d + f) / 2 > 0)
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
             double s = a + b;
             double m = (Math.Abs(a) + Math.Abs(b)) / 2;
            if (s > m) {
                answer = true;
            }
            // end

            return answer;
        }
        public int Task4(int a, int b, int c)
        {
            int answer = 0;

            // code here
            if (  a > c && a > b)
            {
                answer = a;
            }
            if (b > c && b > a)
            {
                answer = b;
            }
            if (c > b && c > a) 
            {
                answer = c;
            }
            // end

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here
             double a = Math.Abs(x);
            if (a > 1)
            {
                answer = 0;
            }
            if (a <= 1)
            {
                answer = x * x - 1;
            }
            // end

            return answer;
        }
        public bool Task6(double x, double y)
        {
            bool answer = false;

            // code here
            if (y >= 0 && y <= x +1 && y <= -x +1)
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
            if (X < 7 ){
                return false;
            }
            int nt = (X + 1) / 2;
            int ts = nt * Y;
            int tt = (4 * 60 - ts) % 1440;
            if (tt < 0)
            {
                tt += 1440;
            }
            if (tt == 0 || tt >= 22 * 60)
            {
                answer = true;
            }
            // end

            return answer;
        }
    }
}