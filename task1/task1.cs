using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            float sum = 0;
            float max = 0;
            float min = 0;
            float avg = 0;
            double rank = 0;
            Int16 rank1 = 0;
            double perc = 0;
            float med = 0;

            Int16 n = 0;
            Console.WriteLine("Введите количество значений");
            n = Int16.Parse(Console.ReadLine());
            Console.WriteLine("Введите значения");
            float[] result = new float[5];
            Int16[] x = new Int16 [n];
            for (int i = 0; i < n; i++)
            {
                x[i] = Int16.Parse(Console.ReadLine());
            }
            Array.Sort(x);
            foreach(int a in x)
            {
                sum += a;         
            }

            if (n % 2 == 0)
            {
                med = x[n / 2] + x[n / 2 - 1];
                med = med / 2;
            }
            else if (n == 1)
                med = x[0];
            else
                med = x[n / 2];
            max = x[n-1];
            min = x[0];
            rank = 0.9 * (n - 1) + 1;
            rank1 = (Int16)rank;           
            if (n == 1)
                perc = x[0];
            else
                perc = x[rank1 - 1] + (rank - rank1) * (x[rank1] - x[rank1 - 1]);
            avg = sum / n;
            Console.WriteLine();
            result[0] = (float)perc;
            result[1] = med;
            result[2] = max;
            result[3] = min;
            result[4] = avg;
            foreach(float a in result)
            Console.WriteLine(a.ToString("0.00"));
            Console.ReadKey();
        }
    }
}
