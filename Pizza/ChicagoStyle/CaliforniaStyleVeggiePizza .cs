using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryToAbstract.Pizza.ChicagoStyle
{
    internal class CaliforniaStyleVeggiePizza : Pizza
    {
        public CaliforniaStyleVeggiePizza()
        {
            name = "California Style Veggie Pizza";
            dough = "Thin Crust Dough";
            sauce = "Marinara Sauce";
            toppings.Add("Grilled Vegetables");
            toppings.Add("Goat Cheese");
            toppings.Add("Fresh Basil");
        }

        internal override void Cut()
        {
            Console.WriteLine("Cutting the pizza into triangle slices");
        }
    }
}
