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

        public string material { get; set; }
        
        public override string ProductDetails()
        {
            return "Nombre: " + name + "Tamaño: " + size + "Material: " + material + "Color: " + color + "Precio: " + price;

        }
    }

}