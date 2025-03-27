namespace TheQuizzyApp.Views;

public partial class ScorePage : ContentPage
{
	public ScorePage(ScoreViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}
