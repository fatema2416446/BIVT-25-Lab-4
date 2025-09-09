using System.Runtime.Intrinsics.X86;

namespace Lab1
{
    public class Blue
    {
        public bool Task1(int a, int b)
        {
            bool answer = false;

            // code here
            if (a > 0 & b > 0 | a <0 & b <0) 
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
            var s = (int)d;
            if (s != d)
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
            if (b==0)
            {
                answer = false;
            }
            if (b!=0)
            {
                if (a % b == 0)
                {
                    answer = true;
                }
            }
            
            // end

                return answer;
        }
        public double Task4(double d, double f, double g)
        {
            double answer = 0;

            // code here
            if (Math.Abs(d) >= Math.Abs(f)) if (Math.Abs(d) >= Math.Abs(g))
                {
                    answer = d;
                }
            if (Math.Abs(f) >= Math.Abs(d)) if (Math.Abs(f)>= Math.Abs(g))
                {
                    answer = f;
                }
            if (Math.Abs(g) >= Math.Abs(d)) if (Math.Abs(g)>= Math.Abs(f))
                {
                    answer = g;
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
            if (x > -1) if ( x <=0)
            {
                answer = x + 1;
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
            double D = 2 *Math.Abs(Math.Sqrt(((double)circleS /  Math.PI)));
            double a = Math.Abs(Math.Sqrt(squareS));
            if (D <= a)
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
                if (d>0)
                {
                    answer = -1;
                }
                
            }
            else
            {
                if (f>0)
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
            int olderson = a/2;
            int midson = b / 2;
            int youngestson = c / 2;
            int allgold = olderson + midson + youngestson;
            if (allgold%3==0)
            {
                olderson = allgold / 3;
                midson = allgold / 3;
                youngestson = allgold / 3;
                if (olderson >= 1 & midson >= 1 & youngestson >= 1)
                {
                    if (olderson <=a & midson <= b & youngestson<=c)
                    {
                        answer = true;
                    }

                }
            }
            if (allgold%3 !=0)
            {
                if ((allgold +1)%3 == 0)
                {
                    olderson = (allgold + 1)/ 3;
                    midson = (allgold + 1)/ 3;
                    youngestson = (allgold + 1)/ 3;
                    if (olderson <= a & midson <= b & youngestson <= c)
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