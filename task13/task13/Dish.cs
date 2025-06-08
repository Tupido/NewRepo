using System;

namespace task13
{
    public abstract class Dish
    {
        public string Name { get; }
        public string Description { get; set; }
        public decimal Price { get; }

        protected Dish(string name, string description, decimal price)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Название не может быть пустым.", nameof(name));
            if (price <= 0)
                throw new ArgumentException("Цена должна быть больше нуля.", nameof(price));

            Name = name;
            Description = description;
            Price = price;
        }

        public abstract string[] GetInfo();
    }
}