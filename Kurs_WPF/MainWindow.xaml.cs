using System.Windows;
using System.Windows.Controls.Primitives;
using System.Windows.Navigation;


namespace Kurs_WPF
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ContentFrame.Navigate(new Page1()); // Default page
        }

        private void GoToPage1(object sender, RoutedEventArgs e)
        {
            ContentFrame.Navigate(new Page1());
        }

        private void GoToPage2(object sender, RoutedEventArgs e)
        {
            ContentFrame.Navigate(new Page2());
        }

        private void OpenPopup_Click(object sender, RoutedEventArgs e)
        {
            popup.IsOpen = true;
        }
    }
}
