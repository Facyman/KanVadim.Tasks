using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task4
{
    class Program
    {     
        static void Main(string[] args)
        {
            string n;
            n = Console.ReadLine();
            string[] lines = File.ReadAllLines(@n);
            DateTime[,] x = new DateTime[lines.Length, 2];
            int[] timespan = new int[lines.Length];
            DateTime[,] timespan1 = new DateTime[lines.Length, 2];
            for (int i = 0; i < lines.Length; i++)
            {
                string input = lines[i];
                string[]  splitted = input.Split(' ');
                for (int date = 0; date< 2; date++)
                {
                    DateTime a = DateTime.Parse(splitted[date]);                   
                    x[i, date] = a;
                }              
            }
            int z = 0;
            for (int i = 0; i < lines.Length; i++)
            {              
                for (int j = i; j < lines.Length; j++)
                {

                    if (i != j)
                    {
                        if (DateTime.Compare(x[i, 1], x[j, 0]) > 0 && DateTime.Compare(x[i, 0], x[j, 1]) < 0)
                        {
                            int com1 = DateTime.Compare(x[i, 0], x[j, 0]);
                            if (com1 >= 0)
                                timespan1[z, 0] = x[i, 0];
                            else
                                timespan1[z, 0] = x[j, 0];
                            int com2 = DateTime.Compare(x[i, 1], x[j, 1]);
                            if (com2 <= 0)
                                timespan1[z, 1] = x[i, 1];
                            else
                                timespan1[z, 1] = x[j, 1];
                            for (int g = j+1; g < lines.Length; g++)
                            {                              
                                    if (DateTime.Compare(timespan1[z, 1], x[g, 0]) > 0 && DateTime.Compare(timespan1[z, 0], x[g, 1]) < 0)
                                    {
                                        int com3 = DateTime.Compare(timespan1[z, 0], x[g, 0]);
                                        if (com3 < 0)
                                            timespan1[z, 0] = x[g, 0];
                                        timespan1[z, 0] = x[g, 0];
                                        int com4 = DateTime.Compare(timespan1[z, 1], x[g, 1]);
                                        if (com4 > 0)
                                            timespan1[z, 1] = x[g, 1];
                                        timespan[z]++;
                                    }
                            }
                            timespan[z]++;
                            z++;
                            break;
                        }
                    }
                }
                
            }
            for (int i = 0; i < lines.Length; i++)
            {
                for (int j = 0; j < lines.Length; j++)
                {
                    if (timespan1[i, 0].ToString("HH:mm") != "00:00" && timespan1[i, 1].ToString("HH:mm") != "00:00" && timespan1[i, 1] == timespan1[j, 0] && timespan[i] == timespan[j])
                    {
                        timespan1[i, 1] = timespan1[j, 1];
                        timespan1[j, 0] = new DateTime();
                        timespan1[j, 1] = new DateTime();
                        timespan[j] = 0;
                    }
                    if (timespan1[i, 0].ToString("HH:mm") != "00:00" && timespan1[i, 1].ToString("HH:mm") != "00:00" && timespan1[i, 0] == timespan1[j, 1] && timespan[i] == timespan[j])
                    {
                        timespan1[i, 0] = timespan1[j, 0];
                        timespan1[j, 0] = new DateTime();
                        timespan1[j, 1] = new DateTime();
                        timespan[j] = 0;
                    }
                }
            }
            int max = timespan.Max();
            
            for (int i = 0; i < lines.Length; i++)
                    if (timespan[i]==max && max!=0)
                Console.WriteLine(timespan1[i, 0].ToString("HH:mm") + " " + timespan1[i, 1].ToString("HH:mm"));
            Console.ReadKey();
        }
    }
}
