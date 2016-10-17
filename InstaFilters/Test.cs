using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ImageMagick;
using InstaFilters;

namespace Testing
{
    public class Test
    {
        public Test()
        {

        }
        public void Testing()
        {
            string filterName = "brooklyn";
            // Create a new image (as a placeholder for now)
            MagickImage image = new MagickImage(MagickColors.Red, 100, 100);
            Filter filteredImage = new Filter(image, filterName);
            filteredImage.Generate();
        }
    }
}