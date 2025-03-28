namespace TheQuizzyApp.ViewModels;

public partial class GameViewModel : BaseViewModel
{
	int count = 0;

	[ObservableProperty]
	public string message = "Click me";

    [RelayCommand]
    private async Task RoundDone()
    {
        await Shell.Current.GoToAsync("///GameScorePage");
    }
}
