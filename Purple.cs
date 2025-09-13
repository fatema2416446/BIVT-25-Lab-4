namespace Lab1
{
    public class Purple
    {
        public bool Task1(int a, int b, int c)
        {
            bool answer = false;
            if ((a > 0 && b > 0 && c > 0) || (a < 0 && b < 0 && c < 0) || (a == 0 && b == 0 && c == 0))
                answer = true;
            else
                answer = false;
            return answer;
        }
        public bool Task2(int a, int b)
        {
            bool answer = false;
            if(b == 0)
                answer = true;
            else if(a == 0)
                answer = true;
            else if (a % b == 0 || b % a == 0)
            {
                answer = true;
            }
            else 
                return answer;
            return answer;
        }
        public bool Task3(int a, int b)
        {
            bool answer = false;
            if((a > b && (Math.Pow(b, 2) == a || Math.Pow(b, 3) == a)) || (b > a && (Math.Pow(a, 2) == b || Math.Pow(a, 3) == b)))
                answer = true;
            else
                return answer;
            return answer;
        }
        public double Task4(double d, double f, double g)
        {
            double answer = 0;
            answer = Math.Pow(f, 2) - 4 * d * g;
            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;
            if (x > 1)
                answer = -1;
            else if (-1 < x && x <= 1)
                answer = -x;
            else if (x <= -1)
                answer = 1;
            return answer;
        }
        public bool Task6(double squareS, double circleS)
        {
            bool answer = false;
            if (squareS / 2 <= circleS / Math.PI)
                answer = true;
            return answer;
        }
        public int Task7(bool s, bool t, bool f)
        {
            int answer = 0;
            if(s == true)
            {
                if(t == true)
                {
                    answer = 6;
                }
                else
                {
                    if(f == true)
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
                if(t == true)
                {
                    answer = 3;
                }
                else
                {
                    if(f == true)
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
            if (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0))
            {
                answer = false;
            }
            else
            {
                if ((Math.Ceiling(pupils / 7.0) * salary + pupils * 5 <= bank))
                {
                    answer = true;
                }
                else
                {
                    answer = false;
                }
            }
            return answer;
        }
    }
}