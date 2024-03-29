﻿using Online_StoreMVC.Model;
using Online_StoreMVC.View;
using System;
using System.Collections;
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

        //---------------------------------------------------------------------------------------------------------------------------

        //métodos programa

        public string getCliente(string email)
        {
            string nombre = datos.getNombreClienteByEmail(email);
            return nombre;
        }

        public void añadirClientes2(Hashtable clienteHash)
        {
            datos.addCliente(clienteHash);
        }

        public void añadirPedido2(Hashtable pedidoHash)
        {
            datos.addPedido(pedidoHash); 
        }

        public string getArticulo(string codigo)
        {
            string descrip_Articulo = datos.getDescripcionArticulo(codigo);
            return descrip_Articulo;
        }

        public int newPedido() //método para nuevo numero inscripción
        {
            int newInscripcion = datos.getNewNumPedido();  
            return newInscripcion; 
        }

        public List<int> getPedido(int numPedido) //método mostrar pedido pendiente de envío
        {
            return datos.getPedidoByNum(numPedido);
        }

        public List<int> getPedido2(int numPedido) //método mostrar pedido enviado
        {
            return datos.getPedidoByNum2(numPedido);
        }

        public void eliminarPedido2(int numPedido)
        {
            datos.eliminarPedido(numPedido);
        }

      
 

    }
}
