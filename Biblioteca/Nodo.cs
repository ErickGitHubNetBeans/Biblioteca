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
        private DateTime valor;
        private Nodo siguiente;

        //Constructor por defecto:
        Nodo()
        {

        }

        //Métodos de acceso:
        public void setValor(DateTime horaFecha)
        {
            this.valor=horaFecha;
        }
        public DateTime getValor()
        {
            return this.valor;
        }
        public void setSiguiente(Nodo siguiente)
        {
            this.siguiente = siguiente;
        }
        public Nodo getSiguiente()
        {
            return this.siguiente;
        }

        //toString
        public override string? ToString()
        {
            return base.ToString();
        }
    }
}
