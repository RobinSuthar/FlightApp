namespace FlightApp.Views;

public partial class FlightFinderPage : ContentPage
{



    public FlightFinderPage()
    {
        InitializeComponent();

        List<Flight> flights = new List<Flight>()
    {
        new Flight { FlightName = "Birtish Airline", Departure = "GLC", Day = "Monday" },
        new Flight { FlightName = "Qatar  Airline", Departure = "GLC", Day = "Monday" },
        new Flight { FlightName = "Indian Airline", Departure = "GLC", Day = "Monday" }
    };

        ListOfFlights.ItemsSource = flights;

    }

    private void Reutrn_home_From_finder_page_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("..");
    }


    public class Flight()
    {
        public string FlightName { get; set; }
        public string Departure { get; set; }
        public string Day { get; set; }
    }
}