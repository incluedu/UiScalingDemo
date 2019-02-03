using System.Windows.Controls;
using System.Windows.Input;

namespace UiScalingDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void UiScaleSlider_OnMouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            ((Slider) sender).Value = 1.0;
        }
    }
}