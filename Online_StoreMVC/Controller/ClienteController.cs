using Online_StoreMVC.Model;
using Online_StoreMVC.View;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_StoreMVC.Controller
{
    internal class ClienteController
    {
        Datos datos;
        MenuView menuView;

        public ClienteController(Datos pdatos)
        {
            datos= pdatos;
            menuView = new MenuView();
        }

        public void GestionMenuClientes() 
        {
            bool salir = false;
            string opcion;

            do
            {
                opcion = menuView.vistaMenuGestionClientes();
                switch (opcion)
                {
                    case "1":
                        añadirClientes();
                        break;
                    case "2":
                        mostrarClientes();
                        break;
                    case "3":
                        mostrarClientesEstandar();
                        break;
                    case "4":
                        mostrarClientesPremium();
                        break;
                    case "0":
                        salir = true;
                        break; 


                }
            } while (!salir);
        }

        //métodos menú

        public void añadirClientes()
        {
            ClienteController clienteController = new ClienteController(datos);
            ClienteView clienteView = new ClienteView(clienteController);
            clienteView.añadirClientes();
        }

        public void mostrarClientes()
        {
            ClienteController clienteController=new ClienteController(datos);
            ClienteView clienteView=new ClienteView(clienteController);
            clienteView.mostrarClientes();
        }

        public void mostrarClientesEstandar()
        {

        }

        public void mostrarClientesPremium()
        {

        }

        //--------------------------------------------------------------------------------------------------------------------------------

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

        public List<string> getCliente2(string email)
        {
            return datos.getClienteByEmail(email); 
        } 
   }
}
