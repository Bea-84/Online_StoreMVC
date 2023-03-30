using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Online_StoreMVC.View;
using Online_StoreMVC.Model;


namespace Online_StoreMVC.Controller 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Controller controlador = new Controller();
            controlador.gestionMenu();
        }
    }
}
