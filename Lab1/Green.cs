namespace Lab1
{
    public class Green
    {
        public bool Task1(double d)
        {
            bool answer = false;

            // code here
            if (Math.Abs(d) >= 1)
            {
                answer = true;
            }
            // end

            return answer;
        }
        public bool Task2(double d, double f)
        {
            bool answer = false;

            // code here
            if ((d+f)/2>0)
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
            if (a + b > (Math.Abs(a)+Math.Abs(b))/2)
            {
                answer = true;
            }
            // end

            return answer;
        }
        public int Task4(int a, int b, int c)
        {
            int answer = 0;

            // code here
            int M;
            if (a>=b)
            {
                M = a;
            }
            else
            {
                M = b;
            }
            if (c > M)
            {
                M = c;
            }
            answer = M;
                // end

                return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here
            if (Math.Abs(x)>1)
            {
                answer = 0;
            }
            else
            {
                answer = Math.Pow(x, 2) - 1;
            }
                // end

                return answer;
        }
        public bool Task6(double x, double y)
        {
            bool answer = false;

            // code here
            if (x < 0 && y < (1 + x) && y >= 0)
            {
                answer = true;
            }
            else
            {
                if (x >=0 && y < (1 - x) && y >= 0)
                {
                    answer = true;
                }
            }
                // end

                return answer;
        }

        public bool Task7(int n)
        {
            bool answer = true;

            // code here
            if (n < 0)
            {
                answer = false;
            }
            else
            {
                if (n % 2 == 0)
                {
                    answer = false;
                }
            }
                // end

                return answer;
        }
        public bool Task8(int X, int Y)
        {
            bool answer = false;

            // code here
            int start = 4 * 60; // начало сна
            int end = 14 * 60; //окончаие сна
            for (int i = 0; i < X; i++)
            {
                if (i % 2 == 0) //выпила чай
                {
                    start -= Y; //заснуть на Y раньше
                }
             if (end > 7 * 60)
                end -= 60; //проснуться на час раньше 
            }
            if (start <= 0 && start >= -2 * 60 && end == 7 * 60)
                {
                    answer = true;
                }
            
            // end

            return answer;
        }
    }
}
