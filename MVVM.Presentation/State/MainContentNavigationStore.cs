using MVVM.Presentation.ViewModels;

namespace MVVM.Presentation.State;

public class MainContentNavigationStore
{
    public event Action CurrentViewModelChanged;

    private ViewModelBase _currentViewModel;
    public ViewModelBase CurrentViewModel
    {
        get => _currentViewModel;
        set
        {
            if (_currentViewModel != value) _currentViewModel = value;
            OnCurrentViewModelChanged();
        }
    }

    private void OnCurrentViewModelChanged()
    {
        CurrentViewModelChanged?.Invoke();
    }
}
