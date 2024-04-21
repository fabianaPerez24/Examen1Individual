using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen
{
    internal class Tienda
    {

        Carrito carrito = new Carrito();

        public void SelectProduct()
        {
            bool continueFlag = true;
            while(true) 
            { 
                
            Console.WriteLine("¿Que desea hacer?");
                Console.WriteLine("1. Agregar un producto");
                Console.WriteLine("2. Ver tus productos");
                Console.WriteLine("3. Finalizar");
                int option;

                if(!int.TryParse(Console.ReadLine(), out option))
                {
                    Console.WriteLine("Opcion no valida");
                }

                switch(option)
                {
                    case 1:
                        AddProduct();
                        break;

                        case 2:
                        ProductList();
                        break;

                    case 3:
                        Console.WriteLine("Gracias por comprar. Contenido del carrito:");
                        carrito.ProductList();
                        break;
                }


            }

            Console.WriteLine("Quieres agregar más productos? Si o No");
            if (Console.ReadLine() == "No")
            {
                continueFlag = false;
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
            Console.WriteLine("Ingrese las caracteristicas de los productos");
            Console.WriteLine("Nombre: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("Color: ");
            string color = Console.ReadLine();
            Console.WriteLine("Precio: ");
            float precio;
            precio = float.Parse(Console.ReadLine());

        }
        public void ProductList()
        {
            carrito.ProductList();

        }

    }
}
