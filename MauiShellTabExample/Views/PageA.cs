namespace MauiShellTabExample.Views;

public class PageA : ContentPage
{


	public PageA()
	{
        InitPage();
    }

	void InitPage()
	{
        Console.WriteLine(this.Title);
        Content = new VerticalStackLayout
        {
            Children = {
                new Label { HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center, Text =this.Title
                }
            }
        };

    }
}