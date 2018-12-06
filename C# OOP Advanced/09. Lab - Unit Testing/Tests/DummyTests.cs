namespace Tests
{
    using NUnit.Framework;

    public class DummyTests
    {
        [Test]
        public void DummyLooseHealthIfAttacked()
        {
            int dummyHealth = 10;
            int dummyExperience = 50;
            int attackPoints = 5;
            int expectedValue = 5;

            Dummy dummy = new Dummy(dummyHealth, dummyExperience);
            dummy.TakeAttack(attackPoints);

            Assert.AreEqual(expectedValue, dummy.Health);
        }

        [Test]
        public void DummyIsDeadThrow()
        {
            int dummyHealth = 0;
            int dummyExperience = 50;
            int attackPoints = 5;

            Dummy dummy = new Dummy(dummyHealth, dummyExperience);

            Assert.That(() => dummy.TakeAttack(attackPoints), Throws.InvalidOperationException.With.Message.EqualTo("Dummy is dead."));
        }

        [Test]
        public void DeadDummyCanGiveExperience()
        {
            int dummyHealth = 5;
            int dummyExperience = 50;
            int expectedValue = 50;

            Hero hero = new Hero("Pesho");
            Dummy dummy = new Dummy(dummyHealth, dummyExperience);

            hero.Attack(dummy);

            Assert.AreEqual(expectedValue, hero.Experience);
        }

        [Test]
        public void AliveDummyCantGiveExperience()
        {
            int dummyHealth = 11;
            int dummyExperience = 50;
            int expectedValue = 0;

            Hero hero = new Hero("Pesho");
            Dummy dummy = new Dummy(dummyHealth, dummyExperience);

            hero.Attack(dummy);

            Assert.AreEqual(expectedValue, hero.Experience);
        }
    }
}