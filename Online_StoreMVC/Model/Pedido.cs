using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_StoreMVC.Model
{
    internal class Pedido
    {
        private int num_Pedido;
        private int unidad;
        private DateTime fecha_Pedido;
        private Cliente cliente;
        private Articulo articulo;

        public int Num_Pedido { get => num_Pedido; set => num_Pedido = value; } 
        public int Unidad { get => unidad; set => unidad = value; }
        public DateTime Fecha_Pedido { get => fecha_Pedido; set => fecha_Pedido = value; }
        internal Cliente Cliente { get => cliente; set => cliente = value; }
        internal Articulo Articulo { get => articulo; set => articulo = value; }

        public override string ToString()
        {
            return num_Pedido+"\t"+unidad+"\t"+fecha_Pedido+"\t"+cliente+"\t"+articulo; 
        }
    }
}
