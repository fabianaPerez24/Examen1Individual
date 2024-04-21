using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen
{
    internal class Carrito: Tienda
    {
        private List<Productos> productos = new List<Productos>();

        public void AddProducts(Productos products)
        {
            productos.Add(products);
        }
        public float CalculatePrecioTotal()
        {
            float precioTotal = 0;
            foreach (var producto in productos)
            {
                precioTotal += producto.GetPrice();
            }
            return precioTotal;
        }
        public void ProductList()
        {
            Console.WriteLine("Productos del carrito:");
            foreach (var producto in productos)
            {
                Console.WriteLine(producto.ProductDetails());
            }
            Console.WriteLine("Precio total:" + CalculatePrecioTotal());
        }
    }
}
