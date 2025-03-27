namespace TheQuizzyApp.Views;

public partial class PlayerSelectionPage : ContentPage
{
	public PlayerSelectionPage(PlayerSelectionViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}
