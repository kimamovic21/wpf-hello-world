﻿using System.Text;
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

        private void DatePicker_SelectedDateChange(object sender, SelectionChangedEventArgs e)
        {
            if((sender as DatePicker).SelectedDate != null)
            {
                string myDate = (sender as DatePicker).SelectedDate.ToString();
                MessageBox.Show("Date has been changed to " + myDate);
            }
        }
    }
}