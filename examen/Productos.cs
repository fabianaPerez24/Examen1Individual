using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen
{
    internal class Productos: Tienda
    {
        public string name { get; set; }
        public string color { get; set; }
        public float price { get; set; }
        public float size { get; set; }

        public virtual string ProductDetails()
        {
            return name + size + price + color;
        }
        public float GetPrice()
        {
            return price;
        }


    }
}
