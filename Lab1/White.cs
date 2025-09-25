namespace Lab1
{
    public class White
    {
        public bool Task1(double d)
        {
            bool answer = false;

            // code here
            if (d > 0)
            {
                answer = true;
            }
            else
            {
                answer = false;
            }
            Console.WriteLine(answer);
                // end

                return answer;
        }
        public bool Task2(int n)
        {
            bool answer = false;

            // code here
            if (n % 2 == 0)
            {
                answer = true;
            }
            else
            {
                answer = false;
            }
            Console.WriteLine(answer);
            // end

            return answer;
        }
        public int Task3(int a, int b)
        {
            int answer = 0;

            // code here
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;   
            }
            // end

            return answer;
        }
        public double Task4(double d, double f)
        {
            double answer = 0;

            // code here
            if (Math.Abs(d) > Math.Abs(f))
            {
                return(f);
            }
            else
            {
                return (d);
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
                return (1);
            }
            else
            {
                return(x);
            }
            // end

            return answer;
        }
        public bool Task6(double x, double y, double r)
        {
            bool answer = false;

            // code here
            if (Math.Abs(Math.Pow(x, 2) + Math.Pow(y, 2) - Math.Pow(r, 2)) <= Math.Pow(10, -4))
            {
                answer = true;
            }
            else
            {
                answer = false;
            }
            Console.WriteLine(answer);
                // end

                return answer;
        }

        public bool Task7(int n)
        {
            bool answer = false;

            // code here
            int s = n * n;
            if ((s - n) > (2 * n))
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
                answer = false;
            }
            Console.WriteLine(answer);
                // end

                return answer;
        }
        public bool Task8(double L, int T, int M)
        {
            bool answer = false;

            // code here
            if (L <= 30 && T + M >= 5 && M % 2 == 0)
            {
                answer = true;
            }
            Console.WriteLine(answer);
            // end

            return answer;
        }
    }
}
