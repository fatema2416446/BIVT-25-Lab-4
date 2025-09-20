namespace Lab1
{
    public class Blue
    {
        public bool Task1(int a, int b)
        {
            bool answer = false;

            answer = ((a > 0) && (b > 0)) || ((a < 0) && (b < 0)) || ((a == 0) && (b == 0));

            return answer;
        }
        public bool Task2(double d)
        {
            bool answer = false;
            if ((int)(Math.Abs(d)*10000) - 10000*(int)Math.Abs(d) > 0)
            {
                answer = true;
            }

            return answer;
        }
        public bool Task3(int a, int b)
        {
            bool answer = false;

            if (b != 0 && Math.Abs(a) % Math.Abs(b) == 0)
            {
                answer = true;
            }

            return answer;
        }
        public double Task4(double d, double f, double g)
        {
            double answer = 0;
            double ma = Math.Max(Math.Max(Math.Abs(d), Math.Abs(f)), Math.Abs(g));
            if (ma == Math.Abs(d))
            {
                answer = d;
            }
            else if (ma == Math.Abs(f))
            {
                answer = f;
            }
            else
            {
                answer = g;
            }
            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            if (x <= -1)
            {
                answer = 0;
            }
            else if ((x > -1) && (x <= 0))
            {
                answer = x + 1;
            }
            else
            {
                answer = 1;
            }
            return answer;
        }
        public bool Task6(double circleS, double squareS)
        {
            bool answer = false;

            answer = 2 * Math.Sqrt(circleS / Math.PI) <= Math.Sqrt(squareS);

            return answer;
        }

        public double Task7(double d, double f)
        {
            int answer = 0;
            if ((Math.Abs(d) < Math.Abs(f)) && (d > 0))
            {
                answer = -1;
            }
            else if ((Math.Abs(d) > Math.Abs(f)) && (f > 0))
            {
                answer = 1;
            }
            return answer;
        }
        public bool Task8(int a, int b, int c)
        {
            bool answer = false;

            int sum = (int)(a / 2) + (int)(b / 2) + (int)(c / 2);
            if (sum <= c*3 && sum >= 2)
            {
                if (sum % 3 == 0 || sum % 3 == 2)
                {
                    answer = true;
                }
            }

            return answer;
        }
    }
}