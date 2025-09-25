namespace Lab1
{
    public class Purple
    {
        public bool Task1(int a, int b, int c)
        {
            bool answer = false;

            if ((a > 0 && b > 0 && c > 0) || (a < 0 && b < 0 && c  < 0) || (a == 0 && b == 0 && c == 0))
            {
                answer = true;
            }

            return answer;
        }
        public bool Task2(int a, int b)
        {
            bool answer = false;

            if ((b != 0 && a % b  == 0 )|| (a != 0 && b % a == 0))
            {
                answer = true;
            }

            return answer;
        }
        public bool Task3(int a, int b)
        {
            bool answer = false;

            if (Math.Pow(a, 2) == b || Math.Pow(a, 3) == b || Math.Pow(b, 2) == a|| Math.Pow(b, 3) == a)
            {
                answer = true;
            }

            return answer;
        }
        public double Task4(double d, double f, double g)
        {
            double answer = 0;

            answer = f * f - 4 * d * g; 

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            if (x <= -1)
            {
                answer = 1;
            }
            else if (-1 < x && x <= 1)
            {
                answer = -x;
            }
            else
            {
                answer = -1;
            }
            return answer;
        }
        public bool Task6(double squareS, double circleS)
        {
            bool answer = false;

            double r = Math.Sqrt(circleS / Math.PI);
            double s = Math.Sqrt(squareS);
            double d = Math.Sqrt(2) * s;
            if (d <= 2 * r)
            {
                answer = true;
            }

           

            return answer;
        }

        public int Task7(bool s, bool t, bool f)
        {
            int answer = 0;

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
            return answer;
        }
        public bool Task8(int year, int pupils, int salary)
        {
            bool answer = false;
            const int bank = 10000;
            double dels = pupils / 7.0;
            double avror = Math.Ceiling(dels);

            double pay = pupils * 5 + salary * avror;
            if (((year % 4 == 0) && (year % 100 != 0) || (year % 400 == 0)) != true && (pay <= bank))
            {
                answer = true;
            }

            return answer;
        }
    }
}