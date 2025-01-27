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

    public TitleViewModel()
    {
        Title = "HELLO WORLD!";
    }
}
