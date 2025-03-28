namespace TheQuizzyApp.ViewModels;

public partial class GameScoreViewModel : BaseViewModel
{
	int count = 0;

	[ObservableProperty]
	public string message = "Click me";

	[RelayCommand]
	private async Task NavigateHome()
	{
		await Shell.Current.GoToAsync("///MainPage");
	}
}
