namespace Vehicles
{
    using System;

    public class Truck : Vehicle
    {
        private const double additionalConsumption = 1.6;
        private const double refuelingCoefficient = 0.95;

        public Truck(double fuelQuantity, double fuelConsumption, double tankCapacity)
            : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
        }

        protected override double AdditionalConsumption => additionalConsumption;

        public override void Refuel(double refuelQuantity)
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
                base.FuelQuantity += refuelQuantity * refuelingCoefficient;
            }
        }
    }
}