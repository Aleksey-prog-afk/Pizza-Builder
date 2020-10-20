using System;
using System.Collections.Generic;
using System.Text;

namespace Pizza_Builder.Pizza
{
    abstract class APizza
    {
        private List<string> ingridients = new List<string>();

        public List<string> Ingridients { get => ingridients; private set => ingridients = value; }
       
    }
}
