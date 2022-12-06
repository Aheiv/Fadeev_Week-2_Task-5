using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ЛАБ5_WinForms
{
    public partial class Form1 : Form
    {
        static double f(double x) // функция
        {
            try
            {
                if (x == 1 || x == 0.25) throw new Exception();
                else return (1 / (x - 1)) + (2 / (1 - 4 * x));
            }
            catch
            {
                throw;
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a;
            double b;
            double h;
            a = double.Parse(numericUpDown1.Text);
            b = double.Parse(numericUpDown2.Text);
            h = double.Parse(numericUpDown3.Text);
            if (h <= 0 || b < a) MessageBox.Show("Некорректный ввод данных!");
            else
            {
                richTextBox1.Text = $"Диапазон чисел от {a} до {b} с шагом {h}\n";
                for (double i = a; i <= b; i += h)
                    try
                    {
                        richTextBox1.Text += $"y({i}) = {f(i)}\n";
                    }
                    catch
                    {
                        richTextBox1.Text += $"y({i}) = Ошибка!\n";
                    }
            }
        }
    }
}
