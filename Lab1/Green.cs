namespace Lab1
{
    public class Green
    {
        public bool Task1(double d)
        {
            bool answer = false;

            d = 6.2;

            double m = Math.Abs(d);

            if (m >= 1)
            {
                answer = true;
            }
            else
            {
               answer = false;
            }


            return answer;
        }
        public bool Task2(double d, double f)
        {
            bool answer = false;

            d = 5.6;
            f = 2.3;
            double b = (d + f) / 2;
            if (b > 0)
            {
                answer = true;
            }
            

            return answer;
        }
        public bool Task3(int a, int b)
        {
            bool answer = false;

            a = 5;
            b = 2;
            double a1 = Math.Abs(a);
            double b1 = Math.Abs(b);
            double d = (a + b) / 2;
            if ((a + b) > d)
            {
                answer = true;
            }

            return answer;
        }
        public int Task4(int a, int b, int c)
        {
            int answer = 0;

            a = 2;
            b = 5;
            c = 54;
            if (a > b && a > c)
            {
                answer = a;
            }
            else if (b > a && b > c)
            {
                answer = b;
            }
            else
            {
                answer = c;
            }


            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;
            x = 0;
            double x1 = Math.Abs(x);
            double x2 = Math.Pow(x, 2);
            if (x1 > 0)
            {
                answer = 0;
            }
            else if (x1 <= 0)
            {
                answer = x2 - 1;
            }

            return answer;
        }
        public bool Task6(double x, double y)
        {
            bool answer = false;
            x = 1;
            y = 0;

            if (x < 0)
            {
                y = 1 + x;
            }
            else
            {
                y = 1 - x;
            }

            if (x >= -1 && x <= 1 && y >= 0 && y <= 1)
            {
                answer = true;
            }
            else
            {
                answer = false;
            }
           

            return answer;
        }

        public bool Task7(int n)
        {
            bool answer = true;
            n = 3;

            if (n < 0)

            {
                answer = false;
            }
            else if (n % 2 == 0)
            {
                answer = false;
            }
            else
            {
                answer = true;
            }

            return answer;
        }
        public bool Task8(int X, int Y)
        {
            bool answer = false;
            X = 10;
            Y = 30;
            int hours = 7;
            double a = 60 + (Y / 2.0);
            double daysneeded = (hours * 60) / a;
            if (X >= daysneeded)
            {
                answer = true;
            }
            else
            {
                answer = false;
            }

            return answer;
        }
    }
}
