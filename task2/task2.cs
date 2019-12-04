using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Program
    {      
        static void Main(string[] args)
        {

            int n = 0;

            float[,] x = new float[4,2];
            Console.WriteLine("Введите координаты четырехугольника");
            for (int i = 0; i < 4; i++)
            {
                var input = Console.ReadLine();
                string[] splitted = input.Split(' ');
                for (int column = 0; column < splitted.Length; column++)
                {
                    float a = float.Parse(splitted[column].Replace('.', ','));
                    x[i, column] = a;
                }
            }
            Console.WriteLine("Введите количество точек");
            n = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите координаты точек");
            float[,] b = new float[n,2];
            for (int i = 0; i < n && i < 100; i++)
            {
                string input = Console.ReadLine();
                string[] splitted = input.Split(' ');
                for (int column = 0; column < splitted.Length; column++)
                {
                    float a = float.Parse(splitted[column].Replace('.', ','));
                    b[i, column] = a;
                }
            }
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                float x1 = x[0, 0];
                float y1 = x[0, 1];
                float x2 = x[1, 0];
                float y2 = x[1, 1];
                float x3 = x[2, 0];
                float y3 = x[2, 1];
                float x4 = x[3, 0];
                float y4 = x[3, 1];

                float ax = (b[i, 0] - x1) * (b[i, 1] - y2) - (b[i, 0] - x2) * (b[i, 1] - y1);
                float bx = (b[i, 0] - x2) * (b[i, 1] - y3) - (b[i, 0] - x3) * (b[i, 1] - y2);
                float cx = (b[i, 0] - x3) * (b[i, 1] - y4) - (b[i, 0] - x4) * (b[i, 1] - y3);
                float dx = (b[i, 0] - x4) * (b[i, 1] - y1) - (b[i, 0] - x1) * (b[i, 1] - y4);


                if (b[i, 0] == x1 && b[i, 1] == y1 || b[i, 0] == x2 && b[i, 1] == y2 || b[i, 0] == x3 && b[i, 1] == y3 || b[i, 0] == x4 && b[i, 1] == y4)
                {
                    Console.WriteLine(0);
                }
                else if ((ax==0 && b[i,1]>= y1 && b[i, 1] <= y2) || (bx == 0 && b[i, 0] >= x2 && b[i, 1] <= x3) || (cx == 0 && b[i, 1] >= y4 && b[i, 1] <= y3) || (dx == 0 && b[i, 0] >= x1 && b[i, 1] <= x4))
                {
                    Console.WriteLine(1);
                }
                else if ((ax > 0 && bx > 0 && cx > 0) || (ax < 0 && bx < 0 && cx < 0))
                {
                    Console.WriteLine(2);
                }
                else
                {
                    Console.WriteLine(3);
                }               
            }                                 
            Console.ReadKey();
        }      
    }
}
