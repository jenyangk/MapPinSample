﻿using MapKit;
using UIKit;

namespace MapPinSample
{
    public class CustomAnnotation : MKPointAnnotation
    {
        public Guid Identifier { get; set; }
        public UIImage? Image { get; set; }
    }
}

