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
            
            Console.WriteLine(n);
            // end

            return answer;
        }
        public int Task3(int a, int b)
        {
            int answer = 0;

            // code here
            if (a > b)
            {
                answer = a;
            }
            else
            {
                answer = b;
            }
                // end

                return answer;
        }
        public double Task4(double d, double f)
        {
            double answer = 0;

            // code here
            if (Math.Abs(d) <= Math.Abs(f))
            {
                answer = d;
            }
            else
            {
                answer = f;
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
            else if (Math.Abs(x) <= 1)
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
            double a = x * x + y * y;
            double b = r * r;
            answer = (Math.Abs(a - b) <= 0.0001);
            
                // end

                return answer;
        }

        public bool Task7(int n)
        {
            

            // code here

            int s = n * n;
            bool answer = false;
            if ((s - n) > 2 * n)
            {
                if (n % 2 == 0)
                {
                    answer = true;
                }
                else
                {
                    return answer;
                }
            }
            else
            {
               
            }
                // end

                return answer;
        }
        public bool Task8(double L, int T, int M)
        {
            bool answer = false;

            // code here

            if ((L <= 30) && (T + M > 5) && (M % 2 == 0))
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
