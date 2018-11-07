using System;

namespace Vehicles
{
    public abstract class Vehicle
    {
        public Vehicle(double fuelQuantity, double fuelConsumption)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
        }

        public double FuelQuantity { get; set; }
            
        public double FuelConsumption { get; set; }

        protected abstract double AdditionalConsumption { get; }

        public void Drive(double distances)
        {
            double tempConsumption = (this.FuelConsumption + this.AdditionalConsumption) * distances;

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

        public virtual void Refuel(double refuelQuantity)
        {
            this.FuelQuantity += refuelQuantity;
        }
    }
}