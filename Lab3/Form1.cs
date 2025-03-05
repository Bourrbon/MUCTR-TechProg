using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Lab3 : Form
    {
        double F1(double x)
        {
            return Math.Log(x, 3);
        }

        double F2 (double x)
        {
            return Math.Sinh(-Math.Pow(4.0, x));
        }

        double F3(double x)
        {
            return Math.Cos(Math.Abs(-x)/(1.0 + 1.0/Math.Pow(x, 3)));
        }

        double F4(double x)
        {
            double res = 0.0;
            int j_max = 1000000;

            for (int j = 1; j <= j_max; j++)
            {
                res += 1.0 / (x + Math.Sqrt(j));
            }
            return res;
        }

        public Lab3()
        {
            InitializeComponent();
        }

        string errmsg = "Ошибка ввода!";
        double x_start = 0.0;
        double x_end = 0.0;
        int n = 1; // Кол-во разбиений интервала


        private void button1_Click(object sender, EventArgs e)
        {
            bool inputSuccess = false;
            bool cacluationErrorCatched = false;

            try 
            {
                if (!int.TryParse(xNBox.Text, out n) | (Convert.ToInt32(n) <= 0) )
                {
                    throw new ApplicationException("Negative array size");
                }

                x_start = Convert.ToDouble(xStartBox.Text);
                x_end = Convert.ToDouble(xEndBox.Text);
                n = Convert.ToInt32(xNBox.Text);
                xNBox.Text = Convert.ToString(n);

                inputSuccess = true;
                ErrorLabel.Text = "OK";
            } 
            catch
            {  
                ErrorLabel.Text = errmsg;
                xStartBox.Clear();
                xEndBox.Clear();
                xNBox.Clear();
                //throw;
            }

            if (inputSuccess == true)
            {
                //ErrorLabel.Text = "Вычисление...";

                double x_cur = x_start;
                double step = Math.Abs(x_end - x_start) / Convert.ToDouble(n);
                string[] values = new string[n];

                resultBox.Text = $"{"x", -10} {"F(x)", 10} {Environment.NewLine}  ------------------------------------------------------------ {Environment.NewLine}";
                do
                {
                    try
                    {
                        double t = F1(x_cur) + F2(x_cur) + F3(x_cur) + F4(x_cur);
                        if ( double.IsNaN(t) | double.IsInfinity(t) )
                        {
                            values.Append("-");
                            resultBox.AppendText($"{Math.Round(x_cur, 3),-10} {"-", +10} {Environment.NewLine}");
                            throw new ApplicationException("NaN or inf occured"); 
                        }
                        values.Append(Convert.ToString(t));
                        resultBox.AppendText($"{Math.Round(x_cur, 3), -10} {Math.Round(t, 3), +10} {Environment.NewLine}");
                    }
                    catch
                    {
                        cacluationErrorCatched = true;
                        x_cur += step;
                        continue;
                    }

                    x_cur += step;
                }
                while (x_cur <= x_end);
                ErrorLabel.Text = "OK";
            } 
            
            if (cacluationErrorCatched == true)
            {
                DialogResult result = MessageBox.Show(
                    "Интервал пройден с ошибкой",
                    "Ошибка вычисления",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly
                );

                //if (result == DialogResult.OK)
                //{
                //    Environment.Exit(1);
                //}
                this.TopMost = true;
            }
        }
    }
}
