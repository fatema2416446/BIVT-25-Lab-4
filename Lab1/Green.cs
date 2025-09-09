namespace Lab1
{
    public class Green
    {
        public bool Task1(double d)
        {
            bool answer = false;

            // code here
            if (Math.Abs(Math.Abs(d)) >= 1)
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
            if ((f+d)/2 > 0)
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
            int sm = (a + b);  
            double s = (Math.Abs(a) + Math.Abs(b))/2;
            if (sm > s)
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
            answer = Math.Max(Math.Max(a, b), c);
            // end

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here
            if (Math.Abs(x) <= 1)
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
            if (y < 0)
                return false;
            double upperBound;
            if (x < 0)
            {
                upperBound = x + 1;
            }
            else
            {
                upperBound = 1 - x;
            }
            answer = y <= upperBound;
            // end

            return answer;
        }

        public bool Task7(int n)
        {
            bool answer = true;

            // code here
            if(n < 0)
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
            int breathe = X * 60;
            int tea = ((X + 1) / 2) * Y;
            answer = breathe >= 420 && tea >= 240 && tea <= 360;
            // end

            return answer;
        }
    }
}
