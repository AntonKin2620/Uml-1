using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    public class Order
    {
        private Pizza _pizza;
        private Customer _customer;
        public Order(Pizza pizza, Customer customer)
        {
            _pizza = pizza;
            _customer = customer;
        }
        public override string ToString()
        {
            return $"\n Bestilling: {_pizza}, \n til: {_customer} \n TotalPrice: {TotalPrice}"; 
        }
        int delivery = 40;
        double tax = 1.25;
        double TotalPrice
        {
            get { return (_pizza.Price + delivery) * tax; }
        }


    }
}
