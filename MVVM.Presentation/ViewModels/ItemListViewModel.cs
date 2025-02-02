using MVVM.Presentation.Commands;
using MVVM.Presentation.State;
using System.Windows.Input;

namespace MVVM.Presentation.ViewModels;

class ItemListViewModel : ViewModelBase
{
    public ICommand NavigateTitleCommand { get; }

    public ItemListViewModel(MainContentNavigationStore mainContentNavigationStore)
    {
        NavigateTitleCommand = new NavigateCommand<TitleViewModel>(new(mainContentNavigationStore,
            () => new TitleViewModel(mainContentNavigationStore)));
    }
}
