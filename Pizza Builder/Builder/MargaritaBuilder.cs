using Pizza_Builder.Pizza;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pizza_Builder.Builder
{
    class MargaritaBuilder : IBuilder
    {
        private Margarita margarita = new Margarita();
        public IBuilder addCheese()
        {
            margarita.Ingridients.Add("cheese");
            return this;
        }

        public IBuilder addMeat()
        {
            margarita.Ingridients.Add("meat");
            return this;
        }

        public IBuilder addOlives()
        {
            margarita.Ingridients.Add("olives");
            return this;
        }

        public IBuilder addTomatos()
        {
            margarita.Ingridients.Add("tomatos");
            return this;
        }

        public APizza createPizza()
        {
            return margarita;
        }
    }
}
