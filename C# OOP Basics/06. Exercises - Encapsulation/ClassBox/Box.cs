namespace ClassBox
{
    class Box
    {
        private double length;
        private double width;
        private double height;

        public Box(double length, double width, double height)
        {
            this.length = length;
            this.width = width;
            this.height = height;
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