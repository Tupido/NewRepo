using task13;


namespace task13Tests
{
    [TestFixture]
    public class PizzaUnitTests
    {
        private Pizza CreateTestPizza()
        {
            return new Pizza(
                name: "Маргарита",
                description: "Итальянская",
                price: 499.9m,
                diameter: 30,
                type: PizzaType.ThinCrust,
                ingredients: new string[] { "сыр", "помидоры", "базилик" }
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

            Assert.That(info.Length, Is.EqualTo(3));
            Assert.That(info[0], Is.EqualTo("Название: Маргарита"));
            Assert.That(info[1], Does.Contain("Итальянская").And.Contain("499"));
            Assert.That(info[2], Does.Contain("30 см").And.Contain("ThinCrust").And.Contain("сыр, помидоры, базилик"));
        }

        [Test]
        public void Constructor_ThrowsExceptionOnInvalidDiameter()
        {
            Assert.Throws<ArgumentException>(() =>
                new Pizza(
                    name: "Ошибка",
                    description: "",
                    price: 100m,
                    diameter: -10,
                    type: PizzaType.ThickCrust,
                    ingredients: Array.Empty<string>()
                ));
        }

        [Test]
        public void Constructor_ThrowsExceptionOnInvalidPrice()
        {
            Assert.Throws<ArgumentException>(() =>
                new Pizza(
                    name: "Ошибка",
                    description: "",
                    price: -50m,
                    diameter: 30,
                    type: PizzaType.ThickCrust,
                    ingredients: Array.Empty<string>()
                ));
        }

        [Test]
        public void Constructor_ThrowsExceptionOnNullIngredients()
        {
            Assert.Throws<ArgumentNullException>(() =>
                new Pizza(
                    name: "Ошибка",
                    description: "",
                    price: 100m,
                    diameter: 30,
                    type: PizzaType.ThickCrust,
                    ingredients: null
                ));
        }
    }
}