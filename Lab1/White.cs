namespace Lab1
{
    public class White
    {
        public bool Task1(double d)
        {
            bool answer = false;

            // code here

            answer = d > 0;

            // end

            return answer;
        }
        public bool Task2(int n)
        {
            bool answer = false;

            // code here

            answer = n % 2 == 0;

            // end

            return answer;
        }
        public int Task3(int a, int b)
        {
            int answer = 0;

            // code here

            answer = Math.Max(a, b);

            // end

            return answer;
        }
        public double Task4(double d, double f)
        {
            double answer = 0;

            // code here

            if (Math.Abs(d) > Math.Abs(f))
            {
                answer = f;
            }
            else
            {
                answer = d;
            }

            // end

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here

            if (Math.Abs(x) > 1)
            {
                answer = 1;
            }
            else
            {
                answer = x;
            }

            // end

            return answer;
        }
        public bool Task6(double x, double y, double r)
        {
            bool answer = false;

            // code here

            /*
            double deviation = Math.Round(Math.Abs(x * x + y * y - r * r), 8);
            double eps = 1e-6;
            answer = deviation <= eps;
            */

            // ! тест x = 3, y = 0.01, r = 3 -> deviation получается 0.0001 > 1e-6, 
            // но ожидаемый ответ - true

            // end

            return answer;
        }

        public bool Task7(int n)
        {
            bool answer = false;

            // code here

            int s = n * n;
            if (s - n > n && n % 2 == 0)
            {
                answer = true;
            }

            // end

            return answer;
        }
        public bool Task8(double L, int T, int M)
        {
            bool answer = false;

            // code here

            if (L <= 10 * 3 && T + M >= 5 && M % 2 == 0)
            {
                answer = true;
            }

            // end

            return answer;
        }
    }
}