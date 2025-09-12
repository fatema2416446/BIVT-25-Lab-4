namespace Lab1
{
    public class Purple
    {
        public bool Task1(int a, int b, int c)
        {
            bool answer = false;

            // code here
            int aSign = Math.Sign(a);
            int bSign = Math.Sign(b);
            int cSign = Math.Sign(c);
            answer = ((aSign == bSign) && (bSign == cSign));
            // end

            return answer;
        }
        public bool Task2(int a, int b)
        {
            bool answer = false;

            // code here
            if (b != 0) answer = (a % b == 0) || answer;
            if (a != 0) answer = (b % a == 0) || answer;
            // end

            return answer;
        }
        public bool Task3(int a, int b)
        {
            bool answer = false;

            // code here
            answer = ((Math.Abs(a) == Math.Sqrt(b)) || (a == Math.Cbrt(b))) || answer;
            answer = ((Math.Abs(b) == Math.Sqrt(a)) || (b == Math.Cbrt(a))) || answer;
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
            } else if (x > 1)
            {
                answer = -1;
            } else
            {
                answer = -x;
            }
            // end

            return answer;
        }
        public bool Task6(double squareS, double circleS)
        {
            bool answer = false;

            // code here
            double squareSide = Math.Sqrt(squareS);
            double circleDiameter = Math.Sqrt(circleS / Math.PI) * 2;
            answer = ((Math.Sqrt(2) * squareSide) <= circleDiameter);
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
                } else
                {
                    if (f)
                    {
                        answer = 10;
                    } else
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
            double students = pupils;
            int auroras = (int)Math.Ceiling(students / 7.0);
            int aurorasTotal = auroras * salary;
            int studentTotal = 5 * pupils;
            int total = aurorasTotal + studentTotal;
            bool isLeapYear = (
                (year % 400 == 0) || ((year % 4 == 0) && (year % 100 != 0))
            );
            if ((bank - total > 0) && (!isLeapYear)) answer = true;
            // end

            return answer;
        }
    }
}
