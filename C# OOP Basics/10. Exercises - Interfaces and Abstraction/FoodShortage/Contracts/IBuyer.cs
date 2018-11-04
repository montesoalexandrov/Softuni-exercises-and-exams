
namespace FoodShortage.Contracts
{
    using BirthdayCelebrations.Contracts;

    public interface IBuyer : IName
    {
        int Food { get; }

        void BuyFood();
    }
}