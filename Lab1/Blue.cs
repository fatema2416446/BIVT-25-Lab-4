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
            double zxc = Math.Abs(d % 1);
            answer = zxc > 0.0001;

            // end

            return answer;
        }
        public bool Task3(int a, int b)
        {
            bool answer = false;

            // code here
            if (b != 0 && a % b == 0)
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
            double absD = Math.Abs(d);
            double absF = Math.Abs(f);
            double absG = Math.Abs(g);

            if (absD >= absF && absD >= absG)
            {
                answer = d;
            }
            else if (absF >= absD && absF >= absG)
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
                answer = 0;
            else if (x <= 0)
                answer = x + 1;
            else
                answer = 1;
            // end

            return answer;
        }
        public bool Task6(double circleS, double squareS)
        {
            bool answer = false;

            // code here
            double circleD = 2 * Math.Sqrt(circleS / Math.PI);
            double squareD = Math.Sqrt(squareS);

            answer = circleD <= squareD;
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
                else
                {
                    answer = 0;
                }
            }

            else

            {
                if (f > 0)
                {
                    answer = 1;
                }
                else
                {
                    answer = 0;
                }
            }
            // end

            return answer;
        }
        public bool Task8(int a, int b, int c)
        {
            bool answer = false;

            // code here
            int a1 = a / 2;
            int b1 = b / 2;
            int c1 = c / 2;

            int sum = a1 + b1 + c1;
            int summa = sum / 3;
            if (sum % 3 == 0 && sum >= 3)

            {
                answer = true;
            }
            else if (sum % 3 != 0)
            {
                if (sum - ((summa + 1) * 3 - 1) == 0)
                {
                    answer = true;
                }
            }

            // end

            return answer;
        }
    }
}

