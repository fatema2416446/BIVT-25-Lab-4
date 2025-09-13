using System.ComponentModel.Design;

namespace Lab1
{
    public class Blue
    {
        public bool Task1(int a, int b)
        {
            bool answer = false;

            // code here
            if((a>0 && b>0)||(a<0 && b<0))
            {
                answer = true;
            }
            else
            {
                answer = false;
            }
                // end

                return answer;
        }
        public bool Task2(double d)
        {
            bool answer = false;

            // code here
            if (d!=Convert.ToInt32(d))
            {
                answer = true;
            }
            else
            {
                answer = false;
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
            else if (((a % b) == 0))
            {
                answer = true;
            }
            else
            {
                answer = false;
            }
                // end

                return answer;
        }
        public double Task4(double d, double f, double g)
        {
            double answer = 0;

            // code here
            double v = Math.MaxMagnitude(f, g);
            answer = Math.MaxMagnitude(d, v);
                // end

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here
            if(x<=-1)
            {
                answer = 0;
            }
            else if ((x>-1)&&(x<=0))
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
            double storona = Math.Sqrt(squareS);
            double rad = Math.Sqrt(circleS / Math.PI);
            double diam = 2 * rad;
            if (diam <= storona)
            {
                answer = true;
            }
            else
            {
                answer = false;
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
            int zoloto = a/2 + b/2 + c/2;
            if(((zoloto%3==0) ||((zoloto+1)%3==0))&&(zoloto>=2))
            {
                answer = true;
            }
            else
            {
                answer = false;
            }
                // end

                return answer;
        }
    }
}