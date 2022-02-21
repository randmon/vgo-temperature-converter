using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace View
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            this.DataContext = new ConverterViewModel();
        }
    }
}
