using System.Numerics;

namespace TheQuizzyApp.ViewModels;

public partial class PlayerSelectionViewModel : BaseViewModel
{
    [RelayCommand]
    private async Task StartGame()
    {
        await Shell.Current.GoToAsync("///CategoryPage");
    }
}
