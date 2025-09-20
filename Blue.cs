namespace Lab1
{
    public class Blue
    {
        public bool Task1(int a, int b)
        {
            bool answer = false;

            // code here
            if ((a<0 && b <0) || (a>0 && b>0))
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
            if (Math.Abs(d) - Math.Floor(Math.Abs(d))> 0)
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
            if (b != 0 && a %b == 0)
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
            if (Math.Abs(d) > Math.Abs(f) && Math.Abs(d)> Math.Abs(g))
            {
                answer = d;
            }
            else if(Math.Abs(f) > Math.Abs(d) && Math.Abs(f) > Math.Abs(g))
            {
                answer = f;
            }
            else
            {
                answer = g;
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
            else if(x<= 0 && x >-1)
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
            double d = Math.Sqrt(circleS/ Math.PI) * 2; // диаметр круга
            double a = Math.Sqrt(squareS); // сторона квадрата 
            if (d <= a)
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
            double a1 = a / 2;
            double b1 = b / 2;
            double c1 = c / 2;
            double s = a1 + b1 + c1;
            if (s % 3 == 0 && s != 0)
            {
                answer = true;
            }
            else if ((s+1)%3 ==0)
            {
                answer = true;
            }
                // end

                return answer;
        }
    }
}