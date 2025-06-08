using System;

namespace task13
{
    public class Pizza
    {
        public string Name { get; } = "Неизвестная пицца";

        public string Description { get; set; }
        public int Diameter { get; }
        public PizzaType Type { get; }
        public string[] Ingredients { get; }
        public decimal Price { get; }

        public Pizza(string description, int diameter, PizzaType type, string[] ingredients, decimal price)
        {
            if (diameter <= 0)
                throw new ArgumentException("Диаметр должен быть положительным числом.", nameof(diameter));
            if (price <= 0)
                throw new ArgumentException("Цена должна быть больше нуля.", nameof(price));

            Description = description;
            Diameter = diameter;
            Type = type;
            Ingredients = ingredients ?? throw new ArgumentNullException(nameof(ingredients));
            Price = price;
        }

        public virtual string[] GetInfo()
        {
            var info = new string[2];
            info[0] = $"Название: {Name}";
            info[1] = $"Описание: {Description}, Диаметр: {Diameter} см, Тип: {Type}, Ингредиенты: {string.Join(", ", Ingredients)}, Цена: {Price:C2}";

            return info;
        }
    }
}