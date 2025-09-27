namespace Lab1
{
    public class Purple
    {
        public bool Task1(int a, int b, int c)
        {
            bool answer = false;

            // code here
            int a1 = Math.Sign(a);
            int b1 = Math.Sign(b);
            int c1 = Math.Sign(c);
            if (a1 == b1 && b1 == c1)
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
        public bool Task2(int a, int b)
        {
            bool answer = false;

            // code here
            if (a == 0 || b == 0)
            {
                answer = true;
            }
            else
            {
                if (a % b == 0 || b % a == 0)
                {
                    answer = true;
                }
            }
            // end

            return answer;
        }
        public bool Task3(int a, int b)
        {
            bool answer = false;

            // code here
            if (Math.Pow(a, 2) == b || Math.Pow(b, 2) == a || Math.Pow(a, 3) == b || Math.Pow(b, 3) == a)
            { 
                answer = true;
            }

            // end

            return answer;
        }
        public double Task4(double d, double f, double g)
        {
            double answer = 0;

            // code here
            answer = Math.Pow(f, 2) - 4 * d * g;

            // end

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here
            if (x <= -1)
            {
                answer = 1;
            }
            if (-1 < x && x <= 1)
            {
                answer = x * (-1);
            }
            if (x > 1)
            {
                answer = -1;
            }

            // end

                return answer;
        }
        public bool Task6(double squareS, double circleS)
        {
            bool answer = false;

            // code here
            double R_t = Math.Pow(4 / (3 * Math.Pow(3, 0.5)) * squareS, 0.5);
            double R_c = Math.Pow(circleS / Math.PI, 0.5);
            if (R_t < R_c)
            {
                answer = true;
            }


            // end

            return answer;
        }

        public int Task7(bool s, bool t, bool f)
        {
            int answer = 0;

            // code here
            if (s)
            {
                if (t)
                {
                    answer = 6;
                }
                else
                {
                    if (f)
                    {
                        answer = 10;
                    }
                    else
                    {
                        answer = 2;
                    }
                }
            }
            else
            {
                if (t)
                {
                    answer = 3;
                }
                else
                {
                    if (f)
                    {
                        answer = 5;
                    }
                    else
                    {
                        answer = 1;
                    }
                }
            }
            


            // end

            return answer;
        }
        public bool Task8(int year, int pupils, int salary)
        {
            bool answer = false;
            const int bank = 10000;
            int avrors = pupils / 7;
            if (pupils % 7 != 0)
            {
                avrors += 1;
            }
            bool ves = false;
            int total_sum = avrors * salary + pupils * 5;
            if (year % 400 == 0)
            {
                ves = true;
            }
            else
            {
                if (year % 100 == 0)
                {
                    ves = false;
                }
                else
                {
                    if (year % 4 == 0)
                    {
                        ves = true;
                    }
                }


            }
            if (!ves)
            { 
                if (total_sum <= bank)
                {
                    answer = true;
                }
            }

            // code here

            // end

            return answer;
        }
    }
}