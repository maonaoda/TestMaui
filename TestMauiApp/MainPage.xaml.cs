namespace TestMauiApp;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();

		Microsoft.Maui.Controls.NavigationPage.SetHasNavigationBar(this, false);
	}
}

