namespace Lab1
{
    public class Blue
    {
        public bool Task1(int a, int b)
        {
            bool answer = false;

            answer = Math.Sign(a) == Math.Sign(b);

            return answer;
        }
        public bool Task2(double d)
        {
            bool answer = false;

            // code here

            d = Math.Abs(d);

            answer = (d - Math.Floor(d)) != 0.0;

            // end

            return answer;
        }
        public bool Task3(int a, int b)
        {
            bool answer = false;

            // code here


            if (b != 0) 
            {
                answer = ((a % b) == 0);
            } else
            {
                answer = false;
            }

            //    Console.WriteLine($"{a}, {b}, a%b={a % b}, answer={answer}");
            // end

            return answer;
        }
        public double Task4(double d, double f, double g)
        {
            double answer = 0;

            // code here
            if (Math.Abs(d) >= Math.Abs(f))
            {
                if (Math.Abs(d) >= Math.Abs(g))
                {
                    answer = d;
                }
                else answer = g;
            }
            else
            {
                if (Math.Abs(f) >= Math.Abs(g))
                {
                    answer = f;
                }
                else answer = g;
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
                answer = 0;
            } else if(x>0) {
                answer = 1;
            } else
            {
                answer = x+1;
            }


                // end

                return answer;
        }
        public bool Task6(double circleS, double squareS)
        {
            bool answer = false;

            // code here

            double circleR = Math.Sqrt(circleS / Math.PI);
            double squareW = Math.Sqrt(squareS);
            double squareD = squareW * Math.Sqrt(2.0);


            answer = circleR * 2 <= squareW;


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
                if (f > 0){
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

            //voobshe vse vmestyatsya?
            int s = a/2+b/2+c/2;
            int[] all = { a, b, c };
            if ((s%3 == 0 && s/3>0) || (s % 3 == 2))
            {
                answer = true;
            }
                // end

                return answer;
        }
    }
}