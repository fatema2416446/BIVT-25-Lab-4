namespace Lab1
{
    public class Green
    {
        public bool Task1(double d)
        {
            bool answer = false;

            // code here
            if (d >= 1 || d <= -1)
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
            var sum = d + f;
            if (sum > 0)
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
        public bool Task3(int a, int b)
        {
            bool answer = false;

            // code here
            var sum = a + b;
            var AbsSum = Math.Abs(a) + Math.Abs(b);
            if (sum > (AbsSum / 2))
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
        public int Task4(int a, int b, int c)
        {
            int answer = 0;

            // code here
            int[] numbers = { a, b, c };
            answer = numbers.Max();
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
            if (x < 0)
            {
                if (y <= 1 + x && y >= 0)
                {
                    answer = true;
                }
            }
            else
            {
                if ( y <= 1 - x && y >= 0)
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
            if (X >= 7)
            {
                var OddDays = (X + 1) / 2;
                var SleepTime = 600 - 60 * 7 + Y * OddDays;

                if (420 <= SleepTime && SleepTime <= 540)
                {
                    answer = true;
                }
            }
            // end

            return answer;
        }
    }
}