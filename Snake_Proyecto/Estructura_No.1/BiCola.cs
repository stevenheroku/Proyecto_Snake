using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_Proyecto.Estructura_No._1
{
    class BiCola : ColaConLista
    {


        public void ponerFinal(Object elemento)
        {
            Insertar(elemento);
        }

        public void ponerFrente(Object elemento)
        {
            Nodo nuevo;
            nuevo = new Nodo(elemento);
            if (ColaVacia())
            {
                ultimo = nuevo;
            }
            nuevo.siguiente = primero;
            primero = nuevo;
        }

        //quitar elemento

        public Object quitarFrente()
        {
            return quitar();
        }

        //retirar el elemento al final
        //metodo propio de bicola
        //Es necesario hacer una iteracion de la bicola 
        //para llegar del nodo anterior al final, para despues
        // enlazar y ajustar la cola

        public Object quitarFinal()
        {
            Object aux;
            if (!ColaVacia())
            {
                if (primero == ultimo)
                {
                    aux = quitar();
                }
                else
                {
                    //como no tiene elementos vamos a iterar
                    Nodo nuevo = primero;
                    while (nuevo.siguiente != ultimo)
                    {
                        nuevo = nuevo.siguiente;
                    }

                    //siguiente del nodo anterior lo vamos a poner en null
                    nuevo.siguiente = nuevo;
                    aux = ultimo.elemento;
                    ultimo = nuevo;
                }
            }
            else
            {
                throw new Exception("COLA VACIA");
            }
            return aux;
        }


        //retorna el valor que se encuentra en el primer elemento o frente de la cola
        public Object frenteBicola()
        {
            return frenteCola();
        }

        //devolver el final de la cola
        public Object finalBicola()
        {
            if (ColaVacia())
            {
                throw new Exception("COLA VACIA");
            }

            return (ultimo.elemento);
        }

        //si esta vacia o no

        public bool bicolaVacia()
        {
            return ColaVacia();
        }

        //borra la bicola
        public void borrarBicola()
        {
            borrarCola();
        }


        //conteo de elemento

        public int numElementosBicoLa()
        {
            int n;
            Nodo a = primero;

            if (bicolaVacia())
            {
                n = 0;
            }
            else
            {
                n = 1;
                while (a != ultimo)
                {
                    n++;
                    a = a.siguiente;

                }
            }

            return n;
        }

        public bool Any(Point dato )
        {
            int i = 0, cont = 0;

            Nodo aux = primero;
            bool flag;
            while(aux !=null)
            {
                Point a = (Point)aux.elemento;
                flag = ((a.X == dato.X) && (a.Y == dato.Y));
                int z = (flag == true) ? cont++ : cont + 0;
                i++;
                aux = aux.siguiente;
            }
            return (cont != 0) ? true : false;
        }


    }
}

