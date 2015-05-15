using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lens_Data_File_Creator
{
    class Point
    {
        public int indexX = 0;
        public int indexY = 0;

        public double MeasuredX = 0.0d;
        public double MeasuredY = 0.0d;

        public Point()
        {
            this.indexX = 0;
            this.indexY = 0;
            this.MeasuredX = 0.0d;
            this.MeasuredY = 0.0d;
        }

        public Point(int iindexX, int iindexY, double dMeasuredX, double dMeasuredY)
        {
            this.indexX = iindexX;
            this.indexY = iindexY;
            this.MeasuredX = dMeasuredX;
            this.MeasuredY = dMeasuredY;
        }
      
    }
}
