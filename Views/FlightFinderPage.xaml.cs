using FlightApp.Models;

namespace FlightApp.Views;

public partial class FlightFinderPage : ContentPage
{



    public FlightFinderPage()
    {
        InitializeComponent();

        List<Flight> flights = FlightsRepo.GetFlights();

        ListOfFlights.ItemsSource = flights;

    }

    private void Reutrn_home_From_finder_page_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("..");
    }

    private void ListOfFlights_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        Shell.Current.GoToAsync(nameof(FlightFinderPage));
    }
}