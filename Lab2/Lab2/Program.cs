using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Lab2 {



    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        public static double todos(double t)
        {
            const double Tc = 430.8;
            const double Pc = 77.8;
            const double M = 64.063;

            double xi = (Math.Pow(Tc, 1.0/6.0)) / (Math.Pow(M, 1.0/2.0) * Math.Pow(Pc, 2.0/3.0)); 

            double Tr = (t + 273.15) / Tc;

            double etaxi = 4.610*Math.Pow(Tr, 0.618) - 2.04*Math.Exp(-0.449*Tr) + 1.94*Math.Exp(-4.058*Tr) + 0.1;

            return etaxi / xi;
        }

        
        [STAThread]
        
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());


        }
    }
}
