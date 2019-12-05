using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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

            string n;
            n = Console.ReadLine();
            string [] lines = File.ReadAllLines(@n);
            float[] result = new float[5];
            Int16[] x = new Int16 [lines.Length];
            for (int i = 0; i < lines.Length; i++)
            {
                x[i] = Int16.Parse(lines[i]);
            }
            Array.Sort(x);
            foreach(int a in x)
            {
                sum += a;         
            }

            if (lines.Length % 2 == 0)
            {
                med = x[lines.Length / 2] + x[lines.Length / 2 - 1];
                med = med / 2;
            }
            else if (lines.Length == 1)
                med = x[0];
            else
                med = x[lines.Length / 2];
            max = x[lines.Length - 1];
            min = x[0];
            rank = 0.9 * (lines.Length - 1) + 1;
            rank1 = (Int16)rank;           
            if (lines.Length == 1)
                perc = x[0];
            else
                perc = x[rank1 - 1] + (rank - rank1) * (x[rank1] - x[rank1 - 1]);
            avg = sum / lines.Length;
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
