namespace Lab1
{
    public class Green
    {
        public bool Task1(double d)
        {
            bool answer = false;

            

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
            
           
            if (Math.Abs(x) > 1)
            {
                answer = 0;
            }
            else if (Math.Abs(x) <= 1)
            {
                answer = Math.Pow(x,2) - 1;
            }

            return answer;
        }
        public bool Task6(double x, double y)
        {
            bool answer = false;


            bool inside;



            if (y >= 0 && y <= 1 - Math.Abs(x))
            {
                inside = true;
            }
            else
            {
                inside = false;
            }
            double f;
            if (x < 0)
            {
                f = 1 + x;
            }
            else
            {
                f = -x;
            }

            if (inside)
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

            int hours = Y;
            for (int i = 0; i < X; i++)
            {

                if (i % 2 == 1)
                {
                    hours += Y;
                }
            }

            if ((hours >= 240) && (hours <= 360) && X >= 7)
            {
                answer = true;
            }

            return answer;
        }
    }
}
