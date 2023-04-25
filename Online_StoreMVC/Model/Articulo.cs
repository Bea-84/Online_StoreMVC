using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_StoreMVC.Model
{
    internal class Articulo
    {
        private string codigo;
        private string descripcion;
        private double precio;
        private double gastos_envio;
        private DateTime tiempo_preparacion; 

        public string Codigo { get => codigo; set => codigo = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public double Precio { get => precio; set => precio = value; }
        public double Gastos_envio { get => gastos_envio; set => gastos_envio = value; }
        public DateTime Tiempo_preparacion { get => tiempo_preparacion; set => tiempo_preparacion = value; }

        public override string ToString()
        {
            return codigo+"\t"+descripcion+"\t"+precio+"\t"+gastos_envio+"\t"+tiempo_preparacion;  
        }

    }
}
