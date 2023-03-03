using MauiShellTabExample.Views;

namespace MauiShellTabExample;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();



		Routing.RegisterRoute("PageA", typeof(PageA));
		Routing.RegisterRoute("PageB", typeof(PageB));
		Routing.RegisterRoute("PageC", typeof(PageC));
		Routing.RegisterRoute("PageD", typeof(PageD));
		Routing.RegisterRoute("PageE", typeof(PageE));
	}
}
