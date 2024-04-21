using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace examen
{
    internal class Arcilla: Productos
    {
        int weight;
        public Arcilla(int weight, string name,)
        {
            this.weight = weight;
            
        }
        public override string ProductDetails()
        {
            return name + size + price + color + material;
        }
    }
}
