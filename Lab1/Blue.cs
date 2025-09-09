using System.Data.SqlTypes;

namespace Lab1
{
    public class Blue
    {
        public bool Task1(int a, int b)
        {
            bool answer = false;

            // code here
            if (a > 0 && b > 0)
            { 
                answer = true;
            }
            else if (a < 0 && b < 0)
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
            if ((d - Math.Truncate(d) > 0.0001) | (d - Math.Truncate(d) < -0.0001))
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
            if (b != 0)
            {
                if (a % b == 0)
                {
                    answer = true;
                }
            }

            // end

            return answer;
        }
        public double Task4(double d, double f, double g)
        {
            double answer = 0;

            // code here
            double a = Math.Abs(d);
            double b = Math.Abs(f);
            double c = Math.Abs(g);
            if (a > b && a > c)
            {
                answer = d;
            }
            else if (b > a && b > c)
            {
                answer = f;
            }
            else if (c > a && c > b)
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
            else if (-1 < x && x <= 0)
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
            if (circleS/3.14 <= squareS/4)
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
            else
            {
                if (f > 0)
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
            int beg_1 = a / 2;
            int beg_2 = b / 2;
            int beg_3 = c / 2;
            int money = beg_1 + beg_2 + beg_3;
            if (money % 3 == 0)
            {

                if (money/3 >= 1 && money / 3 <= a && money / 3 <= b && money / 3 <= c)
                {
                    answer = true;
                }
            }
            else if ((money + 1) % 3 == 0)
            {
                if ((money + 1) / 3 >= 1 && (money + 1) / 3 <= a && (money + 1) / 3 <= b && (money + 1) / 3 <= c)
                {
                    answer = true;
                }
            }
                // end

                return answer;
        }
    }
}
