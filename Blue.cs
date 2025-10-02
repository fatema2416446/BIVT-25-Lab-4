using System.ComponentModel.Design;

namespace Lab1
{
    public class Blue
    {
        public bool Task1(int a, int b)
        {
            bool answer = false;

            // code here

            if ((a > 0 && b > 0) || (a<0 && b<0))
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
            double  dint = Math.Floor(d);
            if (d > dint)
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
            if ((b != 0) && (a % b == 0))
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
            double Moduled = Math.Abs(d);
            double Modulef = Math.Abs(f);
            double Moduleg = Math.Abs(g);
            if ((Moduled > Modulef) && (Moduled > Moduleg))
            {
                answer = d;
            }
            else
            {
                if (Modulef > Moduleg)
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
            else
            {
                if ((x > -1) && (x <= 0))
                {
                    answer = x + 1;
                }
                else
                {
                    answer = 1;
                }
            }
                // end

                return answer;
        }
        public bool Task6(double circleS, double squareS)
        {
            bool answer = false;

            // code here
            double diam = 2 * Math.Sqrt(circleS / Math.PI);
            double stor = Math.Sqrt(squareS);
            if (diam <= stor)
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
                    return answer;
                }
                else
                {
                    return answer;
                }            
            }
            else
            {
                if (f > 0)
                {
                    answer = 1;
                    return answer;
                }
                else 
                {
                    return answer;
                }
            }
                // end

                return answer;
        }
        public bool Task8(int a, int b, int c)
        {
            bool answer = false;

            // code here
            double a1 = a/2;
            double b1 = b/2;
            double c1 = c/2;
            double sum = Math.Floor(a1) + Math.Floor(b1) + Math.Floor(c1);
            if ((sum >= 3) && (sum % 3 == 0))
            {
                answer = true;
            }
            else
            {
                sum++;
                if (sum % 3 ==0)
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
    }
}