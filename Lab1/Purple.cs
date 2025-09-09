namespace Lab1
{
    public class Purple
    {
        public bool Task1(int a, int b, int c)
        {
            bool answer = false;

            // code here 
            if ((a > 0 && b > 0 && c > 0) || (a < 0 && b < 0 && c < 0)) { answer = true; }
            // end

            return answer;
        }
        public bool Task2(int a, int b)
        {
            bool answer = false;

            // code here
            a = Math.Abs(a);
            b = Math.Abs(b);
            if (a < b)
            {
                a ^= b;
                b ^= a;
                a ^= b;
            }
            if (a >= b)
            {
                if (b == 0 && a != 0) answer = true;
                if (b != 0 && a % b == 0) answer = true;
            }
            // end

            return answer;
        }
        public bool Task3(int a, int b)
        {
            bool answer = false;

            // code here
            if (a > b)
            {
                a ^= b;
                b ^= a;
                a ^= b;
            }
            if (a * a * a == b || a * a == b) answer = true;
            // end

            return answer;
        }
        public double Task4(double d, double f, double g)
        {
            double answer = 0;

            // code here
            answer = f * f - 4 * d * g;
            // end

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here
            if (x <= (double)-1) answer = 1;
            if (x > (double)-1 && x <= (double)1) answer = -x;
            if (x > (double)1) answer = -1;
            // end

            return answer;
        }
        public bool Task6(double squareS, double circleS)
        {
            bool answer = false;

            // code here
            double r = Math.Sqrt(circleS / 3.14);
            double d = Math.Sqrt(squareS) * Math.Sqrt(2);
            if (d <= 2 * r) answer = true;
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
            } else
            {
                if (t)
                {
                    answer = 3;
                } else
                {
                    if (f)
                    {
                        answer = 5;
                    } else
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
            bool norm_year = (year % 4 != 0) || (year  % 100 == 0 && year % 400 != 0);
            int av = (pupils + 6) / 7;
            int money = av * salary + pupils * 5;
            if (norm_year && money <= bank) answer = true;
            // end

            return answer;
        }
    }
}

