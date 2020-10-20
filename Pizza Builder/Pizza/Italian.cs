using System;
using System.Collections.Generic;
using System.Text;

namespace Pizza_Builder.Pizza
{
    class Italian : APizza
    {
        public Italian()
        {
            Ingridients.Add("cheese");
            Ingridients.Add("tomatos");
            Ingridients.Add("olives");
            Ingridients.Add("meat");
        }
    }
}
