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
        public Form1()
        {
            InitializeComponent();

            ListBoxItems lbi = new ListBoxItems();

            listBox1.DataSource = lbi.leftBoxItems;
            listBox2.DataSource = lbi.rightBoxItems;
        }

        private void FileSaveButton_Click(object sender, EventArgs e)
        {
            // Вызываем диалог выбора файла
            saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            saveFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();

            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = saveFileDialog1.FileName;

            //ListBoxItems.LoadDataToFile(filename, listBox1.Items );
        }
    }
}
