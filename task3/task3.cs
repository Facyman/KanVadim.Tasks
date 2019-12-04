using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace task_3
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            string[] lines0 = new string[16];
            string[] lines1 = new string[16];
            string[] lines2 = new string[16];
            string[] lines3 = new string[16];
            string[] lines4 = new string[16];
            double max = 0;
            int maxim = 0;

            double[] result = new double[16];
            for (int i = 0; i < 5; i++)
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    MessageBox.Show("Выберите файл номер " + (i + 1));
                    openFileDialog.InitialDirectory = "c:\\";
                    openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                    openFileDialog.FilterIndex = 2;
                    openFileDialog.RestoreDirectory = true;

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        switch (i)
                        {
                            case 0:
                                lines0 = File.ReadAllLines(openFileDialog.FileName);
                                break;
                            case 1:
                                lines1 = File.ReadAllLines(openFileDialog.FileName);
                                break;
                            case 2:
                                lines2 = File.ReadAllLines(openFileDialog.FileName);
                                break;
                            case 3:
                                lines3 = File.ReadAllLines(openFileDialog.FileName);
                                break;
                            case 4:
                                lines4 = File.ReadAllLines(openFileDialog.FileName);
                                break;
                        }
                    }
                }
            }
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
            MessageBox.Show(maxim.ToString());
        }
    }
}
