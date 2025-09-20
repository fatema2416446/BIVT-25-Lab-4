namespace Lab1
{
    public class Purple
    {
        public bool Task1(int a, int b, int c)
        {
            bool answer = false;

            answer = (a > 0 && b > 0 && c > 0) || (a < 0 && b < 0 && c < 0) || ( a == b && b == c && c == 0);

            return answer;
        }
        public bool Task2(int a, int b)
        {
            bool answer = false;

            answer = ((b != 0) && (Math.Abs(a) % Math.Abs(b) == 0)) || ((a != 0) && (Math.Abs(b) % Math.Abs(a) == 0));

            return answer;
        }
        public bool Task3(int a, int b)
        {
            bool answer = false;

            answer = (Math.Pow(a, 2) == b) || (Math.Pow(b, 2) == a) || (Math.Pow(a, 3) == b) || (Math.Pow(b, 3) == a);

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

            if (x <= -1)
            {
                answer = 1;
            }
            else if (x > 1)
            {
                answer = -1;
            }
            else
            {
                answer = -x;
            }

            return answer;
        }
        public bool Task6(double squareS, double circleS)
        {
            bool answer = false;

            double radius2 = circleS / Math.PI;
            double diagonal = squareS * 2;
            answer = (Math.Sqrt(radius2) * 2) >= Math.Sqrt(diagonal);

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

            int avroraCount = ((pupils + 6) / 7);
            answer = ((((year % 4 ==0) && (year % 100 != 0)) || (year % 400 == 0)) == false) && ((pupils * 5 + avroraCount * salary) <= bank);
            return answer;
        }
    }
}