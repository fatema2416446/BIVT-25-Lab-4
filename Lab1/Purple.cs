namespace Lab1
{
    public class Purple
    {
        public bool Task1(int a, int b, int c)
        {
            bool answer = false;

            // code here
            answer = (a > 0 && b > 0 && c > 0) || (a < 0 && b < 0 && c < 0);
            // end

            return answer;
        }
        public bool Task2(int a, int b)
        {
            bool answer = false;

            // code here

            if (a == 0 && b != 0) return true;
            if (b == 0 && a != 0) return true;


            if (a % b == 0 || b % a == 0) return true;


            // end

                return answer;
        }
        public bool Task3(int a, int b)
        {
            bool answer = false;

            // code here

            answer = (a == Math.Pow(b, 2) || a == Math.Pow(b, 3) || b == Math.Pow(a, 2) || b == Math.Pow(a, 3));

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
                answer = 1;
            else if (x <= 1)
                answer = -x;
            else
                answer = -1;

                // end

                return answer;
        }
        public bool Task6(double squareS, double circleS)
        {
            bool answer = false;

            // code here

            if ((circleS / Math.PI * 2) >= squareS)
                answer = true;

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
                    answer = 6;
                else if (f)
                    answer = 10;
                else
                    answer = 2;
            }
            else
            {
                if (t)
                    answer =  3;
                else if (f)
                    answer = 5;
                else
                    answer = 1;
            }

                // end

                return answer;
        }
        public bool Task8(int year, int pupils, int salary)
        {
            bool answer = false;
            const int bank = 10000;

            // code here
            const int KforPupipls = 5;

            int moneyPupils = KforPupipls * pupils;

            int curBank = bank - moneyPupils;

            double numAvroras = curBank / salary;
            numAvroras = Math.Floor(numAvroras);

            bool conditionA = false;
            bool conditionB = true;
            bool conditionC = false;

            if (pupils / numAvroras <= 7)
                conditionA = true;
            if ((year % 4 != 0) || (year % 400 != 0 && year % 100 == 0))
                conditionC = true;


            answer = (conditionA && conditionB && conditionC);
            // end

            return answer;
        }
    }
}
