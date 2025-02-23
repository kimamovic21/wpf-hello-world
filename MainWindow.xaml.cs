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

            //myTextBlock.Text = "Hello from the cs side!";
            //myTextBlock.Foreground = Brushes.Blue;

            TextBlock myTb = new TextBlock();
            myTb.Text = "Hello from the cs side!";
            myTb.Inlines.Add(" this is added using inlines");
            myTb.Inlines.Add(new Run(" Run text that i added in Code behind")
            {
                Foreground = Brushes.Red,
                TextDecorations = TextDecorations.Underline,
            });

            myTb.TextWrapping = TextWrapping.Wrap;
            myTb.Foreground = Brushes.Blue;
            this.Content = myTb;
        }
    }
}