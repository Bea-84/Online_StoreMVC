using Online_StoreMVC.Controller;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_StoreMVC.View
{
    internal class ArticuloView
    {
        ArticuloController articuloController;

        public ArticuloView()
        {

        }

        public ArticuloView(ArticuloController particuloController)
        {
            articuloController = particuloController;
        }

        public void añadirArticulo() 
        {
            Hashtable articuloHash=new Hashtable();

            Console.WriteLine("Por favor introduzca el código de el artículo");
            string codigo=Console.ReadLine();

            string descripcion = articuloController.getArticulo(codigo); 
            if(!descripcion.Equals("")) 
            {
                Console.WriteLine("Artículo con la siguente descripción:"+"\t"+descripcion+"\t"+"ya existe");   
            }
            else
            {
                Console.WriteLine("A continuación procederemos a crear un artículo");
                Console.WriteLine("Indique la descripción del artículo");
                descripcion=Console.ReadLine();
                Console.WriteLine("Indique precio artículo");
                double precio=double.Parse(Console.ReadLine());
                Console.WriteLine("Introduzca los gastos de envio");
                double gastos=double.Parse(Console.ReadLine());   
                Console.WriteLine("Indique fecha en la que estará en pedido");
                DateTime tiempo=DateTime.Parse(Console.ReadLine()); 

                articuloHash.Add("Codigo",codigo);
                articuloHash.Add("Descripcion", descripcion);
                articuloHash.Add("Precio",precio);
                articuloHash.Add("Gastos",gastos);
                articuloHash.Add("Tiempo",tiempo);

                articuloController.añadirArticulo(articuloHash);  
            }
        }

        public void mostrarArticulo()
        {
            Console.WriteLine("Por favor introduzca el código de el artículo");
            string codigo = Console.ReadLine();

            string descripcion = articuloController.getArticulo(codigo);
            if (!descripcion.Equals(""))
            {

                List<string> listaArticulos = articuloController.getArticulo2(codigo);

                Console.WriteLine("Código artículo\tDescripción artículo\tPrecio artículo\tGastos de envío\tFecha de entrega");
                Console.WriteLine("==============================================================================================");
                foreach(string articuloString in listaArticulos)
                {
                    Console.WriteLine(articuloString);     
                }
            }
            else
            {
                Console.WriteLine("Artículo inexistente"); 
            }
        } 
    }
}
