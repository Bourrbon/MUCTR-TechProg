using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Windows.Forms;

enum En : byte
{
    e1,
    e2,
    e3
};

namespace Lab1
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            long l = 256000;
            const short c = 124;
            double[] d = {-1.5, 0.5, 1.3, 12.9 };

            l /= c;

            for (int i = 0; i < d.Length; i++)
            {
                d[i] *= 2;
            }

            //const En en_var = En.e2;
        }
    }
}
