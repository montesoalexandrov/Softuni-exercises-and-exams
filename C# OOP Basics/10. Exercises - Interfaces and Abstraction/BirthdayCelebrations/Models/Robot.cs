namespace BirthdayCelebrations.Models
{
    using BirthdayCelebrations.Contracts;

    public class Robot : IIdentifiable
    {
        public string Model { get; }
        public string Id { get; }

        public Robot(string model, string id)
        {
            this.Model = model;
            this.Id = id;
        }
    }
}