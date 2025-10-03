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
             double tbc = (d + f) / 2;
            if (tbc >= 0)
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
            int sum = a + b;
            int absA = Math.Abs(a);
            int absB = Math.Abs(b);
            double tbc = (absA + absB) / 2.0;
            if (sum > tbc)
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
            int max = a;
            if(b>max)
            {
                max = b;
            }

            if (c > max)
            {
                max = c;
            }

            answer = max;

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
            if (y <= 1 + x && y <= 1 - x && y >= 0)
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
            float startNight = 4 * 60;
            float startMorning = 14 * 60;

            for (int i = 1; i <= X; i++)
            {
                if (i % 2 != 0)
                    startNight -= Y;

                startMorning -= 60;
                if (startMorning < 7 * 60)
                    startMorning = 7 * 60;
            }

            if (7 <= (startMorning - startNight) / 60 && (startMorning - startNight) / 60 <= 9)
                answer = true;


            // end

            return answer;
        }
    }

}

