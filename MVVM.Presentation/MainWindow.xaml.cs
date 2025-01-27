using MVVM.Presentation.ViewModels;
using System.Windows;

namespace MVVM.Presentation
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new TitleViewModel();
        }
    }
}