using System.Reflection.Metadata.Ecma335;

namespace Lab1
{
    public class Blue
    {
        public bool Task1(int a, int b)
        {
            bool answer = false;

            // code here
            if ((a < 0 && b < 0) || (a > 0 && b > 0))
            {
               answer = true;
            }
            return answer;

            // end



        }
        public bool Task2(double d)
        {
            bool answer = false;

            // code here
            if (d % 1 !=0)
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
            if (b == 0)
            {
                answer = false;
            }
            else 
            {   
                if (a%b==0)
                {
                    answer = true;
                }
                else
                {
                    answer = false;
                }
                    
            }
                
            
                // end

                return answer;
        }
        public double Task4(double d, double f, double g)
        {
            double answer = 0;

            // code here
            if( (Math.Abs(d) > Math.Abs(f)) &&( Math.Abs(d) > Math.Abs(g)))
            {
                answer = d;
            }
            else
            {
                if ((Math.Abs(f) > Math.Abs(d)) && (Math.Abs(f) > Math.Abs(g)))
                {
                    answer = f;

                }
                else
                {
                    answer = g;
                }




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
            }
            else if ((-1 < x) && (x <= 0))
            {
                answer = x + 1;
            }
            else
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
            if (Math.Sqrt(circleS/Math.PI)*2<=Math.Sqrt(squareS))
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
            if ((Math.Abs(d)< Math.Abs(f)) &&(d >0))
            {
                answer = -1;
            }
            else if ((Math.Abs(d) >= Math.Abs(f)) && (f > 0))
            {
                answer = 1;
            }
                // end

                return answer;
        }
        public bool Task8(int a, int b, int c)
        {
            bool answer = false;

            // code here
            int A = a / 2;
            int B = b / 2;
            int C = c / 2;
            int s = A + B + C;
            if (s % 3 == 0)
            {
                int k = s / 3;
                if (k >= 1 && k <= a && k <= b && k <= c)
                {
                    answer = true;
                }
            }
            if ((s + 1) % 3 == 0)
            {
                int k = (s + 1) / 3;
                if (k >= 1 && k <= a && k <= b && k <= c )
                {
                    answer = true;
                }
             
            }

            // end

            return answer;
        }
    }
}
