using task13;

namespace task13Test
{
    [TestFixture]
    public class Tests
    {

        [Test]
        public void ConstructorTest()
        {
            var pizza = CreateTestPizza();

            Assert.That(pizza.name, Is.EqualTo("Пепперони"));
            Assert.That(pizza.description, Is.EqualTo("Пицца с сыром и салями"));
            Assert.That(pizza.diameter, Is.EqualTo(30));
            Assert.That(pizza.Type, Is.EqualTo(PizzaType.Thin));
            Assert.That(pizza.additionalIngredients, Is.EqualTo(expected: new string[] { "Сыр" }));
            Assert.That(pizza.price, Is.EqualTo(600));
        }

        [Test]
        public void GetInfoTest()
        {
            var pizza = CreateTestPizza();
            var info = pizza.GetInfo();

            Assert.That(info.Length, Is.EqualTo(2));
            Assert.That(info[0], Is.EqualTo("Пепперони. Пицца с сыром и салями"));
            Assert.That($"Описание: Пицца с сыром и салями. Диаметр: 30 см. Тип: Тонкая. Дополнительные ингредиенты: Сыр. Цена: 600.", 
                Is.EqualTo(info[1]));
        }

        private Pizza CreateTestPizza()
        {
            return new Pizza("Пепперони", "Пицца с сыром и салями", 30, PizzaType.Thin, new string[] {"Сыр"}, 600);
        }
    }
}