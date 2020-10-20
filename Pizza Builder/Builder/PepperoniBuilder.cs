using Pizza_Builder.Pizza;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pizza_Builder.Builder
{
    class PepperoniBuilder : IBuilder
    {
        private Pepperoni pepperoni = new Pepperoni();
        public IBuilder addCheese()
        {
            pepperoni.Ingridients.Add("cheese");
            return this;
        }

        public IBuilder addMeat()
        {
            pepperoni.Ingridients.Add("meat");
            return this;
        }

        public IBuilder addOlives()
        {
            pepperoni.Ingridients.Add("olives");
            return this;
        }

        public IBuilder addTomatos()
        {
            pepperoni.Ingridients.Add("tomatos");
            return this;
        }

        public APizza createPizza()
        {
            return pepperoni;
        }
    }
}
