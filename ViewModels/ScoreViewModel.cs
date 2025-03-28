namespace TheQuizzyApp.ViewModels;

public partial class ScoreViewModel : BaseViewModel
{
	int count = 0;

	[ObservableProperty]
	public string cancleBtn = "Cancle";

	[ObservableProperty]
	public string restartBtn = "Restart Game";

	[RelayCommand]
	private async Task RestartGame() 
	{
		await Shell.Current.GoToAsync("///GamePage");
	}

	[RelayCommand]
	private async Task Cancled()
	{
		await Shell.Current.GoToAsync("///GameScorePage");
	}
}
