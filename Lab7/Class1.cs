using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab7
{
    public partial class ListBoxItems
    {
        //// Начальные значения
        public string[] leftBoxItems = { "Пункт 1", "Пункт 2", "Пункт 3" };
        public string[] rightBoxItems =  { "Пункт 4", "Пункт 5" };
        public string defaultFilePath = Directory.GetCurrentDirectory();


        public static string[][] GetDataFromFile(string filePath)
        {
            if ( (filePath == null) || (!File.Exists(filePath)) )
            {
                throw new Exception("Invalid File Path");
            }

            string[][] data = { };

            using (StreamReader reader= new StreamReader(filePath))
            {
                data = File.ReadAllLines(filePath)
                    .Select(line => line.Split(',')
                    .Select(word => word.Trim())
                    .ToArray())
                    .ToArray();
            }

            return data;
        }


        public static void LoadDataToFile(string filePath, string[][] data)
        {
            if ( (filePath == null) || (!File.Exists(filePath)) )
            {
                throw new Exception("Invalid File Path");
            }

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (string[] ss in data)
                {
                    writer.WriteLine(ss);
                }
            }
        }
    }
}
