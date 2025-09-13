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

            double average = (d + f) / 2;
            if (average > 0)
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

            // a + b  >  (|a| + |b|) / 2
            if ((a + b) * 2 > Math.Abs(a) + Math.Abs(b))
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

            answer = Math.Max(Math.Max(a, b), c);

            // end

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here

            if (Math.Abs(x) > 1)
            {
                answer = 0;
            }
            else
            {
                answer = x * x - 1;
            }

            // end

            return answer;
        }
        public bool Task6(double x, double y)
        {
            bool answer = false;

            // code here

            if (y >= 0 && y <= 1 + x && y <= 1 - x)
            {
                answer = true;
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
            else if (n % 2 == 0)
            {
                answer = false;
            }

            // end

            return answer;
        }
        public bool Task8(int X, int Y)
        {
            bool answer = false;

            // code here

            // нужно засыпать на 4-6 ч. раньше и просыпаться на 7 ч. раньше
            int tea_time_shift = (X + 1) / 2 * Y;
            int max_breath_time_shift = X * 60;
            if (4 * 60 <= tea_time_shift && tea_time_shift <= 6 * 60 && 
                max_breath_time_shift >= 7 * 60)
            {
                answer = true;
            }

            // end

            return answer;
        }
    }
}