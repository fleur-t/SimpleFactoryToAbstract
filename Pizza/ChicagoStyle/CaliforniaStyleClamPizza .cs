using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryToAbstract.Pizza.ChicagoStyle
{
    internal class CaliforniaStyleClamPizza : Pizza
    {
        public CaliforniaStyleClamPizza()
        {
            name = "California Style Clam Pizza";
            dough = "Thin Crust Dough";
            sauce = "Garlic White Sauce";
            toppings.Add("Fresh Clams");
            toppings.Add("Mozzarella Cheese");
            toppings.Add("Fresh Parsley");
        }
        internal override void Cut()
        {
            Console.WriteLine("Cutting the pizza into triangle slices");
        }
    }
}
