namespace Lab1
{
    public class White
    {
        public bool Task1(double d)
        {
            bool answer = false;
            // code here
            //answer = true;
            //double d = 45.00;  // Проверяя число, каждый раз меняем значение переменной d
            if (d > 0)
            {
                answer = true;
            }
            // end
            return answer;
        }





        
        public bool Task2(int n)
        {
            bool answer = false;
            // code here
            //int n = 0;
            n = Math.Abs(n);
            if (n % 2 == 0)
            {
                answer = true;
            }
            // end
            return answer;
        }





        
        public int Task3(int a, int b)
        {
            int answer = 0;
            // code here
            //int a = 5;
            //int b = 5;
            if (a >= b)
            {
                answer = a;
            }
            else 
                answer = b;
            // end
            return answer;
        }






        
        public double Task4(double d, double f)
        {
            double answer = 0;
            // code here
            //double d = -1.1;
            //double f = -0.6;
            if (Math.Abs(f) >= Math.Abs(d))
            {
                answer = d; 
            }
            else 
                answer = f; 
            // end
            return answer;
        }









        
        public double Task5(double x)
        {
            double answer = 0;
            // code here
            //double x = 2.4;

            if (Math.Abs(x) > 1)
            {
                answer = 1;
            }
            else 
                answer = x;
            // end
            return answer;
        }








        
        public bool Task6(double x, double y, double r)
        {
            bool answer = false;
            // code here
            //double x = -1.1;
            //double y = -0.6;
            //double r = 1.5;
            double n = Math.Abs(x * x + y * y - r * r);
            answer = (n <= 0.0001);
            // end
            return answer;
        }








        

        public bool Task7(int n)
        {
            bool answer = false;
            // code here
            //int n = 15;
            int s = n * n;
            if (s - n > 2 * n)
                if (Math.Abs(n) % 2 == 0)
                    answer = true;
            // end
            return answer;
        }









        
        public bool Task8(double L, int T, int M)
        {
            bool answer = false;
            // code here
            // произвольные текстовые значения: как пример
            //int L = 28; // Длина окружности острова
            //int T = 4; // Количество деревьев
            //int M = 2; // Количество гор

            // 3 часа * 10 миль/ч = 30 миль(длина окружности по усл не более 30 миль)
            // по условию четное кол-во гор и не менее 5 ориентиров, включая деревья
            answer = (L <= 30) && (T + M >= 5) && (M % 2 == 0);
            // end
            return answer;
        }
    }
}















