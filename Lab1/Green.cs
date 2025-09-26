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
            double s = (d + f) / 2;
            if (s > 0)
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
            double summ = a + b;
            double sm = (Math.Abs(a) + Math.Abs(b)) / 2;
            if (summ > sm)
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
            if (a > b && a > c)
            {
                answer = a;
            }
            else if (b > a && b > c)
            {
                answer = b;
            }
            else if (c > a && c > b)
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
            if (Math.Abs(x) > 1)
            {
                answer = 0;
            }
            else if (Math.Abs(x) <= 1)
            {
                answer = Math.Pow(x, 2) - 1;
            }
            // end

            return answer;
        }
        public bool Task6(double x, double y)
        {
            bool answer = false;

            // code here
            if (x < 0)
            {
                if (y >= 0 && y <= 1 + x)
                {
                    answer = true;
                }
            }
            else
            {
                if (y >= 0 && y <= 1 - x)
                {
                    answer = true;
                }
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
            int tdm = 0;

            if (X % 2 == 0)
            {
                tdm = Y * (X / 2);
            }
            else
            {
                tdm = Y * ((X + 1) / 2);
            }
            if (X >= 7 && tdm >= 240 && tdm <= 360)
            {
                answer = true;
            }
            // end

            return answer;
        }
    }
}

