namespace MauiShellTabExample.Views;

public class PageE : ContentPage
{
	public PageE()
	{
		Content = new VerticalStackLayout
		{
			Children = {
				new Label { HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center, Text = nameof(this.Title)
				}
			}
		};
	}
}