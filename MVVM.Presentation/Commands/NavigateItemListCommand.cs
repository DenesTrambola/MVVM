using MVVM.Presentation.State;
using MVVM.Presentation.ViewModels;

namespace MVVM.Presentation.Commands;

public class NavigateItemListCommand : CommandBase
{
    private readonly MainContentNavigationStore _mainContentNavigationStore;

    public NavigateItemListCommand(MainContentNavigationStore mainContentNavigationStore)
    {
        _mainContentNavigationStore = mainContentNavigationStore;
    }

    public override void Execute(object? parameter)
    {
        _mainContentNavigationStore.CurrentViewModel = new ItemListViewModel(_mainContentNavigationStore);
    }
}
