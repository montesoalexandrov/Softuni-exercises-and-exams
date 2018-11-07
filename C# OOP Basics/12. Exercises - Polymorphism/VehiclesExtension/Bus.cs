namespace Vehicles
{
    using System;

    public class Bus : Vehicle
    {
        private const double additionalConsumption = 1.4;

        public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity) 
            : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
        }

        protected override double AdditionalConsumption => additionalConsumption;

        public void DriveEmptyBus(double distances)
        {
            double tempConsumption = this.FuelConsumption * distances;

            if (this.FuelQuantity >= tempConsumption)
            {
                this.FuelQuantity -= tempConsumption;
                Console.WriteLine($"{this.GetType().Name} travelled {distances} km");
            }
            else
            {
                Console.WriteLine($"{this.GetType().Name} needs refueling");
            }
        }
    }
}