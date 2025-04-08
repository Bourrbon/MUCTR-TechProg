using ScottPlot;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lab9
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void PlotButton_Click(object sender, RoutedEventArgs e)
        {
            Function.CreateSurfacePlot();

            WpfPlot1.Plot.Clear();
            WpfPlot2.Plot.Clear();

            //double[] dataX = { 1, 2, 3, 4, 5 };
            //double[] dataY = { 1, 4, 9, 16, 25 };

            double[] dataX = XBox.Text
                                    .Split(new[] { ',', ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                                    .Select(s => double.Parse(s))
                                    .ToArray();

            double[] dataY = YBox.Text
                                   .Split(new[] { ',', ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                                   .Select(s => double.Parse(s))
                                   .ToArray();

            WpfPlot1.Plot.Add.Scatter(dataX, dataY);
            WpfPlot1.Plot.Title("Вариант 13");
            WpfPlot1.Plot.XLabel("X values");
            WpfPlot1.Plot.YLabel("Y values");
            WpfPlot1.Refresh();

            var hist = ScottPlot.Statistics.Histogram.WithBinCount(dataX.Length, dataX);

            // Display the histogram as a bar plot
            var barPlot = WpfPlot2.Plot.Add.Bars(dataX, dataY);
            WpfPlot2.Plot.Title("Вариант 13");
            WpfPlot2.Plot.XLabel("X values");
            WpfPlot2.Plot.YLabel("Y values");

            WpfPlot1.Refresh();
            WpfPlot2.Refresh();
        }

    }
}