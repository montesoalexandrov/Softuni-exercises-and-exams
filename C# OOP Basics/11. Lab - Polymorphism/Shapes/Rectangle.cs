﻿namespace Shapes
{
    public class Rectangle : Shape
    {
        private double width;
        private double height;

        public Rectangle(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width
        {
            get
            {
                return width;
            }
            private set
            {
                width = value;
            }
        }

        public double Height
        {
            get
            {
                return height;
            }
            private set
            {
                height = value;
            }
        }

        public override double CalculateArea()
        {
            return this.Width * this.Height;
        }

        public override double CalculatePerimeter()
        {
            return 2 * this.Width + 2 * this.Height;
        }

        public override string Draw()
        {
            return base.Draw() + this.GetType().Name;
        }
    }
}