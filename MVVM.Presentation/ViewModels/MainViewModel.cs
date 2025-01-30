namespace MVVM.Presentation.ViewModels;

class MainViewModel : ViewModelBase
{
    public ViewModelBase MainContentViewModel { get; private set; }

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


    public MainViewModel()
    {
        Header = "HEADER";
        Footer = "FOOTER";

        MainContentViewModel = new TitleViewModel();
    }
}
