using System.Windows.Input;
using TheQuizzyApp.Models;

namespace TheQuizzyApp.ViewModels;

public partial class CategoryViewModel : BaseViewModel
{

    [ObservableProperty]
    public ObservableCollection<Category> categories = new();

    public CategoryViewModel()
    {
        categories.Add(new Category("General Knowledge", "general_knowledge.png", false));
        categories.Add(new Category("Science: Computers", "science_computers.png", false));
        categories.Add(new Category("Science: Gadgets", "science_gadgets.png", false));
        categories.Add(new Category("Science: Mathematics", "science_maths.png", false));
    }

    [RelayCommand]
    private async Task SelectedCategory()
    {
        await Shell.Current.GoToAsync("///GamePage");
    }

    public ICommand SelectCategoryCommand { get; }
    public ICommand ToggleFavoriteCommand { get; }

    private void OnCategorySelected(Category category)
    {
        if (category != null)
        {
            Console.WriteLine($"Selected category: {category.Name}");
            // Navigate to another page or perform an action
        }
    }

    private void OnToggleFavorite(Category category)
    {
        if (category != null)
        {
            category.IsFavorite = !category.IsFavorite;
            Console.WriteLine($"Toggled favorite: {category.Name} is now {(category.IsFavorite ? "Favorited" : "Not Favorited")}");
        }
    }

}
