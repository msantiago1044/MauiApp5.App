namespace MauiApp5.Views.ExplorateFeatures;

public partial class MapSamplePage : ContentPage
{
	public MapSamplePage()
	{
		InitializeComponent();
        Mapa();
	}
	public async void Mapa()
	{
        var location = new Location(47.645160, -122.1306032);
        var options = new MapLaunchOptions { Name = "Microsoft Building 25" };

        try
        {
            await Map.Default.OpenAsync(location, options);
        }
        catch (Exception ex)
        {
            // No map application available to open
        }
    }
}