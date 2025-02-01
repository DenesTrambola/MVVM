using MVVM.Presentation.Commands;
using MVVM.Presentation.State;
using System.Windows.Input;

namespace MVVM.Presentation.ViewModels;

class ItemListViewModel : ViewModelBase
{
    private readonly MainContentNavigationStore _mainContentNavigationStore;
    public ICommand NavigateTitleCommand { get; }

    public ItemListViewModel(MainContentNavigationStore mainContentNavigationStore)
    {
        _mainContentNavigationStore = mainContentNavigationStore;

        NavigateTitleCommand = new NavigateCommand<TitleViewModel>(_mainContentNavigationStore,
            () => new TitleViewModel(_mainContentNavigationStore));
    }
}
