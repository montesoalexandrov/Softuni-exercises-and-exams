using System;

namespace Vehicles
{
    public abstract class Vehicle
    {
        public Vehicle(double fuelQuantity, double fuelConsumption, double tankCapacity)
        {
            if (fuelQuantity > tankCapacity)
            {
                fuelQuantity = 0;
            }

            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
            this.TankCapacity = tankCapacity;
        }

        public double FuelQuantity { get; set; }

        public double FuelConsumption { get; set; }

        public double TankCapacity { get; set; }

        protected abstract double AdditionalConsumption { get; }

        public virtual void Drive(double distances)
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
            if (refuelQuantity <= 0)
            {
                Console.WriteLine("Fuel must be a positive number");
            }
            else if (this.FuelQuantity + refuelQuantity > this.TankCapacity)
            {
                Console.WriteLine($"Cannot fit {refuelQuantity} fuel in the tank");
            }
            else
            {
                this.FuelQuantity += refuelQuantity;
            }
        }
    }
}