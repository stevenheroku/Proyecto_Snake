using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_Proyecto.Estructura_No._1
{
    class Nodo
    {
        public Object elemento;
        public Nodo siguiente;


        public Nodo(Object dato)
        {
            elemento = dato;
            siguiente = null;
        }


    }
}