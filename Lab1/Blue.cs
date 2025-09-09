namespace Lab1
{
    public class Blue
    {
        public bool Task1(int a, int b)
        {
            bool answer = false;
            
            // тестик

            // code here
            if ((a > 0 && b > 0) || (a < 0 && b < 0) || (a == 0 && b == 0))
            {
                answer= true;
            }
            else
            {
                answer= false;
            }

            // end

            return answer;
        }
        public bool Task2(double d)
        {
            bool answer = false;

            // code here
            if (Math.Abs(d)-Math.Abs((int)d) > 0)
            {
                answer= true;
            }
            else
            {
                answer= false;
            }

            // end

            return answer;
        }
        public bool Task3(int a, int b)
        {
            bool answer = false;

            // code here
            if (b == 0)
            {
                answer= false;
            }
            else if (a % b == 0)
            {
                answer = true;
            }
            else
            {
                answer= false;
            }
            // end

            return answer;
        }
        public double Task4(double d, double f, double g)
        {
            double answer = 0;

            // code here
            var dd = Math.Abs(d);
            var ff = Math.Abs(f);
            var gg = Math.Abs(g);
            double[] array = new double[3];
            array[0] = dd;
            array[1] = ff;
            array[2] = gg;
            if (array.Max() == dd)
            {
                answer= d;
            }
            else if (array.Max() == ff)
            {
                answer=f;
            }
            else if (array.Max() == gg)
            {
                answer= g;
            }
            // end

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here
            if (x <= -1)
            {
                answer= 0;
            }

            if (x > -1 && x <= 0)
            {
                answer= x+ 1;
            }

            if (x > 0)
            {
                answer= 1;
            }

            // end

            return answer;
        }
        public bool Task6(double circleS, double squareS)
        {
            bool answer = false;

            // code here
            var SideSq=Math.Sqrt(squareS);
            var DiamCircle = 2*(Math.Sqrt(circleS/3.14));
            if (SideSq >=DiamCircle)
            {
                answer= true;
            }
            else 
            {
                answer= false;
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
                    answer= -1;
                }
                else
                {
                    answer= 0;
                }
            }
            else
            {
                if (f > 0)
                {
                    answer= 1;
                }
                else
                {
                    answer= 0;
                }
            }
            // end

            return answer;
        }
        public bool Task8(int a, int b, int c)
        {
            bool answer = false;

            // code here
            int NowA = a / 2;
            int NowB = b / 2;
            int NowC = c / 2;
            
            int NowSum = NowA + NowB + NowC;

            if (NowSum == 0)
            {
                answer = false;
            }

            else if (NowSum % 3 == 0 || (NowSum+1) % 3 == 0)
            {
                answer= true;
            }
            else
            {
                answer= false;
            }
            // end

            return answer;
        }
    }
}
