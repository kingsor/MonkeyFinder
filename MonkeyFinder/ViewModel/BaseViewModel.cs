namespace MonkeyFinder.ViewModel;

public partial class BaseViewModel : ObservableObject
{
    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(IsNotBusy))]
    bool isBusy;

    [ObservableProperty]
    string title;

    public bool IsNotBusy => !IsBusy;
}






//[INotifyPropertyChanged]
//public partial class BaseViewModel
//{

//    public BaseViewModel()
//    {

//    }

//    bool isBusy;
//    string title;

//    //public bool IsNotBusy => !IsBusy;
//}





//public class BaseViewModel : INotifyPropertyChanged
//{
//    public event PropertyChangedEventHandler PropertyChanged;

//    bool isBusy;
//    string title;

//    public bool IsBusy
//    {
//        get => isBusy;
//        set
//        {
//            if (isBusy == value)
//                return;

//            isBusy = value;
//            OnPropertyChanged();
//            OnPropertyChanged(nameof(IsNotBusy));
//        }
//    }

//    public string Title
//    {
//        get => title;
//        set
//        {
//            if (title == value)
//                return;

//            title = value;
//            OnPropertyChanged();
//        }
//    }

//    public bool IsNotBusy => !IsBusy;

//    public void OnPropertyChanged([CallerMemberName] string name = null)
//    {
//        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
//    }
//}
