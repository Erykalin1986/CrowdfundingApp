namespace CrowdfundingApp.Views;

public partial class FavoritesPage : ContentPage
{
	public FavoritesPage()
	{
		InitializeComponent();
	}

    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
		DisplayAlert("Alert", "Register clicked!", "Cansel");
    }
}