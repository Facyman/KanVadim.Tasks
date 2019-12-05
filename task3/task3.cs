using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task3reformed
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines0 = new string[16];
            string[] lines1 = new string[16];
            string[] lines2 = new string[16];
            string[] lines3 = new string[16];
            string[] lines4 = new string[16];
            double max = 0;
            int maxim = 0;

            string g;
            g = Console.ReadLine();
            int d = 0;

            foreach (string file in Directory.EnumerateFiles(g, "*.txt"))
            {
                switch (d)
                {
                    case 0:
                        lines0 = File.ReadAllLines(file);
                        break;
                    case 1:
                        lines1 = File.ReadAllLines(file);
                        break;
                    case 2:
                        lines2 = File.ReadAllLines(file);
                        break;
                    case 3:
                        lines3 = File.ReadAllLines(file);
                        break;
                    case 4:
                        lines4 = File.ReadAllLines(file);
                        break;
                }
                d++;
            }

            double[] result = new double[16];

            for (int i = 0; i < 16; i++)
            {
                double a0 = double.Parse(lines0[i].Replace('.', ','));
                double a1 = double.Parse(lines1[i].Replace('.', ','));
                double a2 = double.Parse(lines2[i].Replace('.', ','));
                double a3 = double.Parse(lines3[i].Replace('.', ','));
                double a4 = double.Parse(lines4[i].Replace('.', ','));
                result[i] = a0 + a1 + a2 + a3 + a4;
                if (result[i] > max)
                {
                    max = result[i];
                    maxim = i;
                }
            }
            maxim = maxim + 1;
            Console.WriteLine(maxim.ToString());
            Console.ReadKey();
        }
    }
}
