using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    public class Store
    {
        public void Start()
        {
            Pizza p1 = new Pizza(40,"\n Salamipizza","Peporoni");
            Pizza p2 = new Pizza(50, "\n Salatpizza", "Kebab");
            Pizza p3 = new Pizza(90,"\n Hawaii","Ananas");

            Customer c1 = new Customer("\n Ole",2);
            Customer c2 = new Customer("\n Per",4);
            Customer c3 = new Customer("\n Jens",6);

            Order o1= new Order(p1,c1);
            Order o2= new Order(p2,c2);
            Order o3 = new Order(p3, c3);



            Console.WriteLine(o1);

            Console.WriteLine(o2);

            Console.WriteLine(o3);

        }

    }
}
