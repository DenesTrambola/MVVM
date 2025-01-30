using MVVM.Presentation.ViewModels;
using System.Windows.Controls;

namespace MVVM.Presentation.Components;

public partial class MainContent : UserControl
{
    public MainContent()
    {
        InitializeComponent();
        DataContext = new MainContentViewModel();
    }
}
