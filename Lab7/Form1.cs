using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab7
{
    public partial class Form1 : Form
    {
        private ListBoxItems lbi = null;

        public Form1()
        {
            InitializeComponent();

            lbi = new ListBoxItems(LeftBox, RightBox);
        }

        private void FileSaveButton_Click(object sender, EventArgs e)
        {
            // Вызываем диалог выбора файла
            saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            saveFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();

            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
            {
                ErrorLabel.Text = "Выбор файла отменён";
                return;
            }

            // получаем выбранный файл
            string filename = saveFileDialog1.FileName;
            try
            {
                lbi.SaveDataToFile(filename);
                ErrorLabel.Text = "Данные сохранены";
            }
            catch (Exception ex)
            {
                ErrorLabel.Text = ex.Message;
            }
        }

        private void FileLoadButton_Click(object sender, EventArgs e)
        {
            // Вызываем диалог выбора файла
            openFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            openFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();

            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
            {
                ErrorLabel.Text = "Выбор файла отменён";
                return;
            }

            // получаем выбранный файл
            string filename = openFileDialog1.FileName;
            try
            {
                lbi.LoadDataFromFile(filename);
                ErrorLabel.Text = "Данные загружены";
            }
            catch (Exception ex)
            {
                ErrorLabel.Text = ex.Message;
            }
           
        }

        private void ShiftRightButton_Click(object sender, EventArgs e)
        {
            try
            {
                lbi.MoveItem(LeftBox, RightBox);
                ErrorLabel.Text = "Данные перемещены (L -> R)";
            }
            catch (Exception ex)
            {
                ErrorLabel.Text = ex.Message;
            }
        }

        private void ShiftLeftButton_Click(object sender, EventArgs e)
        {
            try
            {
                lbi.MoveItem(RightBox, LeftBox);
                ErrorLabel.Text = "Данные перемещены (R -> L)";
            }
            catch (Exception ex)
            {
                ErrorLabel.Text = ex.Message;
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
