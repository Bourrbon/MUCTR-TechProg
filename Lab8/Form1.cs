using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            filterBox.SelectedIndex = 0;
            TransformOutputBox.SelectedIndex = 2;
            LetterSelector.Show();
            LetterSelector.SelectedIndex = 0;
        }


        private void filterBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (filterBox.SelectedItem)
            {
                case "Элементы, начинающиеся на...":
                case "Элементы, содержащие...":
                    LetterSelector.Visible = true;
                    LetterSelector.Enabled = true;
                    break;
                case "Только числа": 
                case "Только знаки + и -":
                case "Считывать всё":
                    LetterSelector.Visible = false;
                    LetterSelector.Enabled = false;
                    break;
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                ErrorMessageLabel.Text = "Поиск...";
                if (LetterSelector.SelectedItem == null)
                {
                    throw new Exception("Поле поиска не может быть пустым");
                }

                //string[][] res = SearchClass.Search();
                //SearchClass.Print(res, OutputBox);

            }
            catch (Exception ex)
            {
                ErrorMessageLabel.Text = ex.Message;
            }

        }
    }
}
