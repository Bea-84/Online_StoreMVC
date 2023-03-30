using Online_StoreMVC.Model;
using Online_StoreMVC.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_StoreMVC.Controller
{
    internal class PedidoController
    {
        Datos datos;
        MenuView menuView;

        public PedidoController(Datos pdatos)
        {
            datos = pdatos;
            menuView = new MenuView();
        }

        public void GestionMenuPedidos()
        {
            bool salir = false;
            string opcion;

            do
            {
                opcion = menuView.vistaMenuGestionPedidos();
                switch (opcion)
                {
                    case "1":
                        añadirPedido();
                        break;
                    case "2":
                        eliminarPedido();
                        break;
                    case "3":
                        mostrarPedidoPendienteEnvio();
                        break;
                    case "4":
                        mostrarPedidoEnviado();
                        break;
                    case "0":
                        salir = true;
                        break;
                }
            } while (!salir);
        }

        public void añadirPedido()
        {
            PedidoController pedidoController=new PedidoController(datos);
            PedidoView pedidoView=new PedidoView(pedidoController);
            pedidoView.añadirPedido();
        }

        public void eliminarPedido()
        {
            PedidoController pedidoController = new PedidoController(datos);
            PedidoView pedidoView = new PedidoView(pedidoController);
            pedidoView.eliminarPedido(); 
        }

        public void mostrarPedidoPendienteEnvio()
        {
            PedidoController pedidoController = new PedidoController(datos);
            PedidoView pedidoView = new PedidoView(pedidoController);
            pedidoView.mostrarPedidoPendienteEnvio();
        }

        public void mostrarPedidoEnviado()
        {
            PedidoController pedidoController = new PedidoController(datos);
            PedidoView pedidoView = new PedidoView(pedidoController);
            pedidoView.mostrarPedidoEnviado();
        } 
    }
}
