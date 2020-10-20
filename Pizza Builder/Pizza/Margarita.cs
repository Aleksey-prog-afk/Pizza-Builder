using System;
using System.Collections.Generic;
using System.Text;

namespace Pizza_Builder.Pizza
{
    class Margarita : APizza
    {
        public Margarita()
        {
            Ingridients.Add("cheese");
            Ingridients.Add("tomatos");
            Ingridients.Add("olives");
        }
    }
}
