namespace MVVM.Presentation.ViewModels;

class MainViewModel : ViewModelBase
{
    public ViewModelBase CurrentViewModel { get; private set; }

    public MainViewModel()
    {
        CurrentViewModel = new ItemListViewModel();
    }
}
