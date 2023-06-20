using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    internal class ABB 
    {
        //Atributos:
        private Nodo raiz;
        private Nodo hijoIzquierdo;
        private Nodo hijoDerecho;

        //Constructor:
        public ABB()
        {

        }
        //Métodos de acceso:
        public void setRaiz(Nodo raiz)
        {
            this.raiz = raiz;
        }
        public Nodo getRaiz()
        {
            return this.raiz;
        }
        public void setHijoIzquierdo(Nodo izquierdo)
        {
            this.hijoIzquierdo = izquierdo;
        }
        public Nodo getHijoIzquierdo()
        {
            return this.hijoIzquierdo;
        }
        public void setHijoDerecho(Nodo derecho)
        {
            this.hijoDerecho = derecho;
        }
        public Nodo getHijoDerecho()
        {
            return this.hijoDerecho;
        }

        //toString
        public override string? ToString()
        {
            return base.ToString();
        }
    }
}
