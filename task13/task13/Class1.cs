using System;

namespace task13
{
    public class Pizza
    {
        public readonly string name;
        public string description;
        public double diameter;
        public PizzaType Type;
        public string[] additionalIngredients;
        public decimal price;

        public Pizza(string name, string description, double diameter, PizzaType type, string[] additionalIngredients, decimal price)
        {
            this.name = name ?? throw new ArgumentException(nameof(name));
            this.description = description;
            this.diameter = diameter > 0 ? diameter : throw new ArgumentOutOfRangeException(nameof(diameter), "Введите нормальное значение диаметра");
            this.Type = type;
            this.additionalIngredients = additionalIngredients ?? Array.Empty<string>();
            this.price = price >= 0 ? price : throw new ArgumentOutOfRangeException(nameof(price), "Введите нормальное значение цены");
        }
        public double Diameter
        {
            get => diameter;
            set
            {
                if (value > 0)
                    diameter = value;
                else
                    throw new ArgumentOutOfRangeException(nameof(value), "Введите нормальный диаметр");
            }
        }
     
        public string[] AddIng
        {
            get => additionalIngredients;
            set => additionalIngredients = value ?? Array.Empty<string>();
        }
        public decimal Price
        {
            get => price; 
            set
            {
                if (value >= 0)
                    price = value;
                else throw new ArgumentOutOfRangeException(nameof(value), "Введите нормальную цену");
            }
        }
        public virtual string[] GetInfo()
        {
            var info = new string[2];
            info[0] = $"{name} {description}";

            string type;
            if (Type == PizzaType.Thin)
                type = "Тонкая";
            else if (Type == PizzaType.Thick)
                type = "Толстая";
            else
                type = "Закрытая";

            info[1] = $"Диаметр: {diameter} см, Тип: {type}, Цена: {price:C}";
            return info;
        }
    }
}
