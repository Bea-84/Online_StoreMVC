using Online_StoreMVC.Controller;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_StoreMVC.View
{
    internal class ClienteView
    {
        ClienteController clienteController;

        public ClienteView()
        {

        }

        public ClienteView(ClienteController pclienteController)
        {
            clienteController = pclienteController; 
        }

        public void añadirClientes() 
        {
            Hashtable clienteHash=new Hashtable();

            Console.WriteLine("Introduce tu email");
            string email=Console.ReadLine();

            string nombre = clienteController.getCliente(email);
            if(!nombre.Equals(""))
            {
                Console.WriteLine("Cliente ya registrado un saludo"+"\t"+nombre);
            }
            else
            {
                Console.WriteLine("Indique tu nombre");
                string nombreCliente=Console.ReadLine();
                Console.WriteLine("Indique su dirección");
                string direccion=Console.ReadLine();
                Console.WriteLine("Indique tu nif");
                int nif=int.Parse(Console.ReadLine());
                Console.WriteLine("Bienvenido a Online Store");
               

                clienteHash.Add("Nombre",nombreCliente);
                clienteHash.Add("Direccion",direccion);
                clienteHash.Add("Nif",nif);
                clienteHash.Add("Email",email);

                clienteController.añadirClientes2(clienteHash); 

            }
        }

        public void mostrarClientes() 
        {
            Console.WriteLine("Introduce tu email");
            string email = Console.ReadLine();

            string nombre = clienteController.getCliente(email);
            if (!nombre.Equals(""))
            {
                List<string> listaClientes = clienteController.getCliente2(email);

                Console.WriteLine("Nombre cliente\tDomicilio cliente\tNif cliente\tEmail cliente");
                Console.WriteLine("=============================================================");
                foreach(string clienteString in listaClientes)
                {
                    Console.WriteLine(clienteString);
                }

            }
            else
            {
                Console.WriteLine("Cliente inexistente");
            }
        } 
    } 
}
