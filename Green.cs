namespace Lab1
{
    public class Green
    {
        public bool Task1(double d)
        {
            bool answer = false;

            // code here
            if (d>=1 || d<= -1)
                answer = true;
            // end

            return answer;
        }
        public bool Task2(double d, double f)
        {
            bool answer = false;

            // code here
            double g = (d + f) / 2;
            if (g>0)
                answer= true;
            // end

            return answer;
        }
        public bool Task3(int a, int b)
        {
            bool answer = false;

            // code here
            int summa = a + b;
            double abssumma = (Math.Abs(a) + Math.Abs(b)) / 2.0;
            if (summa>abssumma)
                answer = true;
            // end

            return answer;
        }
        public int Task4(int a, int b, int c)
        {
            int answer = 0;

            // code here
            int m1 = Math.Max(a, b);
            answer = Math.Max(m1, c);
            // end

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here
            if (Math.Abs(x) > 1)
            {
                answer = 0;
            }
            else
            {
                answer = x*x - 1;
            }
                // end

                return answer;
        }
        public bool Task6(double x, double y)
        {
            bool answer = false;

            // code here
            if (Math.Abs(x)<=1 && y>=0 && Math.Abs(x)<=1-y)
                answer= true;
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
            else
            {
                if (n % 2 == 0)
                answer = false;
            }
            // end

            return answer;
        }
        public bool Task8(int X, int Y)
        {
            bool answer = false;

            // code here
            int w = X * 60;
            int tea = (X + 1) / 2;
            int sleep = tea * Y;
            bool a1 = w >= 240;
            bool a2 = sleep >= 240 & sleep <= 360;
            answer = a1 & a2;
            // end

            return answer;
        }
    }
}