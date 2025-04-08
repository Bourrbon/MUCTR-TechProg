using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    partial class Function
    {
        public double F(double x, double y)
        {
            return Math.Exp(-(x*x + y*y));
        }

        public static void CreateSurfacePlot()
        {
            // <summary>
            // Эта функция делает что-то
            // </summary>
        }
    }
}
