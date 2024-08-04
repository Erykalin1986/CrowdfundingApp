using CrowdfundingApp.ViewModels;
using System.Globalization;

namespace CrowdfundingApp.Views;

public partial class ChatsPage : ContentPage
{
    public List<DonationsValuesModel> DonationsValuesList { get; set; }
    public ChatsPage()
    {
        InitializeComponent();
        DonationsValuesList = new()
        {
            new DonationsValuesModel()
            {
                DonationValue = 5
            },
            new DonationsValuesModel()
            {
                DonationValue = 10
            },
            new DonationsValuesModel()
            {
                DonationValue = 15
            },
            new DonationsValuesModel()
            {
                DonationValue = 20
            },
            new DonationsValuesModel()
            {
                DonationValue = 25
            },
            new DonationsValuesModel()
            {
                DonationValue = 30
            }
        };
        BindingContext = this;
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        thePicker.SelectedIndex = 0;
        donationsValuesCV.SelectedItem = DonationsValuesList.FirstOrDefault();
    }

    private void donationsValuesCV_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        DonationsValuesModel? selectedDonationValue = e.CurrentSelection[0] as DonationsValuesModel;
        if (selectedDonationValue != null) selectedDonationValueSpan.Text = String.Format(new CultureInfo("en-US"), "{0:N2}", selectedDonationValue.DonationValue);
    }
}