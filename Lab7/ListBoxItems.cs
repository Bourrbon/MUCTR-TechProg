using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Lab7
{
    public partial class ListBoxItems
    {
        private ListBox leftListBox;
        private ListBox rightListBox;

        public ListBoxItems(ListBox left, ListBox right)
        {
            leftListBox = left;
            rightListBox = right;
        }


        public void AddItem(ListBox listBox, string item)
        {
            if (!string.IsNullOrEmpty(item) && !listBox.Items.Contains(item))
            {
                listBox.Items.Add(item);
            }
            else
            {
                throw new Exception("Ошибка добавления пункта в ListBox");
            }
        }

        public void RemoveItem(ListBox listBox, object item)
        {
            if (item != null && listBox.Items.Contains(item))
            {
                listBox.Items.Remove(item);
            }
            else
            {
                throw new Exception("Ошибка удаления пункта из ListBox");
            }
        }

        public void MoveItem(ListBox source, ListBox dest)
        {
            // Автоматически переместит один или несколько выбранных пунктов
            var selectedItems = source.SelectedItems.Cast<object>().ToList();

            if (selectedItems.Count > 0)
            {
                foreach (var item in selectedItems)
                {
                    AddItem(dest, item.ToString());
                }
                foreach (var item in selectedItems)
                {
                    RemoveItem(source, item);
                }
            }
            else
            {
                throw new Exception("Выберите элементы для перемещения");
            }
        }



        public void LoadDataFromFile(string filePath)
        {
            try
            {
                if (File.Exists(filePath))
                {
                    // Очищаем оба ListBox от текущих данных перед загрузкой
                    leftListBox.Items.Clear();
                    rightListBox.Items.Clear();

                    string[] lines = File.ReadAllLines(filePath);

                    // Проверяем, что файл содержит хотя бы 2 строки
                    if (lines.Length >= 2)
                    {
                        // Загружаем первую строку в левый ListBox
                        if (!string.IsNullOrEmpty(lines[0]))
                        {
                            string[] leftItems = lines[0].Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                            foreach (string item in leftItems)
                            {
                                AddItem(leftListBox, item.Trim());
                            }
                        }

                        // Загружаем вторую строку в правый ListBox
                        if (!string.IsNullOrEmpty(lines[1]))
                        {
                            string[] rightItems = lines[1].Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                            foreach (string item in rightItems)
                            {
                                AddItem(rightListBox, item.Trim());
                            }
                        }
                    }
                    else
                    {
                        throw new Exception("Файл должен содержать ровно 2 строки");
                    }
                }
                else
                {
                    throw new Exception("Файл не найден");
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Ошибка при загрузке: {ex.Message}");
            }
        }

        public void SaveDataToFile(string filePath)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    // Сохраняем элементы левого ListBox в первой строке
                    string leftItems = string.Join(",", leftListBox.Items.Cast<object>().Select(item => item.ToString()));
                    writer.WriteLine(leftItems);

                    // Сохраняем элементы правого ListBox во второй строке
                    string rightItems = string.Join(",", rightListBox.Items.Cast<object>().Select(item => item.ToString()));
                    writer.WriteLine(rightItems);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Ошибка при сохранении: {ex.Message}");
            }
        }
    }
}
