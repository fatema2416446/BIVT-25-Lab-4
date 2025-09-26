namespace Lab1
{
    public class Green
    {
        public bool Task1(double d)
        {
            bool answer = false;

            // code here
            answer = (Math.Abs(d) >= 1);
            // end
            
            return answer;
        }
        public bool Task2(double d, double f)
        {
            bool answer = false;

            // code here
            double sr_z = (d + f) / 2;
            answer = (sr_z > 0);
            // end

            return answer;
        }
        public bool Task3(int a, int b)
        {
            bool answer = false;

            // code here
            double sum = (double)a + b;
            double sr_z = (double)Math.Abs(a) + Math.Abs(b) / 2;
            answer = (sum > sr_z);
            // end

            return answer;
        }
        public int Task4(int a, int b, int c)
        {
            int answer = 0;

            // code here
            int maxx = Math.Max(a, b);
            answer = Math.Max(c, maxx);
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
                answer = Math.Pow(x, 2) - 1;
            }
            // end

            return answer;
        }
        public bool Task6(double x, double y)
        {
            bool answer = false;

            // code here
            if ((x >= 0 && y <= 1 - x && y >= 0) || (x < 0 && y <= 1 + x && y >= 0))
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
            else
            {
                if ((double)n % 2.0 == 0)
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
            int a;
            int min;
            if (X % 2 == 0)
            {
                a = X / 2; // кол-во дней приема чая
            }
            else
            {
                a = (X / 2) + 1;
            }
            min = a * Y; // на сколько минут будет ложиться раньше с помощью чая
            if (X >= 7 && min >= 240 && min <= 360)
            {
                answer = true;
            }
            // end

            return answer;
        }
    }
}