using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Online_StoreMVC.View;
using Online_StoreMVC.Model;

namespace Online_StoreMVC.Controller
{
    internal class Controller
    {
        Datos datos;
        MenuView vista;

        public Controller(Datos datos, MenuView vista)
        {
            this.datos = datos;
            this.vista = vista;

        }
        public Controller()
        {
            datos = new Datos();
            vista = new MenuView();

        }

        public void gestionMenu()
        {
            bool salir = false;
            string opcion;

            do
            {
                opcion = vista.vistaMenu();
                switch (opcion)
                {
                    case "1":
                        gestionMenuArticulos();
                        break;
                    case "2":
                        gestionMenuClientes();
                        break;
                    case "3":
                        gestionMenuPedidos();
                        break;

                    case "0":
                        salir = true;
                        break;
                }

            } while (!salir);
        }

        public void gestionMenuArticulos()
        {
            ArticuloController articuloController=new ArticuloController(datos);
            ArticuloView articuloView=new ArticuloView(articuloController);
            articuloController.GestionMenuArticulos();
        }

        public void gestionMenuClientes()
        {
            ClienteController clienteController=new ClienteController(datos);
            ClienteView clienteView = new ClienteView(clienteController);
            clienteController.GestionMenuClientes(); 

        }

        public void gestionMenuPedidos()
        {
            PedidoController pedidoController=new PedidoController(datos);
            PedidoView pedidoView=new PedidoView(pedidoController);
            pedidoController.GestionMenuPedidos();  
           
        } 
    }
}
