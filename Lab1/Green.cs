namespace Lab1
{
    public class Green
    {
public bool Task1(double d)
        {
            bool answer = false;

            // code here
            d = Math.Abs(d);
            if (d >= 1)
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
            if (d + f / 2 > 0)
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
            if (a + b > (Math.Abs(a) + Math.Abs(b)) / 2)
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
            int[] arr = [a, b, c];
            answer = arr.Max();
            // end

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here
            double g = Math.Abs(x);
            if (g > 1)
            {
                answer = 0;
            }
            else answer = g * g - 1;

            // end

            return answer;
        }
        public bool Task6(double x, double y)
        {
            bool answer = false;

            // code here
            if ((y >= 0) && (y <= x + 1) && (y <= -x + 1)) answer = true;
            else answer = false;
                // end
            return answer;
        }

        public bool Task7(int n)
        {
            bool answer = true;

            // code here
            if (n < 0) answer = false;
            else
            {
                if (n % 2 == 0) answer = false;
            }

            // end

            return answer;
        }
        public bool Task8(int X, int Y)
        {
            bool answer = false;

            // code here
            // Она встает в 7, ей надо ложиться в 00, либо в 10, считая что сейчас ложится в 4, минимум разницы - 4 часа = 240 мин., или 6 часов = 360 мин.
            int currentwakeup = 14 * 60;
            int currentgosleep = 4 * 60;
            currentwakeup -= X * 60;
            currentwakeup = Math.Clamp(currentwakeup, 7 * 60, 14 * 60);
            currentgosleep -= ((X / 2) + 1) * Y;
            int sleeptime = currentwakeup - currentgosleep;
            System.Console.WriteLine(sleeptime);
            if (((sleeptime >= 7 * 60) && (sleeptime <= 9 * 60) && currentwakeup == 7 * 60)) answer = true;

            // end
            
            return answer;
        }
    }
}