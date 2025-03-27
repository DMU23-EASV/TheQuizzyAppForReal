namespace TheQuizzyApp.ViewModels;

public partial class MainViewModel : BaseViewModel
{

    [ObservableProperty]
    public string btnStartText = "Start";

    [ObservableProperty]
    public string btnHowToText = "Spillets regler";


    [RelayCommand]
    private async Task StartGame()
    {
        await Shell.Current.GoToAsync("///PlayerSelectionPage");
    }

}
