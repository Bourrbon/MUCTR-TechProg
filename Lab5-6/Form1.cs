using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void InputBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ReceiveBoolInput();
            }
        }

        public void ReceiveBoolInput()
        {
            bool inputSuccess = false;
            try
            {
                bool inp = false;
                if (InputBox.Text == "1" || InputBox.Text.ToLower() == "true")
                {
                    inp = true;
                }
                else if (InputBox.Text == "0" || InputBox.Text.ToLower() == "false")
                {
                    inp = false;
                }
                else
                {
                    throw new Exception("Invalid Input: cannot convert to bool");
                }

                VarStorage varobject = new VarStorage(inp);
                OutputBox.Text = Convert.ToString(varobject.var);
            }
            catch (Exception ex)
            {
                // Вызываем диалоговое окно с сообщением об ошибке
                DialogResult result = MessageBox.Show(
                ex.Message,
                "Ошибка ввода",
                MessageBoxButtons.AbortRetryIgnore,
                MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly
                                                    );
                //this.TopMost = false;
                

                switch (result)
                {
                    case DialogResult.Abort: Environment.Exit(1); break;
                    case DialogResult.Ignore: break;
                    case DialogResult.Retry: ReceiveBoolInput(); break;
                }
            }
        }
    }

    public class VarStorage
    {
        public bool var;
        // Конструктор класса
        public VarStorage(bool var)
        {
            this.var = var;
        }
    }

    public class Function
    {
        public double F31(double x, double y)
        {
            double temp = Math.Pow(-2*y/(x*x), 1.0/3.0);
            if ( double.IsNaN(temp) || double.IsInfinity(temp) )
            {
                return double.NaN;
            }
            return Math.Sin(temp);
        }
    }
}
