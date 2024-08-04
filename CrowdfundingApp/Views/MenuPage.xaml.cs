namespace CrowdfundingApp.Views;

public partial class MenuPage : ContentPage
{
    public MenuPage()
    {
        InitializeComponent();
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        this.thePicker.SelectedIndex = 0;
    }
}