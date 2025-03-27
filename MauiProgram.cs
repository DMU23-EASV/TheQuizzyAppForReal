namespace TheQuizzyApp;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.UseMauiCommunityToolkit()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("MaterialIcons-Regular.ttf", "MaterialSymbol");
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

		builder.Services.AddSingleton<MainViewModel>();

		builder.Services.AddSingleton<MainPage>();

		builder.Services.AddSingleton<PlayerSelectionViewModel>();

		builder.Services.AddSingleton<PlayerSelectionPage>();

		builder.Services.AddSingleton<CategoryViewModel>();

		builder.Services.AddSingleton<CategoryPage>();

		builder.Services.AddSingleton<GameViewModel>();

		builder.Services.AddSingleton<GamePage>();

		builder.Services.AddSingleton<ScoreViewModel>();

		builder.Services.AddSingleton<ScorePage>();

		builder.Services.AddSingleton<GameScoreViewModel>();

		builder.Services.AddSingleton<GameScorePage>();

		builder.Services.AddSingleton(AudioManager.Current);

		return builder.Build();
	}
}
