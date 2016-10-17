using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ImageMagick;

namespace InstaFilters
{
    public class Brooklyn 
    {
        public readonly PointD[] redChannel;
        public readonly PointD[] greenChannel;
        public readonly PointD[] blueChannel;

        public Brooklyn()
        {
            redChannel = new PointD[5];
            redChannel[0] = new PointD(0, 0);
            redChannel[1] = new PointD(50, 50);
            redChannel[2] = new PointD(99, 99);

            greenChannel = new PointD[5];
            greenChannel[0] = new PointD(0, 0);
            greenChannel[1] = new PointD(50, 50);
            greenChannel[2] = new PointD(99, 99);

            blueChannel = new PointD[5];
            blueChannel[0] = new PointD(0, 0);
            blueChannel[1] = new PointD(50, 50);
            blueChannel[2] = new PointD(99, 99);
        }
    }

}