using System;
using System.Collections.Generic;
using System.Text;

namespace Pizza_Builder.Pizza
{
    class Pepperoni : APizza
    {
        public Pepperoni()
        {
            Ingridients.Add("cheese");
            Ingridients.Add("tomatos");
            Ingridients.Add("meat");
        }
    }
}
