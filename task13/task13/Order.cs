using System;
using System.Collections;
using System.Collections.Generic;

namespace task13
{
    public class Order : IEnumerable<Pizza>
    {
        public string CustomerName { get; }
        public string Address { get; }
        public string Phone { get; }

        private List<Pizza> _pizzas = new List<Pizza>();

        public Order(string customerName, string address, string phone)
        {
            CustomerName = customerName ?? throw new ArgumentNullException(nameof(customerName));
            Address = address ?? throw new ArgumentNullException(nameof(address));
            Phone = phone ?? throw new ArgumentNullException(nameof(phone));
        }

        public void AddPizza(Pizza pizza)
        {
            if (!_pizzas.Contains(pizza))
                _pizzas.Add(pizza);
        }

        public void RemovePizza(Pizza pizza)
        {
            _pizzas.Remove(pizza);
        }

        public int Count => _pizzas.Count;

        public IEnumerator<Pizza> GetEnumerator() => _pizzas.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}