using System;

namespace task13
{
    public enum DrinkType
    {
        Cold,
        Hot
    }

    public class Drink : Dish
    {
        public DrinkType Type { get; }
        public int VolumeInMl { get; }

        public Drink(string name, string description, decimal price, DrinkType type, int volumeInMl)
            : base(name, description, price)
        {
            if (volumeInMl <= 0)
                throw new ArgumentException("Объём должен быть положительным.", nameof(volumeInMl));

            Type = type;
            VolumeInMl = volumeInMl;
        }

        public override string[] GetInfo()
        {
            var info = new string[3];
            info[0] = $"Название: {Name}";
            info[1] = $"Описание: {Description}, Цена: {Price:F2} руб.";
            info[2] = $"Тип: {Type}, Объём: {VolumeInMl} мл";
            return info;
        }
    }
}