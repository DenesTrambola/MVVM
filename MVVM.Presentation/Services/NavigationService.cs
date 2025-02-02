using MVVM.Presentation.State;
using MVVM.Presentation.ViewModels;

namespace MVVM.Presentation.Services;

public class NavigationService<TViewModel>
    where TViewModel : ViewModelBase
{
    private readonly MainContentNavigationStore _mainContentNavigationStore;
    private readonly Func<TViewModel> _createViewModel;

    public NavigationService(MainContentNavigationStore mainContentNavigationStore, Func<TViewModel> createViewModel)
    {
        _mainContentNavigationStore = mainContentNavigationStore;
        _createViewModel = createViewModel;
    }
    public void Navigate() =>
        _mainContentNavigationStore.CurrentViewModel = _createViewModel();
}
