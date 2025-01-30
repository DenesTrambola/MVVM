namespace MVVM.Presentation.ViewModels;

public class MainContentViewModel : ViewModelBase
{
    public ViewModelBase CurrentViewModel { get; private set; }

    public MainContentViewModel()
    {
        CurrentViewModel = new TitleViewModel();
    }
}
