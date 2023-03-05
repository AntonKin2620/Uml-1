using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    public class Customer
    {
        private string _name;
        private int _customerID;

        public Customer(string name,int customerID)
        {
            _name = name;
            _customerID = customerID;
        }
        public string name { get { return _name; } }
        public int customerID { get { return _customerID; } }

        public override string ToString()
        {
            return $"\nCustomer name: {name}\nCustomer Id:{customerID}";
        }
    }
}
