using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    internal class Nodo
    {
        //Atributos:
        private Libro dato;
        private Nodo derecha;
        private Nodo izquierda;

        //Constructor:
        public Nodo(Libro valor)
        {
            this.dato = valor;
            this.derecha = null;
            this.izquierda = null;
        }

        //Métodos de acceso:
        public void setDato(Libro libro)
        {
            this.dato = libro;
        }
        public Libro getDato()
        {
            return this.dato;
        }
        public void setDerecha(Nodo derecha)
        {
            this.derecha = derecha;
        }
        public Nodo getDerecha()
        {
            return this.derecha;
        }
        public void setIzquierda(Nodo izquierda)
        {
            this.izquierda = izquierda;
        }
        public Nodo getIzquierda()
        {
            return this.izquierda;
        }

    }
}
