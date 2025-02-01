using MVVM.Presentation.State;
using MVVM.Presentation.ViewModels;

namespace MVVM.Presentation.Commands;

public class NavigateTitleCommand : CommandBase
{
    private readonly MainContentNavigationStore _mainContentNavigationStore;

    public NavigateTitleCommand(MainContentNavigationStore mainContentNavigationStore)
    {
        _mainContentNavigationStore = mainContentNavigationStore;
    }

    public override void Execute(object? parameter)
    {
        _mainContentNavigationStore.CurrentViewModel = new TitleViewModel(_mainContentNavigationStore);
    }
}
