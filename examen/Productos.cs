using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen
{
    internal class Productos: Tienda
    {  
        
        string name;
            int size;
            float price;
            string color;

        public Productos(string name, int size, float price, string color) 
        {

            this.name = name;
            this.size = size;
            this.price = price;
            this.color = color;
        }
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
