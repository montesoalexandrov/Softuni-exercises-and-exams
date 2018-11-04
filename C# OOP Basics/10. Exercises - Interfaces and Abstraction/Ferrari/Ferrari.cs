namespace Ferrari
{
    public class Ferrari : ICar
    {
        public string Model { get; set; }
        public string Driver { get; set; }

        public Ferrari(string driver)
        {
            this.Model = "488-Spider";
            this.Driver = driver;
        }

        public string PushBrakes()
        {
            return "Brakes!";
        }

        public string PushGas()
        {
            return "Zadu6avam sA!";
        }

        public override string ToString()
        {
            return $"{this.Model}/{PushBrakes()}/{PushGas()}/{this.Driver}";
        }
    }
}