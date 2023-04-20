using Online_StoreMVC.Controller;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_StoreMVC.View
{
    internal class PedidoView
    {
        PedidoController pedidoController;

        public PedidoView()
        {

        }

        public PedidoView(PedidoController ppedidoController)
        {
            pedidoController = ppedidoController;
        }

        public void añadirPedido()
        {
            Hashtable pedidoHash = new Hashtable();

            Console.WriteLine("Introduce tu email");
            string email = Console.ReadLine();

            string nombre = pedidoController.getCliente(email);
            if (!nombre.Equals(""))
            {
                Console.WriteLine("Cliente ya registrado un saludo" + "\t" + nombre);
                Console.WriteLine("Por favor introduzca el código de el artículo");
                string codigo = Console.ReadLine();

                string descripcion = pedidoController.getArticulo(codigo);
                if (!descripcion.Equals(""))
                {
                    Console.WriteLine("Artículo con la siguente descripción:" + "\t" + descripcion + "\t" + "ya existe");
                    int numPedido = pedidoController.newPedido();
                    Console.WriteLine("Su número de pedido es:" + "\t" + numPedido + "\t" + "recuérdelo para posteriores consultas");
                    Console.WriteLine("Selecciona cuántas unidades quieres del articulo");
                    int unidades=int.Parse(Console.ReadLine());
                    Console.WriteLine("Introduzca la fecha");
                    DateTime fecha=DateTime.Parse(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("Articulo inexistente");
                }
            }
            else
            {

                Hashtable clienteHash=new Hashtable();
                Console.WriteLine("Indique tu nombre");
                string nombreCliente = Console.ReadLine();
                Console.WriteLine("Indique su dirección");
                string direccion = Console.ReadLine();
                Console.WriteLine("Indique tu nif");
                int nif = int.Parse(Console.ReadLine());
                Console.WriteLine("Bienvenido a Online Store");


                clienteHash.Add("Nombre", nombreCliente);
                clienteHash.Add("Direccion", direccion);
                clienteHash.Add("Nif", nif);
                clienteHash.Add("Email", email);

                pedidoController.añadirClientes2(clienteHash);

                Console.WriteLine("Por favor introduzca el código de el artículo");
                string codigo = Console.ReadLine();

                string descripcion = pedidoController.getArticulo(codigo);
                if (!descripcion.Equals(""))
                {
                    Console.WriteLine("Artículo con la siguente descripción:" + "\t" + descripcion + "\t" + "ya existe");
                }
                else
                {
                    Console.WriteLine("Articulo inexistente"); 
                }
            }




        }

        public void eliminarPedido()
        {

        }

        public void mostrarPedidoPendienteEnvio()
        {

        }

        public void mostrarPedidoEnviado()
        {

        }
    }
}
