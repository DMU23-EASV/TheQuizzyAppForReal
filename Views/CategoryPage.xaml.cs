﻿namespace TheQuizzyApp.Views;

public partial class CategoryPage : ContentPage
{
	public CategoryPage(CategoryViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}
