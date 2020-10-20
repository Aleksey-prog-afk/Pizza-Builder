using Pizza_Builder.Pizza;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pizza_Builder.Builder
{
    class CarbonaraBuilder : IBuilder
    {
        private Carbonara carbonara = new Carbonara();
        public IBuilder addCheese()
        {
            carbonara.Ingridients.Add("cheese");
            return this;
        }

        public IBuilder addMeat()
        {
            carbonara.Ingridients.Add("meat");
            return this;
        }

        public IBuilder addOlives()
        {
            carbonara.Ingridients.Add("olives");
            return this;
        }

        public IBuilder addTomatos()
        {
            carbonara.Ingridients.Add("tomatos");
            return this;
        }

        public APizza createPizza()
        {
            return carbonara;
        }
    }
}
