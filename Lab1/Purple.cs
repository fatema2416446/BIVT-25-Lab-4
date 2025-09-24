namespace Lab1
{
    public class Purple
    {
        public bool Task1(int a, int b, int c)
        {
            bool answer = false;

            // code here
            if ((a * b > 0) && (a * c > 0) && (b * c > 0))
            {
                answer = true;
            }
            // end

            return answer;
        }
        public bool Task2(int a, int b)
        {
            bool answer = false;

            // code here
            if (a == 0 || b == 0 || Math.Max(Math.Abs(a), Math.Abs(b)) % Math.Min(Math.Abs(a), Math.Abs(b)) == 0)
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
            if ((Math.Max(a, b) == Math.Pow(Math.Min(a, b), 2)) || (Math.Max(a, b) == Math.Pow(Math.Min(a, b), 3)))
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
            answer = (Math.Pow(f, 2) - 4 * d * g);
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
            else if (-1 < x && x <= 1)
            {
                answer = -1 * x;
            }
            else
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
            double a = Math.Pow(squareS, 0.5);
            double r = Math.Pow(circleS / Math.PI, 0.5);
            if (a * Math.Pow(2, 0.5) <= 2 * r)
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
            if (s == true)
            {
                if (t == true)
                {
                    answer = 6;
                }
                else
                {
                    if (f == true)
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
                if (t == true)
                {
                    answer = 3;
                }
                else
                {
                    if (f == true)
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
            // code here
            int summa = 0;
            if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
            {
                answer = false;
            }
            else
            {
                summa += pupils * 5;
                summa += Convert.ToInt32(Math.Ceiling(pupils / 7.0)) * salary;
                if (summa <= 10000)
                {
                    answer = true;
                }
            }
            // end

                return answer;
        }
    }
}
