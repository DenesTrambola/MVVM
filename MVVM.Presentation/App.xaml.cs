using MVVM.Presentation.State;
using MVVM.Presentation.ViewModels;
using System.Windows;

namespace MVVM.Presentation;

public partial class App : Application
{
    protected override void OnStartup(StartupEventArgs e)
    {
        MainContentNavigationStore mainContentNavigationStore = new();
        mainContentNavigationStore.CurrentViewModel = new ItemListViewModel(mainContentNavigationStore);

        MainWindow = new MainWindow()
        {
            DataContext = new MainViewModel(mainContentNavigationStore)
        };
        MainWindow.Show();

        base.OnStartup(e);
    }
}
