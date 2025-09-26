namespace Lab1
{
    public class Green
    {
        public bool Task1(double d)
        {
            bool answer = false;

            // code here
            double k = Math.Abs(d);
            if (k >= 1)
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
        public bool Task2(double d, double f)
        {
            bool answer = false;

            // code here
            double sr = (d + f) / 2;
            if (sr > 0)
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
            int summ = a + b;
            int Sr = (Math.Abs(a) + Math.Abs(b)) / 2;
            if (summ > Sr)
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
            int Max1 = Math.Max(a, b);
            answer = Math.Max(Max1, c);
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
            else if (Math.Abs(x) <= 1)
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
            if (y < 0)
            {
                answer = false;
            }
            else if ((x < 0) && (y <= (x + 1)))
            {
                answer = true;
            }
            else if ((x >= 0) && (y <= (1 - x)))
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
            if (n >= 0)
            {
                if (n % 2 == 0)
                {
                    answer = false;
                }
            }
            else
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
            int SumY = 0;
            if (X >= 7)//7 дней нужно минимально, тк встает в 14 а надо в 7 и практика каждый день отнимает час
            {
                for (int i = 0; i < X; i++)
                {
                    if ((i % 2) == 0) { SumY += Y; }

                }
                if ((SumY >= 4 * 60) && (SumY <= 6 * 60))//ложится в 4 утра, а нужно в 22 или 24 вечера,тоесть разница 4-6 часов, соответственно нужно чтобы чай покарыл это время, но чай уменьшает на минуты, поэтому 4часа = 4*60 = 240 минут и с 6 аналогично
                    answer = true;
            }
            // end

            return answer;
        }
    }
}