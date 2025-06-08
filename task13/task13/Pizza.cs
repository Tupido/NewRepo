using System;

namespace task13
{
    public class Pizza : Dish
    {
        public int Diameter { get; }
        public PizzaType Type { get; }
        public string[] Ingredients { get; }

        public Pizza(string name, string description, decimal price,
                     int diameter, PizzaType type, string[] ingredients)
            : base(name, description, price)
        {
            if (diameter <= 0)
                throw new ArgumentException("Диаметр должен быть положительным числом.", nameof(diameter));

            Diameter = diameter;
            Type = type;
            Ingredients = ingredients ?? throw new ArgumentNullException(nameof(ingredients));
        }

        public override string[] GetInfo()
        {
            var info = new string[3];
            info[0] = $"Название: {Name}";
            info[1] = $"Описание: {Description}, Цена: {Price:F2} руб.";
            info[2] = $"Диаметр: {Diameter} см, Тип: {Type}, Ингредиенты: {string.Join(", ", Ingredients)}";
            return info;
        }
    }
}