namespace Lab1
{
    public class Purple
    {
        public bool Task1(int a, int b, int c)
        {
            bool answer = false;

            // code here

            // end

            return answer;
        }
        public bool Task2(int a, int b)
        {
            bool answer = false;

            // code here

            // end

            return answer;
        }
        public bool Task3(int a, int b)
        {
            bool answer = false;

            // code here

            // end

            return answer;
        }
        public double Task4(double d, double f, double g)
        {
            double answer = 0;

            // code here

            // end

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here

            // end

            return answer;
        }
        public bool Task6(double squareS, double circleS)
        {
            bool answer = false;

            // code here

            // end

            return answer;
        }

        public int Task7(bool s, bool t, bool f)
        {
            int answer = 0;

            // code here

            // end

            return answer;
        }
        public bool Task8(int year, int pupils, int salary)
        {
            bool answer = false;
            const int bank = 10000;

            // code
            int aurora = 0;
            if (pupils % 7 == 0)
            {
                aurora = pupils / 7;
            }
            else
            {
                aurora = pupils / 7 + 1;
            }

            if (((year % 400 == 0) || (year % 4 == 0 && year % 100 != 0)) == false)
            {
                if ((aurora * salary + pupils * 5) <= bank)
                {
                    answer = true;
                }
            }

            // end

           

            return answer;
        }
    }
}