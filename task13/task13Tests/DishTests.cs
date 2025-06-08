using task13;

namespace task13Tests
{
    [TestFixture]
    public class DishTests
    {
        [Test]
        public void Pizza_GetInfo_ReturnsCorrectInfo()
        {
            var pizza = new Pizza("Маргарита", "Классическая пицца", 399.9m, 30, PizzaType.ThinCrust,
                new[] { "сыр", "помидоры", "базилик" });

            var info = pizza.GetInfo();

            Assert.That(info.Length, Is.EqualTo(3));
            Assert.That(info[0], Does.Contain("Маргарита"));
            Assert.That(info[1], Does.Contain("399"));
            Assert.That(info[2], Does.Contain("30 см"));
        }

        [Test]
        public void Drink_GetInfo_ReturnsCorrectInfo()
        {
            var drink = new Drink("Чай", "Зелёный чай", 79.9m, DrinkType.Hot, 250);
            var info = drink.GetInfo();

            Assert.That(info.Length, Is.EqualTo(3));
            Assert.That(info[0], Does.Contain("Чай"));
            Assert.That(info[1], Does.Contain("79"));
            Assert.That(info[2], Does.Contain("250 мл"));
        }

        [Test]
        public void Snack_GetInfo_ReturnsCorrectInfo()
        {
            var snack = new Snack("Фри", "Картошка фри", 129.9m, 150);
            var info = snack.GetInfo();

            Assert.That(info.Length, Is.EqualTo(3));
            Assert.That(info[0], Does.Contain("Фри"));
            Assert.That(info[1], Does.Contain("129"));
            Assert.That(info[2], Does.Contain("150 г"));
        }
    }
}