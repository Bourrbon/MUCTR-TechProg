using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab8
{
    public partial class SearchClass
    {
        //public static string[][] Search()
        //{
        //    //string[][] res = new string[2][]{ {"das", "dasda"}, {"wrew", "cxvxcv"} };
        //    return res;
        //}

        public static void Print(string[][] input, TextBox tb)
        {
            foreach (string[] s in input)
            {
                foreach(string s2 in s)
                {
                    tb.Text += s2 + ' ';
                }
                tb.Text += Environment.NewLine;
            }
        }
    }
}
