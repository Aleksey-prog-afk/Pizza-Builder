using Pizza_Builder.Pizza;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pizza_Builder.Builder
{
    interface IBuilder
    {
        public IBuilder addCheese();
        public IBuilder addMeat();
        public IBuilder addOlives();
        public IBuilder addTomatos();
        public APizza createPizza();

    }
}
