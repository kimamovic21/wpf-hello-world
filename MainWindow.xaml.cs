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

        //private void cbCheese_Checked(object sender, RoutedEventArgs e)
        //{
        //    lbCheese.Background = Brushes.Yellow;
        //}

        //private void cbCheese_Unchecked(object sender, RoutedEventArgs e)
        //{
        //    lbCheese.Background = Brushes.White;
        //}

        private void cbParentCheckedChanged(object sender, RoutedEventArgs e)
        {
            bool newValue = (cbParent.IsChecked == true);
            cbCheese.IsChecked = newValue;
            cbTuna.IsChecked = newValue;
            cbPepperoni.IsChecked = newValue;
            cbOlives.IsChecked = newValue;
        }

        private void cbTopingsCheckedChanged(object sender, RoutedEventArgs e)
        {
            cbParent.IsChecked = null;
            if(
                (cbCheese.IsChecked == true) && 
                (cbTuna.IsChecked == true) &&
                (cbPepperoni.IsChecked == true) &&
                (cbOlives.IsChecked == true)
            )
            {
                cbParent.IsChecked = true;
            }
            if (
                (cbCheese.IsChecked == false) &&
                (cbTuna.IsChecked == false) &&
                (cbPepperoni.IsChecked == false) &&
                (cbOlives.IsChecked == false)
            )
            {
                cbParent.IsChecked = false;
            }
        }
    }
}