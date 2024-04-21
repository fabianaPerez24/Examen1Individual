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
        public string weight { get; set; }

        public override string ProductDetails()
        {
            return "Nombre: " + name + "Tamaño: " + size + "Peso" + weight + "Color: " + color + "Precio: " + price;

        }
    }
}
