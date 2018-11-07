namespace Vehicles
{
    public class Car : Vehicle
    {
        private const double additionalConsumption = 0.9;

        public Car(double fuelQuantity, double fuelConsumption)
            : base(fuelQuantity, fuelConsumption)
        {
        }

        protected override double AdditionalConsumption => additionalConsumption;
    }
}