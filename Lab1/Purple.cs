namespace Lab1
{
    public class Purple
    {
        public bool Task1(int a, int b, int c)
        {
            bool answer = false;

            answer = ((a > 0 && b > 0 && c > 0) || (a < 0 && b < 0 && c < 0));
                

            return answer;
        }
        public bool Task2(int a, int b)
        {
            bool answer = false;

            if ((a == 0 || b == 0))
            {
                if (a == b)
                    return false;

                return true;
            }
            else if (a % b == 0 || b % a == 0)
                return true;

            return false;
        }
        
        public bool Task3(int a, int b)
        {
            bool answer = false;
            answer = ((a == (b * b)) || (b == (a * a)) || (a == (b * b * b)) || (b == (a * a * a)));
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
                return 1;
            else if (x > 1)
                return - 1;

            return -x;            
        }
        public bool Task6(double squareS, double circleS)
        {
            bool answer = false;
            var x = Math.Sqrt(circleS / Double.Pi);
            var y = Math.Sqrt(squareS);

            if (2 * x >= y * Math.Sqrt(2))
                return true;
            return answer;
        }

        public int Task7(bool s, bool t, bool f)
        {
            int answer = 0;

            if (s)
                if (t)
                    answer = 6;
                else if (f)
                    answer = 10;
                else
                {
                    answer = 2;
                }
            else
            {
                if (t)
                    answer = 3;
                else
                {
                    if (f)
                        answer = 5;
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
            int x = (pupils - 1) / 7 + 1;
            const int bank = 10000;
            if ((year % 400 == 0) || ((year % 4 == 0) && (year % 100 != 0)))
                return false;
            if ((x * salary + 5 * pupils <= bank))
                return true;
                

            return answer;
        }
    }
}