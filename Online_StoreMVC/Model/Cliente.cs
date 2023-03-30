using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_StoreMVC.Model
{
    internal class Cliente
    {

        private string nombre;
        private string domicilio;
        private int nif;
        private string email;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Domicilio { get => domicilio; set => domicilio = value; }
        public int Nif { get => nif; set => nif = value; }
        public string Email { get => email; set => email = value; }

        public override string ToString()
        {
            return nombre+"\t"+domicilio+"\t"+nif+"\t"+email; 
        }
    }
}
