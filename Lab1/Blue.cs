namespace Lab1
{
    public class Blue
    {
        public bool Task1(int a, int b)
        {
            bool answer = false;

            // code here

            if ((a > 0 && b > 0) || (a < 0 && b < 0))
            {
                answer = true;
            }
            else
            {
                answer = false;
            }
            // end

            return answer;
        }
        public bool Task2(double d)
        {
            bool answer = false;

            // code here

            if (Math.Abs(d)-(Math.Floor(Math.Abs(d)))>0)
            {
                answer = true;
            }
            else
            {
                answer=false;
            }
            // end

            return answer;
        }
        public bool Task3(int a, int b)
        {
            bool answer = false;

            // code here

            if (b!=0 && a%b==0)
            {
                answer = true;
            }
            else
            {
                answer = false;
            }
            // end

            return answer;
        }
        public double Task4(double d, double f, double g)
        {
            double answer = 0;

            // code here

            double a = Math.Abs(d), b = Math.Abs(f), c = Math.Abs(g);
            if (a > b && a > c)
            {
                answer=d;
            }
            else if (b > a && b > c)
            {
                answer=f;
            }
            else
            {
                answer=g;
            }
            // end

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here

            if (x<=-1)
            {
                x = 0;
            }
            else if (x>-1 && x<=0)
            {
                x+=1;
            }
            else
            {
                x = 1;
            }
            answer = x;
            // end

            return answer;
        }
        public bool Task6(double circleS, double squareS)
        {
            bool answer = false;

            // code here

            double pi = Math.PI;
            double d = 2 * (Math.Sqrt(circleS / pi));
            double c = Math.Sqrt(squareS);
            if (d < c)
            {
                answer = true;
            }
            else if (circleS==0 && squareS==0)
            {
                answer = true;
            }
            else
            {
                answer = false;
            }
            // end

            return answer;
        }
        public double Task7(double d, double f)
        {
            int answer = 0;

            // code here
             
            if (Math.Abs(d)< Math.Abs(f))
            {
                if (d>0)
                {
                    answer = -1;
                }
            }
            else
            {
                if (f>0)
                {
                    answer = 1;
                }

            }
            // end

            return answer;
        }
        public bool Task8(int a, int b, int c)
        {
            bool answer = false;

            // code here

            int a1 = a / 2, b2 = b / 2, c2 = c / 2;
            int s = a1 + b2 + c2;
            if ((s % 3 == 0 || (s + 1) % 3 == 0) && s != 0)
            {
                answer = true;
            }
            else
            {
                answer = false;
            }
            // end

            return answer;
        }
    }
}




