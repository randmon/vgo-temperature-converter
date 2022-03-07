using System.Windows;
using System.Windows.Controls;

namespace View
{
    /// <summary>
    /// Interaction logic for TemperatureScaleControl.xaml
    /// </summary>
    public partial class TemperatureScaleControl : UserControl
    {
        public TemperatureScaleControl()
        {
            InitializeComponent();
        }

        public string Header
        {
            get { return (string)GetValue(HeaderProperty); }
            set { SetValue(HeaderProperty, value);}
        }

        public static readonly DependencyProperty HeaderProperty = DependencyProperty.Register("Header", typeof(string), typeof(TemperatureScaleControl), new PropertyMetadata(""));
    }
}
