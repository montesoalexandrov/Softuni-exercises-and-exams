using System;

namespace ClassBoxDataValidation
{
    class Box
    {
        private double length;
        private double width;
        private double height;

        public double Length
        {
            get { return length; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Length cannot be zero or negative.");
                }
                length = value;
            }
        }

        public double Width
        {
            get { return width; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Width cannot be zero or negative.");
                }
                width = value;
            }
        }

        public double Height
        {
            get { return height; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Height cannot be zero or negative.");
                }
                height = value;
            }
        }

        public Box(double length, double width, double height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }

        public string GetSurfaceArea()
        {
            double surface = 2 * (length * width + length * height + width * height);
            return $"Surface Area - {surface:f2}";
        } 

        public string GetLateralSurfaceArea()
        {
            double lateralSurfaceArea = 2 * (length * height + width * height);
            return $"Lateral Surface Area - {lateralSurfaceArea:f2}";
        }

        public string GetVolume()
        {
            double volume = length * width * height;
            return $"Volume - {volume:f2}";
        }
    }
}