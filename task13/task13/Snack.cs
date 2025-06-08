using System;   

namespace task13
{
    public class Snack : Dish
    {
        public int WeightInGrams { get; }

        public Snack(string name, string description, decimal price, int weightInGrams)
            : base(name, description, price)
        {
            if (weightInGrams <= 0)
                throw new ArgumentException("Вес должен быть положительным.", nameof(weightInGrams));

            WeightInGrams = weightInGrams;
        }

        public override string[] GetInfo()
        {
            var info = new string[3];
            info[0] = $"Название: {Name}";
            info[1] = $"Описание: {Description}, Цена: {Price:F2} руб.";
            info[2] = $"Вес порции: {WeightInGrams} г";
            return info;
        }
    }
}