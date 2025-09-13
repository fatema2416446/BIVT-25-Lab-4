namespace Lab1
{
    public class Purple
    {
        public bool Task1(int a, int b, int c)
        {
            bool answer = false;

            // code here

            int minimum = Math.Min(Math.Min(a, b), c);
            int maximum = Math.Max(Math.Max(a, b), c);
            if (minimum > 0 || maximum < 0)
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

            if (b != 0 && a % b == 0 || a != 0 && b % a == 0)
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

            if (a * a == b || a * a * a == b || 
                b * b == a || b * b * b == a)
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

            answer = f * f - 4 * d * g;

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
            else if (x <= 1)
            {
                answer = -x;
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

            if (squareS * Math.PI <= 2 * circleS)
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
                else if (f)
                {
                    answer = 10;
                }
                else
                {
                    answer = 2;
                }
            }
            else
            {
                if (t)
                {
                    answer = 3;
                }
                else if (f)
                {
                    answer = 5;
                }
                else
                {
                    answer = 1;
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

            int min_cnt_aur = (pupils + 7 - 1) / 7;
            int min_sum_salary = salary * min_cnt_aur;
            int equip = pupils * 5;
            int expence = min_sum_salary + equip;
            bool leap_year = false;
            if (year % 400 == 0 || year % 4 == 0 && year % 100 != 0)
            {
                leap_year = true;
            }
            if (expence <= bank && !leap_year)
            {
                answer = true;
            }


            // end

            return answer;
        }
    }
}