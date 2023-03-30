﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_StoreMVC.Model
{
    internal class Datos
    {
        private List<Articulo> articulos;
        private List<Cliente> clientes;
        private List<Pedido> pedidos;

        public Datos()
        {
            articulos = new List<Articulo>();
            clientes = new List<Cliente>();
            pedidos = new List<Pedido>();
        }

        //Articulos

        public string getDescripcionArticulo(string codigo)
        {
            foreach(Articulo articulo in articulos)
            {
                if(articulo.Codigo.Equals(codigo))
                {
                    return articulo.Descripcion;
                }
            }
            return "";  
        }

        public void addArticulo(Hashtable articuloHash)
        {
            Articulo articulo = new Articulo();
            articulo.Codigo = (string)articuloHash["Codigo"];
            articulo.Descripcion = (string)articuloHash["Descripcion"];
            articulo.Precio = (double)articuloHash["Precio"];
            articulo.Gastos_envio = (double)articuloHash["Gastos"];
            articulo.Tiempo_preparacion = (string)articuloHash["Tiempo"];

            articulos.Add(articulo);    
        }

        public List<string>getArticuloByCodigo(string codigo)
        {
            List<string> listaArticulos = new List<string>();
            
            foreach(Articulo articulo in articulos)
            {
                if(articulo.Codigo.Equals(codigo))
                {
                    listaArticulos.Add(articulo.ToString());
                }
            }
            return listaArticulos; 
        } 

        //------------------------------------------------------------------------------------------------------------------------------

        //clientes

        public string getNombreClienteByEmail(string email)
        {
            foreach(Cliente cliente in clientes)
            {
                if(cliente.Email.Equals(email))
                {
                    return cliente.Nombre;
                }
            }return ""; 
        }

        public void addCliente(Hashtable clienteHash)
        {
            Cliente cliente = new Cliente();
            cliente.Nombre = (string)clienteHash["Nombre"];
            cliente.Domicilio = (string)clienteHash["Direccion"];
            cliente.Nif = (int)clienteHash["Nif"];
            cliente.Email = (string)clienteHash["Email"];

            clientes.Add(cliente);
        }

        public List<string> getClienteByEmail(string email)
        {
            List<string> listaClientes = new List<string>();

            foreach(Cliente cliente in clientes)
            {
                if(cliente.Email.Equals(email))
                {
                    listaClientes.Add(cliente.ToString());
                }
            }
            return listaClientes; 
        }

        //----------------------------------------------------------------------------------------------------------------------------------

        //Pedidos




    }
}