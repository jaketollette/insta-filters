using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ImageMagick;

namespace InstaFilters
{
    public class Filter
    {
        public string name {get; set;}
        public MagickImage image { get; set;}
        public PointD[] redChannel { get; set; }
        public PointD[] greenChannel { get; set; }
        public PointD[] blueChannel { get; set; }

        public Filter(MagickImage FilterImage, string FilterName)
        {
            name = FilterName;
            image = FilterImage;

            //Apply filter and generate on construct?
            //Generate(image, name);
        }

        public MagickImage Generate()
        {
            
            // Set channels and curve information based on filter
            switch (name)
            {
                case "brooklyn":
                    Brooklyn brooklyn = new Brooklyn();
                    redChannel = brooklyn.redChannel;
                    greenChannel = brooklyn.greenChannel;
                    blueChannel = brooklyn.blueChannel;
                    break;
                case "nashville":
                    Nashville nashville = new Nashville();
                    redChannel = nashville.redChannel;
                    greenChannel = nashville.greenChannel;
                    blueChannel = nashville.blueChannel;
                    break;
                default:
                    //No filter name provided.
                    break;

            }
            return image;
        }

        public MagickImage Vignette(MagickImage image)
        {
            // Do Vignette
            return image;
        }
    }
    
}