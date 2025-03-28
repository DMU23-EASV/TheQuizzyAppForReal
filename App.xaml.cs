namespace TheQuizzyApp;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new CategoryPage(new CategoryViewModel());
	}
}
