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

namespace WPFHelloWorld
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //myLabel.Foreground = Brushes.Coral;

            double myFontSize = myLabel.FontSize;
            myLabel.FontSize = myFontSize + 1;
        }

        private void myButton_MouseDoubleClick(object sender, RoutedEventArgs e)
        {
            double myFontSize = myLabel.FontSize;
            myLabel.FontSize = myFontSize - 2;
        }

        private void myButton_MouseEnter(object sender, MouseEventArgs e)
        {
            myLabel.Foreground = Brushes.Blue;
        }

        private void myButton_MouseLeave(object sender, MouseEventArgs e)
        {
            myLabel.Foreground = Brushes.Black;
        }
    }
}