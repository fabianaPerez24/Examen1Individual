using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen
{
    internal class Tienda
    {
        int productos;
        public void SelectProduct()
        {
            bool continueFlag = true;
            while(true) 
            { 
            Console.WriteLine("Selecciona los productos que vas a comprar");

            Console.WriteLine($"el precio total de los productos es: ");



             Console.WriteLine("Quieres agregar más productos? Si o No");
                if( Console.ReadLine() == "No") 
                {
                    continueFlag = false;
                }
            }
        }

        public void ReturnPrice()
        {

        }
        public void TotalPrice() 
        {

        }
        public void ProductDetail() 
        {

        }
        protected void AddProduct()
        {

        }
    }
}
