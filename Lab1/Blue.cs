namespace Lab1
{
    public class Blue
    {
        public bool Task1(int a, int b)
        {
            bool answer = false;

            // code here
            answer = (a > 0 && b > 0) || (a < 0 && b < 0);
            // end

            return answer;
        }
        public bool Task2(double d)
        {
            bool answer = false;

            // code here
            answer = Math.Abs(d - Math.Round(d)) >= 1e-4;
            // end

            return answer;
        }
        public bool Task3(int a, int b)
        {
            bool answer = false;

            // code here
            if (b != 0)
            {
                answer = a % b == 0;
            }
            // end

            return answer;
        }
        public double Task4(double d, double f, double g)
        {
            double answer = 0;

            // code here
            double absd = Math.Abs(d);
            double absf = Math.Abs(f);
            double absg = Math.Abs(g);
            if (absd > absf && absd > absg)
            {
                answer = d;
            }
            else if (absf > absd && absf > absg)
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
            else if (x > -1 && x <= 0)
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
            answer = (2 * Math.Sqrt(circleS / Math.PI)) <= Math.Sqrt(squareS);
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
            int mida = a / 2;
            int midb = b / 2;
            int midc = c / 2;
            int coins = mida + midb + midc;
            if (coins == 0)
            {
                answer = false;
            }
            else if (coins % 3 == 0 || (coins + 1) % 3 == 0)
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
