using System;
using System.Collections.Generic;

namespace indi_work_1
{
    class Program
    {
        static double ReadDoubleValue(string Message)
        {
            while (true)
            {
                Console.Write(Message);
                if (double.TryParse(Console.ReadLine(), out double result))
                    return result;
                Console.WriteLine("YOU FOOL!");
            }
        }
        static double ToThePowerofN(int N, double x)
        {
            int i = 1;
            double Xres = x;
            while (i <= N) Xres *= x;
            return Xres;
        }
        static double ResFunc(int N, double[] coeff, double x)
        {
            double res = coeff[0];
            for(int i = 1; i <= N; ++i) res += coeff[i] * ToThePowerofN(i, x);
            return res;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter the highest power of function: ");
            string str = Console.ReadLine();
            int N = int.Parse(str);
            Console.Write("Enter coefficients for polynom: ");
            double[] coeff = new double[N];
            for (int i = 0; i <= N; ++i)
            {
                str = Console.ReadLine();
                ReadDoubleValue(str);
                coeff[i] = double.Parse(str);
            }
            Console.Write("Enter the left most bound of function: ");
            str = Console.ReadLine();
            ReadDoubleValue(str);
            double x1 = double.Parse(str);
            Console.Write("Enter the right most bound of function: ");
            str = Console.ReadLine();
            ReadDoubleValue(str);
            double x2 = double.Parse(str);
            List<double> func_eq = new List<double>();
            double dx = 0.001;
            double x = x1;
            while (x <= x2)
            {
                func_eq.Add(ResFunc(N, coeff, x));
                x += dx;
            }
            for (int i = 1; i < func_eq.Count - 1; ++i)
            {
                if ()
            }
        }
    }
}
