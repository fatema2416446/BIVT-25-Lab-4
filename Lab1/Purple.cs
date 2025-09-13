namespace Lab1
{
    public class Purple
    {
        public bool Task1(int a, int b, int c)
        {
            bool answer = false;

            // code here
            if ((a > 0 & b > 0 & c > 0) | (a < 0 & b < 0 & c < 0)) answer = true;
            // end

            return answer;
        }
        public bool Task2(int a, int b)
        {
            bool answer = false;

            // code here
            if (a == 0 | b == 0) answer = true;
            else if ((a % b == 0) | (b % a == 0)) answer = true;
            // end

            return answer;
        }
        public bool Task3(int a, int b)
        {
            bool answer = false;

            // code here
            if (a == b * b | a == b * b * b | b == a * a | b == a * a * a) answer = true;
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
            if (x <= -1) answer = 1;
            if (x > -1 & x <= 1) answer = -x;
            if (x > 1) answer = -1;
            // end

            return answer;
        }
        public bool Task6(double squareS, double circleS)
        {
            bool answer = false;

            // code here
            if (Math.Sqrt(circleS / double.Pi) > (Math.Sqrt(squareS) * Math.Sqrt(2) / 2)) answer = true;
            // end

            return answer;
        }

        public int Task7(bool s, bool t, bool f)
        {
            int answer = 0;

            // code here
            if (s)
            {
                if (t) answer = 6;
                else if (f) answer = 10;
                else answer = 2;
            }
            else if (t) answer = 3;
            else if (f) answer = 5;
            else answer = 1;
                // end

                return answer;
        }
        public bool Task8(int year, int pupils, int salary)
        {
            bool answer = false;
            const int bank = 10000;

            // code here
            int avrors = pupils / 7;
            if (pupils % 7 > 0) avrors = (pupils / 7 + 1);
            if (((avrors * salary + pupils * 5) <= bank) & (!(year % 4 == 0) | (year % 100 == 0 & year % 400 != 0))) answer = true;
                // end

                return answer;
        }
    }
}