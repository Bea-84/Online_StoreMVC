using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_StoreMVC.View 
{
    internal class MenuView
    {

        public string vistaMenu()
        {
            string opcion;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("1. Gestión articulos");
            Console.WriteLine("2. Gestión clientes");
            Console.WriteLine("3. Gestión pedidos");
            Console.WriteLine("0. Salir");
            Console.ForegroundColor = ConsoleColor.Gray; 
            opcion = pedirOpcionMenu();
            Console.WriteLine();
            Console.WriteLine();
            return opcion;
        }

        public string vistaMenuGestionArticulos()
        {
            string opcion;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("1. Añadir artículo");
            Console.WriteLine("2. Mostrar artículo");
            Console.WriteLine("0. Salir");
            Console.ForegroundColor = ConsoleColor.Gray;
            opcion = pedirOpcionMenu();
            Console.WriteLine();
            Console.WriteLine();
            return opcion;
        }

        public string vistaMenuGestionClientes()
        {
            string opcion;
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("1. Añadir cliente");
            Console.WriteLine("2. Mostrar clientes");
            Console.WriteLine("3. Mostrar cliente estandar");
            Console.WriteLine("4. Mostrar cliente premium");
            Console.WriteLine("0. Salir");
            Console.ForegroundColor = ConsoleColor.Gray;
            opcion = pedirOpcionMenu();
            Console.WriteLine();
            Console.WriteLine();
            return opcion;
        }

        public string vistaMenuGestionPedidos()
        {
            string opcion;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("1. Añadir pedido");
            Console.WriteLine("2. Eliminar pedido");
            Console.WriteLine("3. Mostrar pedido pendiente de envío");
            Console.WriteLine("4. Mostrar pedido enviado");
            Console.WriteLine("0. Salir");
            Console.ForegroundColor = ConsoleColor.Gray;
            opcion = pedirOpcionMenu();
            Console.WriteLine();
            Console.WriteLine();
            return opcion;
        }

        private string pedirOpcionMenu() 
        {
            string opcion;
            do
            {
                Console.ForegroundColor= ConsoleColor.Red;
                Console.Write("Opcion: ");
                opcion = Console.ReadLine();
                Console.ForegroundColor=ConsoleColor.Gray;
            } while (!"0123456789".Contains(opcion));

            return opcion; 

        }
    }
}
