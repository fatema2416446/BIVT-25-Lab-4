namespace Lab1
{
    public class Blue
    {
        public bool Task1(int a, int b)
        {
            bool answer = false;

            // code here
            answer = (a > 0 && b > 0) || (a < 0 && b < 0);
            // end

            return answer;
        }
        public bool Task2(double d)
        {
            bool answer = false;

            // code here
            answer = Math.Abs(d - (int)d) > 0.0001;
            // end

            return answer;
        }
        public bool Task3(int a, int b)
        {
            bool answer = false;

            // code here
            if (Math.Abs(b) > 0)
            {
                answer = (a % b) == 0;
            }
           
            // end

            return answer;
        }
        public double Task4(double d, double f, double g)
        {
            double answer = g;

            // code here
            if (Math.Abs(d) > Math.Abs(f) && Math.Abs(d) > Math.Abs(g))
            {
                answer = d;
            }
            if (Math.Abs(f) > Math.Abs(d) && Math.Abs(f) > Math.Abs(g))
            {
                answer = f;
            }
            // end

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here
            if (x <= 0 & x > -1)
            {
                answer = x+1;
                //answer = ++x;
            }
            if (x > 0)
            {
                answer = 1;
            }
            // end

            return answer;
        }
        public bool Task6(double circleS, double squareS)
        {
            bool answer = false;

            // code here
            double squareR = Math.Sqrt(squareS);
            double circleR = Math.Sqrt(circleS / Math.PI);

            if (squareR >= circleR * 2)
            {
                answer = true;
            }
            // end

            return answer;
        }

        public double Task7(double d, double f)
        {
            int answer = 0;

            // code here
            if (Math.Abs(d) < Math.Abs(f))
            {
                if (d > 0)
                {
                    answer = -1;
                }
            }
            else
            {
                if (f > 0)
                {
                    answer = 1;
                }
            }

            // end

            return answer;
        }
       
        public bool Task8(int a, int b, int c)
        {
            bool answer = false;

            // code here
            int monets = a / 2 + b / 2 + c / 2;

            if (monets % 3 == 0)
            {
                int person = monets / 3;

                if (a>=person && b >= person && b >= person && person >= 1)
                {
                    answer = true;
                }
            }
            else
            {
                if ((monets + 1) % 3 == 0)
                {
                    int person = (monets+1) / 3;

                    if (a >= person && b >= person && b >= person && person >= 1)
                    {
                        answer = true;
                    }
                }
            }


            // end

            return answer;
        }
    }
}