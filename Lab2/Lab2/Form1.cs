﻿using System;
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

        public static double todos(double t)
        {
            const double Tc = 430.8;
            const double Pc = 77.8;
            const double M = 64.063;

            double xi = (Math.Pow(Tc, 1.0 / 6.0)) / (Math.Pow(M, 1.0 / 2.0) * Math.Pow(Pc, 2.0 / 3.0));

            double Tr = (t + 273.15) / Tc;

            double etaxi = 4.610 * Math.Pow(Tr, 0.618) - 2.04 * Math.Exp(-0.449 * Tr) + 1.94 * Math.Exp(-4.058 * Tr) + 0.1;

            return etaxi / xi;
        }

        double t = 0.0;
        double t_start = 40.0;
        double t_step = 10.0;
        double t_max = 140.0;
        double t_prov = 40;
        double eta_prov = 135;


        double ref_n = 135.0;
        double res = 0.0;
        double epsilon = 0.0001;
        string err_msg = "Ошибка ввода...";

        private void button1_Click(object sender, EventArgs e)
        {
            //Для пользовательского ввода с клавиатуры
            bool CorrectInput = false;
            try
            {
                t_start = Convert.ToDouble(tStartBox.Text);
                t_max = Convert.ToDouble(tEndBox.Text);
                t_step = Convert.ToDouble(tDeltaBox.Text);

                CorrectInput = true;
            }

            catch
            {
                tStartBox.Clear();
                tEndBox.Clear();
                tDeltaBox.Clear();
                ValueBox.Clear();
                ValueBox.Text = err_msg;
            }

            if (CorrectInput)
            {
                ValueBox.Clear();
                ValueBox.AppendText($"{"t(°C)", -10} | {"η (мкП)", +10}" + Environment.NewLine);
                ValueBox.AppendText("----------------------------------------------" + Environment.NewLine);
                for (t = t_start; t <= t_max; t += t_step)
                {
                    if (Math.Abs(t - t_prov) < epsilon)
                    {
                        double res = (Math.Abs(todos(t) - eta_prov) / eta_prov) * 100;
                        ValueBox.AppendText($"{t, -10} {Math.Round(todos(t), 2), 10}" + Environment.NewLine);
                        ValueBox.AppendText("\tОтносительная погрешность: " + Math.Round(res, 2) + "%" + Environment.NewLine);
                        continue;
                    }

                    ValueBox.AppendText($"{t,-10} {Math.Round(todos(t), 2),10}" + Environment.NewLine);
                }
            }

        }

        private void status_strip_text(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string path = Assembly.GetExecutingAssembly().Location;
            DateTime dt = File.GetLastWriteTime(path);

            toolLabel1.Text += Assembly.GetExecutingAssembly().GetName().Version.ToString();
            toolLabel2.Text += Convert.ToString(dt);

            tStartBox.Text = Convert.ToString(t_start);
            tEndBox.Text = Convert.ToString(t_max);
            tDeltaBox.Text = Convert.ToString(t_step);
        }

    }
}
