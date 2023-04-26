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
                Console.WriteLine("A continuación puede comenzar con su pedido");
                Console.WriteLine("Por favor introduzca el código de un artículo"); 
                string codigo = Console.ReadLine();

                string descripcion = pedidoController.getArticulo(codigo);
                if (!descripcion.Equals(""))
                {
                    Console.WriteLine("Artículo con la siguente descripción:" + "\t" + descripcion + "\t" + "ya existe");
                    int numPedido = pedidoController.newPedido();
                    Console.WriteLine("Su número de pedido es:" + "\t" + numPedido + "\t" + "recuérdelo para posteriores consultas");
                    Console.WriteLine("Selecciona cuántas unidades quieres del articulo");
                    int unidades=int.Parse(Console.ReadLine());
                    Console.WriteLine("Para finalizar introduzca la fecha del dia de hoy");
                    DateTime fecha=DateTime.Parse(Console.ReadLine());

                    pedidoHash.Add("Numero pedido", numPedido);
                    pedidoHash.Add("Unidades", unidades);
                    pedidoHash.Add("Fecha", fecha);
                    pedidoHash.Add("Cliente", email);
                    pedidoHash.Add("Articulo", codigo);

                    pedidoController.añadirPedido2(pedidoHash); 
                }
                else
                {
                    Console.WriteLine("No puede hacer pedido de un artículo inexistente");
                }
            }
            else
            {

                Hashtable clienteHash=new Hashtable();
                Console.WriteLine("Siga los siguientes pasos para darse de alta en Online Store"); 
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

                Console.WriteLine("A continuación puede comenzar con su pedido");
                Console.WriteLine("Por favor introduzca el código de un artículo"); 
                string codigo = Console.ReadLine();

                string descripcion = pedidoController.getArticulo(codigo);
                if (!descripcion.Equals(""))
                {
                    Console.WriteLine("Artículo con la siguente descripción:" + "\t" + descripcion + "\t" + "ya existe");
                    int numPedido = pedidoController.newPedido();
                    Console.WriteLine("Su número de pedido es:" + "\t" + numPedido + "\t" + "recuérdelo para posteriores consultas");
                    Console.WriteLine("Selecciona cuántas unidades quieres del articulo");
                    int unidades = int.Parse(Console.ReadLine());
                    Console.WriteLine("Para finalizar introduzca la fecha del dia de hoy");
                    DateTime fecha = DateTime.Parse(Console.ReadLine());

                    pedidoHash.Add("Numero pedido",numPedido);
                    pedidoHash.Add("Unidades", unidades);
                    pedidoHash.Add("Fecha", fecha);
                    pedidoHash.Add("Cliente",email);
                    pedidoHash.Add("Articulo", codigo);

                    pedidoController.añadirPedido2(pedidoHash);

                }
                else
                {
                    Console.WriteLine("No puede hacer pedido de un artículo inexistente"); 
                }
            } 
        }

        public void eliminarPedido()
        {
            Console.WriteLine("Introduce tu email");
            string email = Console.ReadLine();

            string nombre = pedidoController.getCliente(email);
            if (!nombre.Equals(""))
            {
                Console.WriteLine("Cliente ya registrado un saludo" + "\t" + nombre);
                Console.WriteLine("Introduce tu número de pedido por favor");
                int numPedido = int.Parse(Console.ReadLine());
                Console.WriteLine("¿Seguro que deseas eliminar pedido?(s/n)");
                string ok=Console.ReadLine();
                if(ok.ToUpper().Equals("S"))
                {
                    pedidoController.eliminarPedido2(numPedido);
                }
                else
                {
                    Console.WriteLine("Gracias por confiar en nosotros"); 
                }
                 
            }
            else
            {
                Console.WriteLine("Cliente inexistente");
            }
        }

        public void mostrarPedidoPendienteEnvio() 
        {
            Console.WriteLine("Introduce tu email");
            string email = Console.ReadLine();

            string nombre = pedidoController.getCliente(email);
            if (!nombre.Equals(""))
            {
                Console.WriteLine("Cliente ya registrado un saludo" + "\t" + nombre);
                Console.WriteLine("Introduce tu número de pedido por favor");
                int numPedido = int.Parse(Console.ReadLine());

                List<int> listaPedidos = pedidoController.getPedido(numPedido); 

            }
            else
            {
                Console.WriteLine("Cliente inexistente");
            }
        }

        public void mostrarPedidoEnviado()
        {
            Console.WriteLine("Introduce tu email");
            string email = Console.ReadLine();

            string nombre = pedidoController.getCliente(email);
            if (!nombre.Equals(""))
            {
                Console.WriteLine("Cliente ya registrado un saludo" + "\t" + nombre);
                Console.WriteLine("Introduce tu número de pedido por favor");
                int numPedido = int.Parse(Console.ReadLine());

                List<int> listaPedidos = pedidoController.getPedido2(numPedido); 

            }
            else
            {
                Console.WriteLine("Cliente inexistente");
            }
        }
    } 
}
