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

        double t = 0.0;
        double t_start = 40.0;
        double t_step = 10.0;
        double t_max = 140.0;


        double ref_n = 135.0;
        double res = 0.0;
        string err_msg = "Ошибка ввода...";

        private void button1_Click(object sender, EventArgs e)
        {
            //string inp = textBox1.Text;
            


            res = Program.todos(40.0);
            textBox2.Text = Convert.ToString(Math.Round(res, 0));
            double rel = Math.Abs(res - ref_n) / ref_n;
            textBox3.Text = Convert.ToString(Math.Round(rel * 100, 2)) + "%";

            for (t = t_start; t <= t_max; t += t_step)
            {
                res = Program.todos(t);
                string ts = "t = " + Convert.ToString(t) + " ℃";
                string etas = "η = " + Convert.ToString(Math.Round(res, 0)) + "  мкП";
                listBox1.Items.Add(string.Format("{0, -16}{1, 16}", ts, etas));
            }
            listBox1.Items.Add("");

            // Для пользовательского ввода с клавиатуры

            //if (Double.TryParse(inp, out t))
            //{
            //    res = Program.todos(40.0);
            //    textBox2.Text = Convert.ToString(Math.Round(res, 0));
            //    double rel = Math.Abs(res - ref_n) / ref_n;
            //    textBox3.Text = Convert.ToString(Math.Round(rel * 100, 2)) + "%";

            //    for (t = t_start; t <= t_max; t += t_step)
            //    {
            //        res = Program.todos(t);
            //        string ts = "t = " + Convert.ToString(t) + " ℃";
            //        string etas = "η = " + Convert.ToString(Math.Round(res, 0)) + "  мкП";
            //        listBox1.Items.Add(string.Format("{0, -16}{1, 16}", ts, etas));
            //    }

            //}
            //else
            //{
            //    textBox2.Text = err_msg;
            //    textBox3.Text = err_msg;
            //}
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

            textBox1.Text = Convert.ToString(t_start);
            textBox4.Text = Convert.ToString(t_max);
            textBox5.Text = Convert.ToString(t_step);
        }

    }
}
