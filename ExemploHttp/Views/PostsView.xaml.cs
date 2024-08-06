using ExemploHttp.ViewModels;

namespace ExemploHttp.Views;

public partial class PostsView : ContentPage
{
	public PostsView()
	{
		BindingContext = new PostsViewModel();
		InitializeComponent();
	}
}