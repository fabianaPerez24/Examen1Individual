using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace examen
{
    internal class Tela : Productos
    {
        int material;
        public Tela(int material)
        {
            this.material = material;
        }
        public override string ProductDetails()
        {
            return name + size + price + color + material;
        }
    }

}