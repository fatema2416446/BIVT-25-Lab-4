namespace Lab1
{
    public class Blue
    {
        public bool Task1(int a, int b)
        {
            bool answer = false;

            // code here
            answer = (a==0 && b==0) || (a!=0 && b!=0 && a>0 == b>0);
            // end

            return answer;
        }
        public bool Task2(double d)
        {
            bool answer = false;

            // code here
            answer = (d - Math.Floor(d)) > 0.0001;
            // end

            return answer;
        }
        public bool Task3(int a, int b)
        {
            bool answer = false;

            // code here
            answer = (b!=0 && a % b == 0);
            // end

            return answer;
        }
        public double Task4(double d, double f, double g)
        {
            double answer = 0;

            // code here
            if (d * d > f * f)
            {
                if (d*d > g*g) answer = d;
                else answer = g;
            }
            else if (f * f > g * g) answer = f;
            else answer = g;
            
            // end

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here
            if (x <= -1) answer = 0;
            else if (x <= 0) answer = x + 1;
            else answer = 1;
            // end

            return answer;
        }
        public bool Task6(double circleS, double squareS)
        {
            bool answer = false;

            // code here
            answer = (Math.Pow(circleS / Math.PI, 0.5) <= Math.Pow(squareS, 0.5) / 2);
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
            else if(f > 0) answer = 1;
            // end

            return answer;
        }
        public bool Task8(int a, int b, int c)
        {
            bool answer = false;

            // code here
            int son1 = a / 2;
            int son2 = b / 2;
            int son3 = c / 2;
            
            double sum = son1 + son2 + son3;

            if ((sum % 3 == 0 || (sum + 1) % 3 == 0) && sum > 1 && sum / 3 <= a && sum / 3 <= b && sum / 3 <= c)
                answer = true;
            // end

            return answer;
        }
    }
}