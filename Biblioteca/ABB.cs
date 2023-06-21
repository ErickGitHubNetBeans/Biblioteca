using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    internal class ABB 
    {
        //Atributos
        private Libro l;
        private ABB izq, der;

        public bool isEmpty()
        {
            return this.l is null;
        }

        public bool treeWithoutSheets()
        {
            return this.l is not null && this.izq is null && this.der is null;
        }

        public void add(Libro lib)
        {
            if (this.isEmpty())
            {
                // Por comentar.
                this.l = lib;
            }
            else
            {
                if (this.l.compare(lib) > 0)
                {
                    // Por comentar.
                    if (this.der is null) { this.der = new ABB(); }
                    this.der.add(lib);
                }
                else if (this.l.compare(lib) < 0)
                {
                    // Por comentar.
                    if (this.izq is null) { this.izq = new ABB(); }
                    this.izq.add(lib);
                }
                else
                {
                    //Por comentar.
                    Console.WriteLine("Existe un libro con el mismo id.");
                }
            }
        }
    }
}
