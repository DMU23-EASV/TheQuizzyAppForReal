namespace TheQuizzyApp.Views;

public partial class GameScorePage : ContentPage
{
	public GameScorePage(GameScoreViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}
