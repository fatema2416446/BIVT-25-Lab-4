namespace Lab1
{
    public class Blue
    {
        public bool Task1(int a, int b)
        {
            bool answer = false;

            // code here
            if ((a > 0 && b > 0) || (a < 0 && b < 0) || (a == 0 && b == 0)) answer = true;
            // end

            return answer;
        }
        public bool Task2(double d)
        {
            bool answer = false;

            // code here
            if (d != Math.Floor(d)) answer = true;
                // end

                return answer;
        }
        public bool Task3(int a, int b)
        {
            bool answer = false;

            // code here
            if (b != 0) 
            if (a % b == 0) answer = true;
            // end

            return answer;
        }
        public double Task4(double d, double f, double g)
        {
            double answer = 0;

            // code here
            if (Math.Abs(d) > Math.Abs(f) && Math.Abs(d) > Math.Abs(g)) answer = d; 
            if (Math.Abs(f) > Math.Abs(g) && Math.Abs(f) > Math.Abs(d)) answer = f; 
            if (Math.Abs(g) > Math.Abs(f) && Math.Abs(g) > Math.Abs(d)) answer = g;
            // end

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here
            if (x <= 1) answer = 0;
            if (-1 < x && x <= 0) answer = x + 1;
            if (x > 0) answer = 1;
            // end

            return answer;
        }
        public bool Task6(double circleS, double squareS)
        {
            bool answer = false;

            // code here
            circleS /= Math.PI;
            if (Math.Sqrt(circleS)*2 <= Math.Sqrt(squareS)) answer = true; 
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
            else if (f > 0) answer = 1; else answer = 0;
                // end

                return answer;
        }
        public bool Task8(int a, int b, int c)
        {
            bool answer = false;

            // code here
            a /= 2; b /= 2; c /= 2;
            if (c == 0) c++;
            if (a == b && b == c) answer = true;
            else if (c + 1 == a && a == b) answer = true; 
            //end

            return answer;
        }
    }
}
