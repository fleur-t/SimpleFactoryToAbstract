using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryToAbstract.Pizza.ChicagoStyle
{
    internal class CaliforniaStylePepperoniPizza : Pizza
    {
        public CaliforniaStylePepperoniPizza()
        {
            name = "California Style Pepperoni Pizza";
            dough = "Thin Crust Dough";
            sauce = "Marinara Sauce";
            toppings.Add("Sliced Pepperoni");
            toppings.Add("Fresh Mozzarella Cheese");
            toppings.Add("Fresh Basil");
        }
        internal override void Cut()
        {
            Console.WriteLine("Cutting the pizza into triangle slices");
        }
    }
}
