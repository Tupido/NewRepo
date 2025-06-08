using System;
using task13;


namespace task13Tests
{
    [TestFixture]
    public class PizzaUnitTests
    {
        private Pizza CreateTestPizza()
        {
            return new Pizza(
                description: "Итальянская",
                diameter: 30,
                type: PizzaType.ThinCrust,
                ingredients: new string[] { "сыр", "помидоры", "базилик" },
                price: 499.9m
            );
        }

        [Test]
        public void Constructor_SetsPropertiesCorrectly()
        {
            var pizza = CreateTestPizza();

            Assert.That(pizza.Description, Is.EqualTo("Итальянская"));
            Assert.That(pizza.Diameter, Is.EqualTo(30));
            Assert.That(pizza.Type, Is.EqualTo(PizzaType.ThinCrust));
            Assert.That(pizza.Ingredients, Has.Length.EqualTo(3));
            Assert.That(pizza.Price, Is.EqualTo(499.9m));
        }

        [Test]
        public void GetInfo_ReturnsValidInfo()
        {
            var pizza = CreateTestPizza();
            var info = pizza.GetInfo();

            Assert.That(info.Length, Is.EqualTo(2));
            Assert.That(info[0], Is.EqualTo("Название: Неизвестная пицца"));
            StringAssert.Contains("Итальянская", info[1]);
            StringAssert.Contains("30 см", info[1]);
            StringAssert.Contains("ThinCrust", info[1]);
            StringAssert.Contains("сыр, помидоры, базилик", info[1]);
            StringAssert.Contains("499", info[1]);
        }

        [Test]
        public void Constructor_ThrowsExceptionOnInvalidDiameter()
        {
            Assert.Throws<ArgumentException>(() =>
                new Pizza("", -10, PizzaType.ThickCrust, new string[0], 100));
        }

        [Test]
        public void Constructor_ThrowsExceptionOnInvalidPrice()
        {
            Assert.Throws<ArgumentException>(() =>
                new Pizza("", 30, PizzaType.ThickCrust, new string[0], -50));
        }

        [Test]
        public void Constructor_ThrowsExceptionOnNullIngredients()
        {
            Assert.Throws<ArgumentNullException>(() =>
                new Pizza("", 30, PizzaType.ThickCrust, null, 100));
        }
    }
}