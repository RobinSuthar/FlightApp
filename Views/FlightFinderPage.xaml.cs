namespace FlightApp.Views;

public partial class FlightFinderPage : ContentPage
{
	public FlightFinderPage()
	{
		InitializeComponent();
	}

    private void Reutrn_home_From_finder_page_Clicked(object sender, EventArgs e)
    {
		Shell.Current.GoToAsync("..");
    }
}