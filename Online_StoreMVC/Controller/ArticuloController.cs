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
    internal class ArticuloController
    {
        Datos datos;
        MenuView menuView;

        public ArticuloController(Datos pdatos)
        {
            datos = pdatos;
            menuView = new MenuView();
        }

        public void GestionMenuArticulos() 
        {
            bool salir = false;
            string opcion;

            do
            {
                opcion=menuView.vistaMenuGestionArticulos();
                switch(opcion)
                {
                    case "1":
                        añadirArticulo();
                        break;
                    case "2":
                        mostrarArticulo();
                        break;
                    case "0":
                        salir = true;
                        break;
                }
            }while(!salir);
        }

        //métodos menú

        public void añadirArticulo()
        {
            ArticuloController articuloController = new ArticuloController(datos);
            ArticuloView articuloView = new ArticuloView(articuloController);
            articuloView.añadirArticulo();
        }

        public void mostrarArticulo()
        {
            ArticuloController articuloController = new ArticuloController(datos);
            ArticuloView articuloView = new ArticuloView(articuloController);
            articuloView.mostrarArticulo(); 
        }

        //------------------------------------------------------------------------------------------------------------------------------

        //métodos programa

        public string getArticulo(string codigo)
        {
            string descrip_Articulo = datos.getDescripcionArticulo(codigo); 
            return descrip_Articulo;
        }

        public void añadirArticulo(Hashtable articuloHash)
        {
            datos.addArticulo(articuloHash);
        }

        public List<string> getArticulo2(string codigo)
        {
            return datos.getArticuloByCodigo(codigo); 
        } 
    }
}
