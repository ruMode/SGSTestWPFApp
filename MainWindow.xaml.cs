using SGSTestWPFApp.ViewModels;
using System.Windows;

namespace SGSTestWPFApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            DataContext = new MainPageVM();
            InitializeComponent();
        }
    }
}