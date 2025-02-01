using MVVM.Presentation.State;

namespace MVVM.Presentation.ViewModels;

class MainViewModel : ViewModelBase
{
    private readonly MainContentNavigationStore _mainContentNavigationStore;
    public ViewModelBase MainContentViewModel => _mainContentNavigationStore.CurrentViewModel;

    private string _header;

    public string Header
    {
        get { return _header; }
        set
        {
            _header = value;
            OnPropertyChanged(nameof(Header));
        }
    }

    private string _footer;

    public string Footer
    {
        get { return _footer; }
        set
        {
            _footer = value;
            OnPropertyChanged(nameof(Footer));
        }
    }


    public MainViewModel(MainContentNavigationStore mainContentNavigationStore)
    {
        Header = "HEADER";
        Footer = "FOOTER";

        _mainContentNavigationStore = mainContentNavigationStore;
        _mainContentNavigationStore.CurrentViewModelChanged += OnMainContentViewModelChanged;
    }

    private void OnMainContentViewModelChanged()
    {
        OnPropertyChanged(nameof(MainContentViewModel));
    }
}
