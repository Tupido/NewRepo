using task13;

namespace task13Tests
{
    [TestFixture]
    public class OrderTests
    {
        private Pizza margherita;
        private Pizza pepperoni;
        private Pizza hawaiian;
        private Pizza anotherMargherita;

        [SetUp]
        public void Setup()
        {
            margherita = CreateTestPizza("Маргарита", 30);
            pepperoni = CreateTestPizza("Пепперони", 35);
            hawaiian = CreateTestPizza("Гавайская", 30);
            anotherMargherita = CreateTestPizza("Маргарита", 25); 
        }

        [Test]
        public void Order_AddPizzas_DoesNotAllowDuplicates()
        {
            var order = new Order("Иван", "ул. Ленина", "+79123456789");

            order.AddPizza(margherita);
            order.AddPizza(margherita);

            Assert.That(order.Count, Is.EqualTo(1));
        }

        [Test]
        public void Order_Enumerable_ReturnsAllAddedPizzas()
        {
            var order = new Order("Петр", "ул. Гоголя", "+79991112233");
            order.AddPizza(margherita);
            order.AddPizza(pepperoni);

            var pizzas = order.ToList();

            Assert.That(pizzas.Count, Is.EqualTo(2));
            Assert.That(pizzas[0], Is.SameAs(margherita));
            Assert.That(pizzas[1], Is.SameAs(pepperoni));
        }

        [Test]
        public void Pizza_Comparable_SortsByNameThenByDiameter()
        {
            var list = new List<Pizza> { pepperoni, anotherMargherita, margherita, hawaiian };
            list.Sort();

            Assert.That(list[0].Name, Is.EqualTo("Гавайская"));
            Assert.That(list[1].Name, Is.EqualTo("Маргарита"));
            Assert.That(list[1].Diameter, Is.EqualTo(25)); 
            Assert.That(list[2].Name, Is.EqualTo("Маргарита"));
            Assert.That(list[2].Diameter, Is.EqualTo(30));
            Assert.That(list[3].Name, Is.EqualTo("Пепперони"));
        }

        private Pizza CreateTestPizza(string name, int diameter)
        {
            return new Pizza(
                name: name,
                description: "Тестовая пицца",
                price: 399.9m,
                diameter: diameter,
                type: PizzaType.ThinCrust,
                ingredients: new[] { "сыр", "помидор" }
            );
        }
    }
}