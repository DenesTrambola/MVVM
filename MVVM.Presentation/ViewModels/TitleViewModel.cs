using MVVM.Presentation.Commands;
using MVVM.Presentation.State;
using System.Windows.Input;

namespace MVVM.Presentation.ViewModels;

class TitleViewModel : ViewModelBase
{
    private string _title;
    public string Title
    {
        get { return _title; }
        set
        {
            _title = value;
            OnPropertyChanged(nameof(Title));
        }
    }

    public ICommand NavigateItemListCommand { get; }

    public TitleViewModel(MainContentNavigationStore mainContentNavigationStore)
    {
        Title = "TITLE";

        NavigateItemListCommand = new NavigateCommand<ItemListViewModel>(new(mainContentNavigationStore,
            () => new ItemListViewModel(mainContentNavigationStore)));
    }
}
