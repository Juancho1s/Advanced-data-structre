using Avalonia.Controls;
using Avalonia.Interactivity;

namespace GraphicInterface.Views
{
    public partial class TreeWindow : Window
    {
        public TreeWindow()
        {
            InitializeComponent();
        }

        public void windowGraph(object sendetr, RoutedEventArgs e)
        {
            MainWindow mW = new();
            mW.Show();
            this.Close();
        }
    }
}
