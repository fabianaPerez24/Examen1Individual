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
            int color;

        public Productos(string name, int size, float price, int color) 
        {

            this.name = name;
            this.size = size;
            this.price = price;
            this.color = color;


        }



    }
}
