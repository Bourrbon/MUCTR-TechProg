using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Значения по умолчанию
        double t_start = 40.0;
        double t_step = 10.0;
        double t_max = 140.0;

        // Опорные температура и вязкость для проверки погрешности
        double t_prov = 40; 
        double eta_prov = 135;

        const double abs_zero = -273.15; // Абсолютный ноль по Цельсию для проверки корректности ввода
        const double epsilon = 1e-6; // Для сравнения двух дробных чисел

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            // Проверяем корректность ввода полей
            bool isCorrectInput = false;
            try
            {
                t_start = Convert.ToDouble(tStartBox.Text);
                t_max = Convert.ToDouble(tMaxBox.Text);
                t_step = Convert.ToDouble(tStepBox.Text);

                if ( (t_start < abs_zero) || (t_max < abs_zero) )
                {
                    throw new Exception("Температура меньше абсолютного нуля");
                }

                if (t_step == 0.0)
                {
                    throw new Exception("Задан нулевой шаг: бесконечный цикл");
                }

                isCorrectInput = true;
            }

            catch (Exception ex)
            {   
                tStartBox.Clear();
                tMaxBox.Clear();
                tStepBox.Clear();
                ValueBox.Clear();
                ValueBox.Text = ex.Message;
            }

            if (isCorrectInput)
            {
                bool CalculationErrorCatched = false;

                ValueBox.Clear();
                ValueBox.AppendText($"{"t(°C)", -10} | {"η (мкП)", +10}" + Environment.NewLine);
                ValueBox.AppendText("----------------------------------------------" + Environment.NewLine);

                for (double t = t_start; t <= t_max; t += t_step)
                {
                    try
                    {
                        // Если достигли опорной температуры, проверяем погрешность
                        if (Math.Abs(t - t_prov) < epsilon)
                        {
                            double res = (Math.Abs(Function.Todos(t) - eta_prov) / eta_prov) * 100;
                            ValueBox.AppendText($"{t,-10} {Math.Round(Function.Todos(t), 2),10}" + Environment.NewLine);
                            ValueBox.AppendText("\tОтносительная погрешность: " + Math.Round(res, 2) + "%" + Environment.NewLine);
                            continue;
                        }

                        ValueBox.AppendText($"{t,-10} {Math.Round(Function.Todos(t), 2),10}" + Environment.NewLine);
                    }

                    catch
                    {
                        ErrorLabel.Text = "Произошла ошибка вычисления";
                        continue;
                    }
                }

                if (!CalculationErrorCatched)
                {
                    ErrorLabel.Text = "ОК";
                }
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            // Взять дату последнего изменения программы
            string path = Assembly.GetExecutingAssembly().Location;
            DateTime dt = File.GetLastWriteTime(path);

            // Взять версию программы
            toolLabel1.Text += Assembly.GetExecutingAssembly().GetName().Version.ToString();
            toolLabel2.Text += Convert.ToString(dt);

            tStartBox.Text = Convert.ToString(t_start);
            tMaxBox.Text = Convert.ToString(t_max);
            tStepBox.Text = Convert.ToString(t_step);
        }
    }

    public class Function
    {
        public static double Todos(double t)
        {
            const double Tc = 430.8;
            const double Pc = 77.8;
            const double M = 64.063;

            double xi = (Math.Pow(Tc, 1.0 / 6.0)) / (Math.Pow(M, 1.0 / 2.0) * Math.Pow(Pc, 2.0 / 3.0));

            double Tr = (t + 273.15) / Tc;

            double etaxi = 4.610 * Math.Pow(Tr, 0.618) - 2.04 * Math.Exp(-0.449 * Tr) + 1.94 * Math.Exp(-4.058 * Tr) + 0.1;

            return etaxi / xi;
        }
    }
}
