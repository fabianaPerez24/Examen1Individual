using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace examen
{
    internal class Tienda
    {

        Carrito carrito = new Carrito();


            bool continueFlag = true;
        public void SelectProduct()
        {

           
            while(true) 
            { 
                
            Console.WriteLine("¿Que desea hacer?");
                Console.WriteLine("1. Agregar un producto");
                Console.WriteLine("2. Ver tus productos");
                Console.WriteLine("3. Finalizar");
                string option= Console.ReadLine();

                switch(option)
                {
                    case "1":
                        AddProduct();


                        break;

                        case "2":
                        ProductList();
                        break;

                    case "3":
                        Console.WriteLine("Gracias por comprar. Contenido del carrito:");
                        carrito.ProductList();
                        Console.WriteLine("Quieres agregar más productos? Si o No");
                        if (Console.ReadLine() == "No")
                        {
                            continueFlag = false;
                        }
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
            string name = Console.ReadLine();
            Console.WriteLine("Color: ");
            string color = Console.ReadLine();
            Console.WriteLine("Precio: ");
            float price;


            Console.WriteLine("Que producto deseas agregar Tela/Arcilla");

            string respuesta = Console.ReadLine();

            if (respuesta.ToUpper() == "Tela")
            {
                Console.WriteLine("Elegiste Tela\n");
                Console.WriteLine("Tamaño:");
                string size = Console.ReadLine();

                Console.WriteLine("Material: ");
                string material = Console.ReadLine();

                carrito.AddProduct(new Tela
                {
                    name = name,
                    color = color,
                    price = price,
                    size = size,
                    material = material,
                });
            }

            else
            {
                Console.WriteLine("Elegiste Arcilla\n");
                Console.WriteLine("Peso:");
                float weight;

                if (!float.TryParse(Console.ReadLine(), out weight))
                {
                    Console.WriteLine("Peso invalido");
                    break;
                }
                carrito.AddProduct(new Arcilla
                {
                    name = name,
                    color = color,
                    price = price,
                    weight = weight,
                });
                Console.WriteLine("Producto agregado al carrito de compras");
            }

        }
        public void ProductList()
        {
            carrito.ProductList();

        }

    }
}
