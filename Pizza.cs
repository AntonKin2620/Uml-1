using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    public class Pizza
    {
        private double _price;
        private string _name;
        private string _toppings;

        public Pizza(double price, string name,string toppings)
        {
            _price = price;
            _name = name;
            _toppings = toppings;
        }
        public double Price { get { return _price; } }

        public string Name { get { return _name;} }

        public string Toppings { get { return _toppings;} }

        public override string ToString()
        {
            return $"\n En pizza: {Name}, Pris: {Price}, Topping: {Toppings}";
        }

    }
}
