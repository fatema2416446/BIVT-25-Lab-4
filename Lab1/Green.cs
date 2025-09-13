namespace Lab1
{
    public class Green
    {
        public bool Task1(double d)
        {
            bool answer = false;

            // code here
            if (Math.Abs(d)>=1)
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
            if (((d + f) / 2) > 0)
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
            double sum_ab = a + b;
            double sr_ab = (Math.Abs(a) + Math.Abs(b)) / 2;
            if (sum_ab>sr_ab)
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
            answer = Math.Max(a, b);
            answer = Math.Max(answer, c);
            // end

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here
            if (Math.Abs(x)> 1)
            {
                answer = 0;
            }
            else
            {
                answer = Math.Pow(x,2) -1;
            }
                // end

                return answer;
        }
        public bool Task6(double x, double y)
        {
            bool answer = false;

            // code here
            if (x >= 0 && x <= 1)
            {
                if ((y >= 0) && (y <= (1 - x)))
                {
                    answer = true;
                }
                else
                {
                    answer = false;
                }
            }
            else if (x < 0 && x >= -1)
            {
                if ((y >= 0) && (y <= (1 + x)))
                {
                    answer = true;
                }
                else
                {
                    answer = false;
                }
            }
            
            // end

            return answer;
        }

        public bool Task7(int n)
        {
            bool answer = true;

            // code here
            if (n<0)
            {
                answer = false;
            }
            else
            {
                if (n%2 == 0)
                {
                    answer = false;
                }
                else if (Math.Abs(n) %2 == 0)
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
            double tea_hours = (double)(((X / 2) + (X % 2)) * Y) / 60;
            double gym_hours = X;
            if (gym_hours >= 3)
            {
                gym_hours = 7;

                if ((4 - tea_hours + gym_hours) <= 7 && (4 - tea_hours + 9) >= 7)
                {
                    answer = true;
                    Console.WriteLine((4 - tea_hours + gym_hours));
                }
            }
            else if (gym_hours > 0 && gym_hours < 3)
            {
                gym_hours = 10 - gym_hours;
                if ((4 - tea_hours + gym_hours) <= 7 && (4 - tea_hours + 9) >= 7)
                {
                    answer = true;
                    Console.WriteLine(1);
                }
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

