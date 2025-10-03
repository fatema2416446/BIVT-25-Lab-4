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
            double a = d + f;
            if ((a/2)>0)
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
            double c = a + b;
            double d = (Math.Abs(a) + Math.Abs(b))/2;
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
            if (a > b && a > c)
            {
                answer = a;
            }
            if (b > a && b > c)
            {
                answer = b;
            }
            if (c > a && c > b)
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
            else
            {
                answer = Math.Pow(x,2) - 1;
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

                if (1 + x >= y && y >= 0)
                {
                    answer = true;
                }
            }
            else
            {

                if (1 - x >= y && y >= 0)
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
            if (n<0)
            {
                answer = false;
            }
            else
            {
                if (n % 2 == 0)
                {
                    answer = false;
                }
            }
                // end

                return answer;
        }
        public bool Task8(int X, int Y)
        {
            bool answer = false;

            // code here
            int T = Math.Min(X, 7) * 60;// 1 час - день
            int BT = Y * ((X + 1) / 2);// следующий день
            int rs = 600 - T + BT;//спала раньше
            if (rs >= 7 * 60 && rs <= 9 * 60)
            {
                answer = true;
            }
            // end

            return answer;
        }
    }
}
