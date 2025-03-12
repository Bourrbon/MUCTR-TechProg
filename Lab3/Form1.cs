using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Lab3 : Form
    {
        public Lab3()
        {
            InitializeComponent();
        }

        private void ReceiveInput()
        {
            bool inputSuccess = false;

            double x_start = 0.0, x_end = 0.0;
            int n = 1;
            ErrorLabel.Text = "Вычисление...";

            try
            {
                x_start = Convert.ToDouble(xStartBox.Text);
                x_end = Convert.ToDouble(xEndBox.Text);
                n = Convert.ToInt32(xNBox.Text);
                if (n <= 0)
                {
                    throw new Exception("Invalid interval size");
                }

                inputSuccess = true;
                ErrorLabel.Text = "OK";
            }

            catch (Exception ex)
            {
                OutputBox.Clear();
                OutputBox.Text = ex.Message;
                ErrorLabel.Text = "ERROR";
            }

            if (inputSuccess)
            {
                PerformCalculation(x_start, x_end, n);
            }
        }

        private void PerformCalculation(double start, double stop, int n)
        {
            bool cacluationErrorCatched = false;
            string[] OutputValues = new string[n];
            
            OutputBox.Text = $"{"x", -10} {"F(x)", +10} {Environment.NewLine}  ------------------------------------------------------------ {Environment.NewLine}";

            int i = 0;
            double[] xRange = Function.Linspace(start, stop, n);

            do
            {
                try
                {
                    double t = Function.TotalF(xRange[i]);
                    if (double.IsNaN(t) || double.IsInfinity(t))
                    {
                        OutputValues.Append("-");
                        OutputBox.AppendText($"{Math.Round(xRange[i], 3),-10} {"-",+10} {Environment.NewLine}");
                        throw new ApplicationException("NaN or inf occured");
                    }
                    OutputValues.Append(Convert.ToString(t));
                    OutputBox.AppendText($"{Math.Round(xRange[i], 3),-10} {Math.Round(t, 3),+10} {Environment.NewLine}");
                }
                catch
                {
                    cacluationErrorCatched = true;
                    i++;
                    continue;
                }
                i++;
            }
            while (i <= xRange.Length - 1);

            ErrorLabel.Text = "OK";

            if (cacluationErrorCatched == true)
            {
                ErrorLabel.Text = "ERR";
                // Вызываем диалоговое окно с сообщением об ошибке
                DialogResult result = MessageBox.Show(
                    "Интервал пройден с ошибкой",
                    "Ошибка вычисления",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly
                );

                if (result == DialogResult.OK)
                {
                    // Показать окно заново
                    this.Activate();
                }

                //this.TopMost = true;
            }
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
           ReceiveInput();
        }
     }

    public partial class Function
    {

        static double F1(double x)
        {
            return Math.Log(x, 3);
        }

        static double F2(double x)
        {
            return Math.Sinh(-Math.Pow(4.0, x));
        }

        static double F3(double x)
        {
            return Math.Cos(Math.Abs(-x) / (1.0 + 1.0 / Math.Pow(x, 3)));
        }

        static double F4(double x)
        {
            double res = 0.0;
            int j_max = 1000000;

            for (int j = 1; j <= j_max; j++)
            {
                res += 1.0 / (x + Math.Sqrt(j));
            }
            return res;
        }

        public static double TotalF(double x)
        {
            return F1(x) + F2(x) + F3(x) + F4(x);
        }

        public static double[] Linspace(double start, double stop, int num)
        {
            if (num <= 0)
                throw new ArgumentException("num must be greater than 0");
            if (num == 1)
                return new double[] { start };

            double step = (stop - start) / (num - 1);
            return Enumerable.Range(0, num)
                             .Select(i => start + i * step)
                             .ToArray();
        }
    }
}