namespace Lab1
{
    public class Purple
    {
        public bool Task1(int a, int b, int c)
        {
            bool answer = false;

            // code here
            if ((a==b && a==c) || (a*b>0 && a*c>0))
                answer = true;
            // end

            return answer;
        }
        public bool Task2(int a, int b)
        {
            bool answer = false;

            // code here
            if (a == 0 || b == 0)
                answer = true;
            else
            {
                int a1 = Math.Max(Math.Abs(a), Math.Abs(b));
                int b1 = Math.Min(Math.Abs(a), Math.Abs(b));
                if (a1 % b1 == 0)
                    answer = true;
            }
            if (a==0 && b==0)
                answer = false;
            // end

            return answer;
        }
        public bool Task3(int a, int b)
        {
            bool answer = false;

            // code here
            int a1 = Math.Max(a, b);
            int b1 = Math.Min(b, a);
            if (Math.Pow(b1,2)==a1 || Math.Pow(b1,3)==a1)
                answer = true;
            // end

            return answer;
        }
        public double Task4(double d, double f, double g)
        {
            double answer = 0;

            // code here
            answer = Math.Pow(f, 2) - 4 * d * g;
            // end

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here
            if (x<=-1)
                answer = 1;
            else if (x>-1 && x<=1)
                answer = x*(-1);
            else if (x>1)
                answer = -1;
                // end

                return answer;
        }
        public bool Task6(double squareS, double circleS)
        {
            bool answer = false;

            // code here
            if (squareS<=2*circleS/Math.PI)
                answer = true;
            // end

            return answer;
        }

        public int Task7(bool s, bool t, bool f)
        {
            int answer = 0;

            // code here
            if (s)
            {
                if (t)
                {
                    answer = 6;
                }
                else
                {
                    if (f)
                        answer = 10;
                    else
                        answer = 2;
                }
            }
            else
            {
                if (t)
                {
                    answer = 3;
                }
                else
                {
                    if (f)
                        answer = 5;
                    else
                        answer = 1;
                }
            }
                // end

                return answer;
        }
        public bool Task8(int year, int pupils, int salary)
        {
            bool answer = false, y=true;
            const int bank = 10000;
            // code here
            if (year % 4 == 0)
            {
                y = false;
                if (year%100==0)
                {
                    y = true;
                    if (year%400==0)
                        y=false;
                }
            }
            if ((Math.Ceiling(pupils/7.0)*salary+pupils*5)<=bank && y)
                answer = true;
            // end

            return answer;
        }
    }
}
