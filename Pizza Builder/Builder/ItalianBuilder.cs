using Pizza_Builder.Pizza;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pizza_Builder.Builder
{
    class ItalianBuilder : IBuilder
    {
        private Italian italian = new Italian();
        public IBuilder addCheese()
        {
            italian.Ingridients.Add("cheese");
            return this;
        }

        public IBuilder addMeat()
        {
            italian.Ingridients.Add("meat");
            return this;
        }

        public IBuilder addOlives()
        {
            italian.Ingridients.Add("olives");
            return this;
        }

        public IBuilder addTomatos()
        {
            italian.Ingridients.Add("tomatos");
            return this;
        }

        public APizza createPizza()
        {
            return italian;
        }
    }
}
