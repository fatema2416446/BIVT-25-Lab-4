namespace Lab1
{
    public class Blue
    {
        public bool Task1(int a, int b)
        {
            bool answer = false;

            // code here
            if (a > 0 && b > 0) answer = true;
            if (a < 0 && b < 0) answer = true;
            // end

            return answer;
        }
        public bool Task2(double d)
        {
            bool answer = false;

            // code here
            double ost = d % 1;
            if (ost != 0) answer = true;
            // end

            return answer;
        }
        public bool Task3(int a, int b)
        {
            bool answer = false;

            // code here
            if (b != 0 && a % b == 0) answer = true;
            // end

            return answer;
        }
        public double Task4(double d, double f, double g)
        {
            double answer = 0;
            double cur = 0;
            // code here
            if (Math.Abs(d) > cur) { cur = Math.Abs(d); answer = d; }
            if (Math.Abs(f) > cur) { cur = Math.Abs(f); answer = f; }
            if (Math.Abs(g) > cur) { cur = Math.Abs(g); answer = g; }
            // end

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here
            if (x <= -1) answer = 0;
            else if (-1 < x && x <= 0) answer = x + 1;
            else answer = 1;
            // end

                return answer;
        }
        public bool Task6(double circleS, double squareS)
        {
            bool answer = false;

            // code here
            double r = Math.Sqrt(circleS / Math.PI);
            double a = Math.Sqrt(squareS);
            if (r <= a/2.0) answer = true;
            // end

            return answer;
        }

        public double Task7(double d, double f)
        {
            int answer = 0;

            // code here
            if (Math.Abs(d) < Math.Abs(f))
            {
                if (d > 0) answer = -1;
            }
            else if (f > 0) answer = 1;
                // end

                return answer;
        }
        public bool Task8(int a, int b, int c)
        {
            bool answer = false;

            // code here
            int s = a / 2 + b / 2 + c / 2;
            int piece = 0;
            if (s>=2)
            {
                if (s % 3 == 0 || (s + 1) % 3 == 0)
                {
                    if (s % 3 == 0) piece = s / 3;
                    else piece = (s + 1) / 3;
                    if (a >= piece && b >= piece && c >= piece) answer = true;
                }
            }
            // end

            return answer;
        }
    }
}