using MVVM.Presentation.State;
using MVVM.Presentation.ViewModels;

namespace MVVM.Presentation.Commands;

public class NavigateCommand<TViewModel> : CommandBase
    where TViewModel : ViewModelBase
{
    private readonly MainContentNavigationStore _mainContentNavigationStore;
    private readonly Func<TViewModel> _createViewModel;

    public NavigateCommand(MainContentNavigationStore mainContentNavigationStore, Func<TViewModel> createViewModel)
    {
        _mainContentNavigationStore = mainContentNavigationStore;
        _createViewModel = createViewModel;
    }

    public override void Execute(object? parameter)
    {
        _mainContentNavigationStore.CurrentViewModel = _createViewModel();
    }
}
