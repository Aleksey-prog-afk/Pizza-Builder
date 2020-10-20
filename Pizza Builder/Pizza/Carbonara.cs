using System;
using System.Collections.Generic;
using System.Text;

namespace Pizza_Builder.Pizza
{
    class Carbonara : APizza
    {
        public Carbonara()
        {
            Ingridients.Add("cheese");
            Ingridients.Add("tomatos");            
        }
    }
}
