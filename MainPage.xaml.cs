using Microsoft.Maui.Maps;
using Microsoft.Maui.Controls.Maps;

namespace MapPinSample;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        LoadPins();
    }

    private void LoadPins()
    {
        Location location = new Location(20.7986, -156.3324);

        Pin normalPin = new Pin
        {
            Label = "Normal Pin",
            Type = PinType.Place,
            Location = new Location(20.7983, -156.3874)
        };

        normalPin.MarkerClicked += async (sender, e) =>
        {
            e.HideInfoWindow = true;
            await DisplayAlert("Pin Clicked", $"{((Pin)sender).Label} was clicked.", "Ok");
        };

        var imageData = File.ReadAllBytes("red_circle.png");
        Pin customPin = new CustomPin
        {
            Map = mapB,
            Label = "Custom Pin",
            Type = PinType.Place,
            Location = new Location(20.8013, -156.2881),
            ImageSource = ImageSource.FromStream(() => new MemoryStream(imageData))
        };

        customPin.MarkerClicked += async (sender, e) =>
        {
            e.HideInfoWindow = true;
            await DisplayAlert("Pin Clicked", $"{((Pin)sender).Label} was clicked.", "Ok");
        };

        mapA.Pins.Add(normalPin);
        mapA.MoveToRegion(MapSpan.FromCenterAndRadius(location, Distance.FromKilometers(10)));

        mapB.Pins.Add(customPin);
        mapB.MoveToRegion(MapSpan.FromCenterAndRadius(location, Distance.FromKilometers(10)));
    }
}


