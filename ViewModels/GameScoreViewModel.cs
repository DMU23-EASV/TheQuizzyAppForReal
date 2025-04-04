namespace TheQuizzyApp.ViewModels;

public partial class GameScoreViewModel : BaseViewModel
{
	int count = 0;

	[ObservableProperty]
	public string message = "Click me";

	[RelayCommand]
	private async Task EndGame()
	{
		await Shell.Current.GoToAsync("///ScorePage");
	}

	[RelayCommand]
	private async Task NewQuestion()
	{
		await Shell.Current.GoToAsync("///GamePage");
	}

}
