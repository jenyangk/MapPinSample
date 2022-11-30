using MapKit;
using Microsoft.Maui.Maps.Handlers;

namespace MapPinSample
{
    public class CustomPinHandler : MapPinHandler
    {
        protected override IMKAnnotation CreatePlatformElement() => new CustomAnnotation();
    }
}

